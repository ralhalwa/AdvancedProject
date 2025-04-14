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
    public partial class EquipmentManagement : Form
    {
        DBContext context;
        public EquipmentManagement()
        {
            InitializeComponent();
            context = new DBContext();
        }

        private void EquipmentManagement_Load(object sender, EventArgs e)
        {
            eqGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            eqGrid.MultiSelect = false;
            eqGrid.ReadOnly = true;
            LoadEquipment();
        }

        private void LoadEquipment()
        {

            try
            {
                var equipmentData = context.Equipment
                    .Include(e => e.Category)
                    .Include(e => e.Available)
                    .Include(e => e.Condition)
                    .Select(e => new
                    {
                        e.Id,
                        e.Name,
                        e.Description,
                        Category = e.Category.Name,
                        Availability = e.Available.Status,
                        Condition = e.Condition.Status,
                        e.Price
                    }).ToList();

                eqGrid.DataSource = equipmentData;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }


        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtSearch.Text))
                {
                    MessageBox.Show("Please enter a value to search.");
                    return;
                }

                var search = txtSearch.Text.ToLower();

                var query = from ee in context.Equipment
                            select ee;

                if (int.TryParse(search, out int id))
                {
                    query = query.Where(ee => ee.Id == id);
                }
                else
                {
                    query = query.Where(ee =>
                        ee.Name.ToLower().Contains(search) ||
                        ee.Description.ToLower().Contains(search) ||
                        ee.Category.Name.ToLower().Contains(search) ||
                        ee.Available.Status.ToLower().Contains(search) ||
                        ee.Condition.Status.ToLower().Contains(search)
                    );
                }

                var result = from ee in query
                             select new
                             {
                                 ee.Id,
                                 ee.Name,
                                 ee.Description,
                                 Category = ee.Category.Name,
                                 Availability = ee.Available.Status,
                                 Condition = ee.Condition.Status,
                                 ee.Price
                             };

                if (!result.Any())
                {
                    MessageBox.Show("No matching record found.");
                }

                eqGrid.DataSource = result.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching data: " + ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadEquipment();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (eqGrid.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a record to delete.");
                    return;
                }

                int id = Convert.ToInt32(eqGrid.SelectedRows[0].Cells["Id"].Value);

                var equipment = context.Equipment.Find(id);

                if (equipment != null)
                {
                    context.Equipment.Remove(equipment);
                    context.SaveChanges();
                    MessageBox.Show("Record deleted successfully.");
                    LoadEquipment();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting record: " + ex.Message);
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
            RentalRequests re = new RentalRequests();
            re.Show();
        }

        private void lblViewAuditLogs_Click(object sender, EventArgs e)
        {
            this.Hide();
            //ViewAudit aa = new ViewAudit();
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
            //GenReport gr = new GenReport();
            //gr.Show();
        }

        private void lblLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            //perfrom loguut function
        }

        private void lblExit_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            //AddEquipment ae = new AddEquipment();
            //ae.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (eqGrid.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a record to edit.");
                    return;
                }

                int id = Convert.ToInt32(eqGrid.SelectedRows[0].Cells["Id"].Value);

                // Find Equipment from DB
                var equipment = context.Equipment
                    .Include(e => e.Category)
                    .Include(e => e.Available)
                    .Include(e => e.Condition)
                    .FirstOrDefault(e => e.Id == id);

                if (equipment != null)
                {
                    // EditEquipmentForm editForm = new EditEquipmentForm(equipment);
                    //  editForm.ShowDialog();

                    // After editing → refresh data
                    LoadEquipment();
                }
                else
                {
                    MessageBox.Show("Record not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening edit form: " + ex.Message);
            }
        }

        private void lblTransactions_Click(object sender, EventArgs e)
        {
            this.Hide();
            RentalTransactions rt = new RentalTransactions();
            rt.Show();
        }
    }
}
