using FormApp.Classes;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormApp.Forms
{
    public partial class UpdateTransaction : Form
    {
        private int transactionId;

        public UpdateTransaction(int id)
        {
            InitializeComponent();
            transactionId = id;

            // display user info
            lblName.Text = UserSession.FullName;

            if (UserSession.RoleID == 1)
            {
                lblRole.Text = "Admin";
            }

            else if (UserSession.RoleID == 2)
            {
                lblRole.Text = "Manager";
            }

            this.StartPosition = FormStartPosition.CenterScreen;

            // setting placeholders
            PlaceholderService.SetPlaceholder(txtUserID, "User ID");
            PlaceholderService.SetPlaceholder(txtPickupDate, "Pickup Date");
            PlaceholderService.SetPlaceholder(txtReturnDate, "Return Date");
            PlaceholderService.SetPlaceholder(txtFee, "Fee");
            PlaceholderService.SetPlaceholder(txtDeposit, "Deposit");

            LoadDropdowns();
            LoadTransactionData(); // load current values
        }

        private void UpdateTransaction_Load(object sender, EventArgs e)
        {

        }

        private void LoadTransactionData()
        {
            using (SqlConnection conn = new SqlConnection(DBConnection.ConnectionString))
            {
                conn.Open();
                string query = @"SELECT UserID, Pickup, ReturnDate, Fee, Deposit, RentalStatus, PaymentStatus 
                         FROM Rental_Transaction WHERE ID = @ID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", transactionId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtUserID.Text = reader["UserID"].ToString();
                            txtPickupDate.Text = Convert.ToDateTime(reader["Pickup"]).ToString("yyyy-MM-dd");
                            txtReturnDate.Text = Convert.ToDateTime(reader["ReturnDate"]).ToString("yyyy-MM-dd");
                            txtFee.Text = reader["Fee"].ToString();
                            txtDeposit.Text = reader["Deposit"].ToString();
                            cmbRentalStatus.SelectedValue = Convert.ToInt32(reader["RentalStatus"]);
                            cmbPaymentStatus.SelectedValue = Convert.ToInt32(reader["PaymentStatus"]);
                        }
                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // validation
                if (string.IsNullOrWhiteSpace(txtUserID.Text) ||
            string.IsNullOrWhiteSpace(txtPickupDate.Text) ||
            string.IsNullOrWhiteSpace(txtReturnDate.Text) ||
            string.IsNullOrWhiteSpace(txtFee.Text) ||
            string.IsNullOrWhiteSpace(txtDeposit.Text) ||
            Convert.ToInt32(cmbRentalStatus.SelectedValue) == -1 ||
            Convert.ToInt32(cmbPaymentStatus.SelectedValue) == -1)
                {
                    MessageBox.Show("Please fill all the details.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txtUserID.Text.Trim(), out int userId))
                {
                    MessageBox.Show("User ID must be numeric.", "Validation Error");
                    return;
                }

                if (!UserExists(userId))
                {
                    MessageBox.Show("User ID does not exist.", "Validation Error");
                    return;
                }

                if (!DateTime.TryParse(txtPickupDate.Text.Trim(), out DateTime pickupDate) ||
                    !DateTime.TryParse(txtReturnDate.Text.Trim(), out DateTime returnDate))
                {
                    MessageBox.Show("Please enter valid dates.");
                    return;
                }

                if (returnDate <= pickupDate)
                {
                    MessageBox.Show("Return Date must be after Pickup Date.");
                    return;
                }

                if (!decimal.TryParse(txtFee.Text.Trim(), out decimal fee) ||
                    !decimal.TryParse(txtDeposit.Text.Trim(), out decimal deposit))
                {
                    MessageBox.Show("Fee and Deposit must be valid numbers.");
                    return;
                }

                if (deposit > fee)
                {
                    MessageBox.Show("Deposit cannot be greater than Fee.");
                    return;
                }

                int period = (returnDate - pickupDate).Days;
                int rentalStatusId = Convert.ToInt32(cmbRentalStatus.SelectedValue);
                int paymentStatusId = Convert.ToInt32(cmbPaymentStatus.SelectedValue);

                using (SqlConnection conn = new SqlConnection(DBConnection.ConnectionString))
                {
                    conn.Open();
                    string updateQuery = @"UPDATE Rental_Transaction 
                                   SET UserID = @UserID, Pickup = @Pickup, ReturnDate = @ReturnDate,
                                       Period = @Period, Fee = @Fee, Deposit = @Deposit, 
                                       RentalStatus = @RentalStatus, PaymentStatus = @PaymentStatus
                                   WHERE ID = @ID";

                    using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserID", userId);
                        cmd.Parameters.AddWithValue("@Pickup", pickupDate);
                        cmd.Parameters.AddWithValue("@ReturnDate", returnDate);
                        cmd.Parameters.AddWithValue("@Period", period);
                        cmd.Parameters.AddWithValue("@Fee", fee);
                        cmd.Parameters.AddWithValue("@Deposit", deposit);
                        cmd.Parameters.AddWithValue("@RentalStatus", rentalStatusId);
                        cmd.Parameters.AddWithValue("@PaymentStatus", paymentStatusId);
                        cmd.Parameters.AddWithValue("@ID", transactionId);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Transaction updated successfully!", "Success");
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating transaction:\n" + ex.Message, "Error");
            }
        }

        private void LoadDropdowns()
        {
            using (SqlConnection conn = new SqlConnection(DBConnection.ConnectionString))
            {
                conn.Open();

                // load rental status
                SqlCommand rentalCmd = new SqlCommand("SELECT ID, Status FROM Rental_Status", conn);
                SqlDataAdapter rentalAdapter = new SqlDataAdapter(rentalCmd);
                DataTable rentalTable = new DataTable();
                rentalAdapter.Fill(rentalTable);

                // add placeholder
                DataRow rentalPlaceholder = rentalTable.NewRow();
                rentalPlaceholder["ID"] = -1;
                rentalPlaceholder["Status"] = "Rental Status";
                rentalTable.Rows.InsertAt(rentalPlaceholder, 0);

                cmbRentalStatus.DataSource = rentalTable;
                cmbRentalStatus.DisplayMember = "Status";
                cmbRentalStatus.ValueMember = "ID";

                // load payment status
                SqlCommand paymentCmd = new SqlCommand("SELECT ID, Status FROM Payment_Status", conn);
                SqlDataAdapter paymentAdapter = new SqlDataAdapter(paymentCmd);
                DataTable paymentTable = new DataTable();
                paymentAdapter.Fill(paymentTable);

                // add placeholder
                DataRow paymentPlaceholder = paymentTable.NewRow();
                paymentPlaceholder["ID"] = -1;
                paymentPlaceholder["Status"] = "Payment Status";
                paymentTable.Rows.InsertAt(paymentPlaceholder, 0);

                cmbPaymentStatus.DataSource = paymentTable;
                cmbPaymentStatus.DisplayMember = "Status";
                cmbPaymentStatus.ValueMember = "ID";

                // set both dropdowns to show placeholder
                cmbRentalStatus.SelectedIndex = 0;
                cmbPaymentStatus.SelectedIndex = 0;
            }
        }

        // check if user exists
        private bool UserExists(int userId)
        {
            using (SqlConnection conn = new SqlConnection(DBConnection.ConnectionString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM dbo.[User] WHERE ID = @UserID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserID", userId);
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }

    }
}
