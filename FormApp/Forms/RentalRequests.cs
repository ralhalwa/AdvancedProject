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
using ClassLibrary.Models;


namespace FormApp
{
    public partial class RentalRequests : Form
    {
        DBContext context;
        public RentalRequests()
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
            RentalRequestGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            RentalRequestGrid.MultiSelect = false;
            RentalRequestGrid.ReadOnly = true;
            LoadRentalRequest();
        }

        private void LoadRentalRequest()
        {
            try
            {
                var requests = context.RentalRequests
                    .Include(r => r.Equipment)
                    .Include(r => r.RentalStatus1)
                    .Select(r => new
                    {
                        r.Id,
                        EquipmentName = r.Equipment.Name,
                        r.StartDate,
                        r.ReturnDate,
                        r.Cost,
                        RentalStatus = r.RentalStatus1.Status
                    })
                    .ToList();

                RentalRequestGrid.DataSource = requests;
                RentalRequestGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                RentalRequestGrid.MultiSelect = false;
                RentalRequestGrid.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string search = requestId.Text.Trim();

                if (string.IsNullOrWhiteSpace(search))
                {
                    MessageBox.Show("Please enter a value to search.");
                    return;
                }

                using (DBContext context = new DBContext())
                {
                    var query = context.RentalRequests
                        .Include(r => r.Equipment)
                        .Include(r => r.RentalStatus1)
                        .AsQueryable();

                    if (int.TryParse(search, out int id))
                    {
                        query = query.Where(r => r.Id == id);
                    }
                    else
                    {
                        query = query.Where(r => r.Equipment.Name.Contains(search) ||
                                                 r.RentalStatus1.Status.Contains(search));
                    }

                    var result = query.Select(r => new
                    {
                        r.Id,
                        EquipmentName = r.Equipment.Name,
                        r.StartDate,
                        r.ReturnDate,
                        r.Cost,
                        RentalStatus = r.RentalStatus1.Status
                    }).ToList();

                    if (result.Count == 0)
                    {
                        MessageBox.Show("No matching record found.");
                        return;
                    }

                    RentalRequestGrid.DataSource = result;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadRentalRequest();
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            if (RentalRequestGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a record to reject.");
                return;
            }

            int selectedId = Convert.ToInt32(RentalRequestGrid.SelectedRows[0].Cells["Id"].Value);

            var result = MessageBox.Show("Are you sure you want to delete this request?", "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                using (var context = new DBContext())
                {
                    var request = context.RentalRequests.Find(selectedId);
                    if (request != null)
                    {
                        context.RentalRequests.Remove(request);
                        context.SaveChanges();
                        MessageBox.Show("Request deleted.");
                        LoadRentalRequest();
                    }
                }
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dd = new Dashboard();
            dd.Show();

        }

        private void lblTransactions_Click(object sender, EventArgs e)
        {
            this.Hide();
            RentalTransactions tt = new RentalTransactions();
            tt.Show();
        }

        private void lblReturnRecords_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReturnRecords rr = new ReturnRecords();
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
            //ViewAudit Form
        }

        private void lblDBbackup_Click(object sender, EventArgs e)
        {
            this.Hide();
            //dbBackup Form
        }

        private void lblGenerateReport_Click(object sender, EventArgs e)
        {
            this.Hide();
            //GenerateReport form
        }

        private void lblLogOut_Click(object sender, EventArgs e)
        {
            //logout functionality
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
