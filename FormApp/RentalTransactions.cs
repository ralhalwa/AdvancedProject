using ClassLibrary.Persistence;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormApp
{
    public partial class RentalTransactions : Form
    {

        private DBContext context;
        public RentalTransactions()
        {
            InitializeComponent();
            context = new DBContext();
        }

        private void RentalTransactions_Load(object sender, EventArgs e)
        {
            LoadRentalTransactions();
        }

        private void LoadRentalTransactions()
        {
            transactionGrid.DataSource = context.RentalTransactions.ToList();
        }

        private void lblTransactions_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (transactionGrid.SelectedRows.Count > 0)
            {
                // Get the selected transaction ID
                int transactionId = (int)transactionGrid.SelectedRows[0].Cells["ID"].Value;

                // Find the transaction in the database
                var transactionToDelete = context.RentalTransactions.Find(transactionId);

                if (transactionToDelete != null)
                {
                    // Remove the transaction
                    context.RentalTransactions.Remove(transactionToDelete);
                    context.SaveChanges(); // Save the changes to the database

                    // Reload the data
                    LoadRentalTransactions();
                }
            }
            else
            {
                MessageBox.Show("Please select a transaction to delete.");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Get the transaction ID from a TextBox named txtTransactionID
            if (int.TryParse(txtTransactionID.Text, out int transactionId))
            {
                var transaction = context.RentalTransactions.Find(transactionId);

                if (transaction != null)
                {
                    // Display the transaction details in the DataGridView named transactionGrid
                    transactionGrid.DataSource = new[] { transaction }.ToList(); // Wrap in array to convert to list
                }
                else
                {
                    MessageBox.Show("Transaction not found.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid Transaction ID.");
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            // Get the rental status from a TextBox named txtRentalStatus
            string rentalStatus = txtTransactionID.Text.Trim();

            var filteredTransactions = context.RentalTransactions
                .Where(t => t.RentalStatus.ToString().Contains(rentalStatus))
                .ToList();

            if (filteredTransactions.Any())
            {
                transactionGrid.DataSource = filteredTransactions;
            }
            else
            {
                MessageBox.Show("No transactions found with the specified criteria.");
                LoadRentalTransactions(); // Reload original data if no match
            }
        }
    }
}
