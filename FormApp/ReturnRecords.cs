using ClassLibrary.Models;
using ClassLibrary.Persistence;
using Microsoft.EntityFrameworkCore;
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
        DBContext context;
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
            ReturnRecordGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ReturnRecordGrid.MultiSelect = false;
            ReturnRecordGrid.ReadOnly = true;
            LoadReturnRecord();
        }

        private void ReturnRecords_Load_1(object sender, EventArgs e)
        {
            LoadReturnRecord();
        }

        private void LoadReturnRecord()
        {

            try
            {
                var records = context.ReturnRecords
                    .Include(r => r.EquipmentNavigation)
                    .Include(r => r.ConditionNavigation)
                    .Select(r => new
                    {
                        r.Id,
                        EquipmentName = r.EquipmentNavigation.Name,
                        Condition = r.ConditionNavigation.Status,
                        r.ReturnDate,
                        r.LateFees
                    }).ToList();

                ReturnRecordGrid.DataSource = records;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching records: " + ex.Message);
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string search = txtReturnRecordId.Text.ToLower();

                if (string.IsNullOrWhiteSpace(search))
                {
                    MessageBox.Show("Please enter a value to search.");
                    return;
                }

                IQueryable<ReturnRecord> query = context.ReturnRecords
                    .Include(r => r.EquipmentNavigation)
                    .Include(r => r.ConditionNavigation);

                if (int.TryParse(search, out int id))
                {
                    query = query.Where(r => r.Id == id);
                }
                else
                {
                    query = query.Where(r =>
                        r.EquipmentNavigation.Name.ToLower().Contains(search) ||
                        r.ConditionNavigation.Status.ToLower().Contains(search)
                    );
                }

                var result = query.Select(r => new
                {
                    r.Id,
                    EquipmentName = r.EquipmentNavigation.Name,
                    Condition = r.ConditionNavigation.Status,
                    r.ReturnDate,
                    r.LateFees
                }).ToList();

                if (result.Count == 0)
                    MessageBox.Show("No matching record found.");

                ReturnRecordGrid.DataSource = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during search: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (ReturnRecordGrid.SelectedRows.Count > 0)
                {
                    int id = Convert.ToInt32(ReturnRecordGrid.SelectedRows[0].Cells["Id"].Value);

                    var record = context.ReturnRecords.Find(id);

                    if (record != null)
                    {
                        var confirm = MessageBox.Show("Are you sure to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo);
                        if (confirm == DialogResult.Yes)
                        {
                            context.ReturnRecords.Remove(record);
                            context.SaveChanges();
                            MessageBox.Show("Record deleted successfully.");
                            LoadReturnRecord();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select a row to delete.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting record: " + ex.Message);
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                LoadReturnRecord();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error refreshing data: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (ReturnRecordGrid.SelectedRows.Count > 0)
                {
                    int id = Convert.ToInt32(ReturnRecordGrid.SelectedRows[0].Cells["Id"].Value);

                    // UpdateReturnRecordForm updateForm = new UpdateReturnRecordForm(id);
                    //  updateForm.ShowDialog();
                    LoadReturnRecord();
                }
                else
                {
                    MessageBox.Show("Please select a row to update.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating record: " + ex.Message);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                //  CreateReturnRecordForm createForm = new CreateReturnRecordForm();
                // createForm.ShowDialog();
                LoadReturnRecord();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating record: " + ex.Message);
            }
        }

        private void label16_Click(object sender, EventArgs e)
        {

            this.Hide();
            Dashboard dd = new Dashboard();
            dd.Show();
        }

        private void lblRequest_Click(object sender, EventArgs e)
        {
            this.Hide();
            RentalRequests rr = new RentalRequests();
            rr.Show();
        }

        private void lblEquipmentManagement_Click(object sender, EventArgs e)
        {
            this.Hide();
            EquipmentManagement eq = new EquipmentManagement();
            eq.Show();
        }

        private void lblViewAuditLogs_Click(object sender, EventArgs e)
        {
            this.Hide();
            //AuditLog aa = new AuditLog();
            //aa.Show();
        }

        private void lblDBbackup_Click(object sender, EventArgs e)
        {
            this.Hide();
            //dbBackup db = new dbBackup();
            //db.Show();
        }

        private void lblGenerateReport_Click(object sender, EventArgs e)
        {
            this.Hide();
            //GenerateReport gg = new GenerateReport();
            //gg.Show();
        }

        private void lblLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            //perfrom log out functionality
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}


