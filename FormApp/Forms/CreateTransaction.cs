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
    public partial class CreateTransaction : Form
    {
        // connection string
        string connectionString = "Server = (localdb)\\MSSQLLocalDB; Database = NewDB; Trusted_Connection = True; ";

        public CreateTransaction()
        {
            InitializeComponent();

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
            PlaceholderService.SetPlaceholder(txtPeriod, "Period");
            PlaceholderService.SetPlaceholder(txtFee, "Fee");
            PlaceholderService.SetPlaceholder(txtDeposit, "Deposit");

            LoadDropdowns();
        }

        private void CreateTransaction_Load(object sender, EventArgs e)
        {

        }

        private void LoadDropdowns()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
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

        // when the create button is clicked
        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                // empty field check
                if (string.IsNullOrWhiteSpace(txtUserID.Text) ||
                    string.IsNullOrWhiteSpace(txtPickupDate.Text) ||
                    string.IsNullOrWhiteSpace(txtReturnDate.Text) ||
                    string.IsNullOrWhiteSpace(txtPeriod.Text) ||
                    string.IsNullOrWhiteSpace(txtFee.Text) ||
                    string.IsNullOrWhiteSpace(txtDeposit.Text) ||
                    Convert.ToInt32(cmbRentalStatus.SelectedValue) == -1 ||
                    Convert.ToInt32(cmbPaymentStatus.SelectedValue) == -1)
                {
                    MessageBox.Show("Please fill all the details.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // user ID validation (must be integer)
                if (!int.TryParse(txtUserID.Text.Trim(), out int userId))
                {
                    MessageBox.Show("Please enter a valid numeric User ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // check if user ID exists in the user table
                if (!UserExists(userId))
                {
                    MessageBox.Show("User ID does not exist in the system.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // parse and validate pickup and return dates
                if (!DateTime.TryParse(txtPickupDate.Text.Trim(), out DateTime pickupDate))
                {
                    MessageBox.Show("Please enter a valid Pickup Date.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!DateTime.TryParse(txtReturnDate.Text.Trim(), out DateTime returnDate))
                {
                    MessageBox.Show("Please enter a valid Return Date.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // return date must be later than pickup date
                if (returnDate <= pickupDate)
                {
                    MessageBox.Show("Return Date must be later than Pickup Date.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // validate numbers
                if (!decimal.TryParse(txtPeriod.Text.Trim(), out decimal period))
                {
                    MessageBox.Show("Please enter a valid numeric period.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(txtFee.Text.Trim(), out decimal fee))
                {
                    MessageBox.Show("Please enter a valid numeric fee.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(txtDeposit.Text.Trim(), out decimal deposit))
                {
                    MessageBox.Show("Please enter a valid numeric deposit.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // deposit should not be greater than fee
                if (deposit > fee)
                {
                    MessageBox.Show("Deposit cannot be greater than the fee.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int rentalStatusId = Convert.ToInt32(cmbRentalStatus.SelectedValue);
                int paymentStatusId = Convert.ToInt32(cmbPaymentStatus.SelectedValue);

                // SQL insert statement
                string query = "INSERT INTO Rental_Transaction (UserID, RentalStatus, Pickup, ReturnDate, Period, Fee, Deposit, PaymentStatus) " +
                               "VALUES (@UserID, @RentalStatus, @Pickup, @ReturnDate, @Period, @Fee, @Deposit, @PaymentStatus)";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserID", userId);
                        cmd.Parameters.AddWithValue("@RentalStatus", rentalStatusId);
                        cmd.Parameters.AddWithValue("@Pickup", pickupDate);
                        cmd.Parameters.AddWithValue("@ReturnDate", returnDate);
                        cmd.Parameters.AddWithValue("@Period", period);
                        cmd.Parameters.AddWithValue("@Fee", fee);
                        cmd.Parameters.AddWithValue("@Deposit", deposit);
                        cmd.Parameters.AddWithValue("@PaymentStatus", paymentStatusId);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Transaction created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFields();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // clear all form fields
        private void ClearFields()
            {
            txtUserID.Clear();
            txtPickupDate.Clear();
            txtReturnDate.Clear();
            txtPeriod.Clear();
            txtFee.Clear();
            txtDeposit.Clear();
            cmbRentalStatus.SelectedIndex = 0; // back to placeholder
            cmbPaymentStatus.SelectedIndex = 0; // back to placeholder
        }

        // check if user exists
        private bool UserExists(int userId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
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
