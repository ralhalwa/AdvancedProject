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
    public partial class ReturnRecords : Form
    {
        private DBContext context;
        public ReturnRecords()
        {
            InitializeComponent();
            context = new DBContext();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ReturnRecords_Load(object sender, EventArgs e)
        {

        }

        private void ReturnRecords_Load_1(object sender, EventArgs e)
        {
            LoadReturnRecord();
        }

        private void LoadReturnRecord()
        {

            ReturnRecordGrid.DataSource = context.ReturnRecords.ToList();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Get the returnRecord ID from a TextBox named txtTransactionID
            if (int.TryParse(txtReturnRecordId.Text, out int returnId))
            {
                var returnRecord = context.ReturnRecords.Find(returnId);

                if (returnRecord != null)
                {
                    // Display the returnRecord details in the DataGridView named transactionGrid
                    ReturnRecordGrid.DataSource = new[] { returnRecord }.ToList(); // Wrap in array to convert to list
                }
                else
                {
                    MessageBox.Show("Return Record not found.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid Return Record ID.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (ReturnRecordGrid.SelectedRows.Count > 0)
            {
                // Get the selected returnRecord ID
                int returnRecordId = (int)ReturnRecordGrid.SelectedRows[0].Cells["ID"].Value;

                // Find the returnRecord in the database
                var returnRecordToDelete = context.ReturnRecords.Find(returnRecordId);

                if (returnRecordToDelete != null)
                {
                    // Remove the record
                    context.ReturnRecords.Remove(returnRecordToDelete);
                    context.SaveChanges(); // Save the changes to the database

                    // Reload the data
                    LoadReturnRecord();
                }
            }
            else
            {
                MessageBox.Show("Please select a record to delete.");
            }
        }
    }

}
