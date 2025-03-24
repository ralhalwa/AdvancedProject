using FormApp.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary.Persistence;
using Microsoft.IdentityModel.Tokens;

namespace FormApp.Forms
{
    public partial class GenerateReports : Form
    {
        private readonly DBContext _context;
        private string currentReport = "";

        public GenerateReports()
        {
            InitializeComponent();

            _context = new DBContext();

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
        }

        private void GenerateReports_Load(object sender, EventArgs e)
        {

        }

        private void btnActiveCustomers_Click(object sender, EventArgs e)
        {
            try
            {
                var customers = _context.Users
                    .Where(u => u.RoleId == 3)
                    .Select(u => new
                    {
                        FullName = u.Fname + " " + u.Lname,
                        u.Email,
                        TotalRentals = u.RentalTransactions.Count,
                        TotalSpent = u.RentalTransactions.Sum(t => (decimal?)t.Fee) ?? 0
                    })
                    .ToList();

                gridReports.DataSource = new BindingSource { DataSource = ToDataTable(customers) };
                currentReport = "ActiveCustomers";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load customer report:\n" + ex.Message);
            }
        }

        private void btnMostRentedEquipment_Click(object sender, EventArgs e)
        {
            try
            {
                var equipmentData = _context.RentalRequests
               .Where(r => r.Equipment != null)
               .GroupBy(r => new
               {
                   r.Equipment.Name,
                   Category = r.Equipment.Category.Name
               })
               .Select(g => new
               {
                   EquipmentName = g.Key.Name,
                   Category = g.Key.Category,
                   RentalCount = g.Count()
               })
               .OrderByDescending(e => e.RentalCount)
               .ToList();

                gridReports.DataSource = new BindingSource { DataSource = ToDataTable(equipmentData) };

                currentReport = "MostRentedEquipment";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load equipment report:\n" + ex.Message);
            }
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            if (gridReports.DataSource == null)
            {
                MessageBox.Show("No data to download.");
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "CSV files (*.csv)|*.csv";
                sfd.FileName = currentReport + "_Report.csv";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var dt = (DataTable)((BindingSource)gridReports.DataSource).DataSource;
                        ExportDataTableToCSV(dt, sfd.FileName);
                        MessageBox.Show("Report downloaded successfully!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error downloading file: " + ex.Message);
                    }
                }
            }
        }

        private void ExportDataTableToCSV(DataTable dt, string filePath)
        {
            var lines = new List<string>();

            string[] columnNames = dt.Columns.Cast<DataColumn>()
                                     .Select(column => column.ColumnName)
                                     .ToArray();

            var header = string.Join(",", columnNames);
            lines.Add(header);

            foreach (DataRow row in dt.Rows)
            {
                string[] fields = row.ItemArray.Select(field => field.ToString()).ToArray();
                lines.Add(string.Join(",", fields));
            }

            File.WriteAllLines(filePath, lines);
        }

        private DataTable ToDataTable<T>(IList<T> data)
        {
            PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();

            foreach (PropertyDescriptor prop in props)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);

            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in props)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }

            return table;
        }
    }
}
