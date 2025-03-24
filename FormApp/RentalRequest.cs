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
    public partial class RentalRequest : Form
    {
        private DBContext context;
        public RentalRequest()
        {
            InitializeComponent();
            context = new DBContext();
        }

        private void lblDashboard_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RentalRequest_Load(object sender, EventArgs e)
        {
            LoadRentalRequest();
        }

        private void LoadRentalRequest()
        {

            RentalRequestGrid.DataSource = context.RentalRequests.ToList();


        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Get the rental request ID from a TextBox named requestId
            if (int.TryParse(requestId.Text, out int rentalRequestId))
            {
                var returnRecord = context.RentalRequests.Find(rentalRequestId);

                if (returnRecord != null)
                {
                    // Display the rental request details in the DataGridView named transactionGrid
                    RentalRequestGrid.DataSource = new[] { rentalRequestId }.ToList(); // Wrap in array to convert to list
                }
                else
                {
                    MessageBox.Show("Rental Request not found.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid Rental Request ID.");
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {

            
        }
    }
}
