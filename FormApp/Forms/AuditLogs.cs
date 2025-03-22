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
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace FormApp.Forms
{
    public partial class AuditLogs : Form
    {
        // connection string
        private string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=NewDB;Trusted_Connection=True;";
        public AuditLogs()
        {
            InitializeComponent();

            // apply placeholder to the search bar
            PlaceholderService.SetPlaceholder(txtSearchBar, "Log ID");

            // centering the form
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void AuditLogs_Load(object sender, EventArgs e)
        {
            LoadLogs(); // load all logs on form load
        }

        // load the grid view and filter logs by id
        private void LoadLogs(string searchId = "")
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT ID, UserID, Action, TimeStamp, AffectedData,Source FROM Log";

                if (!string.IsNullOrWhiteSpace(searchId))
                {
                    query += " WHERE ID = @ID";
                }

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                if (!string.IsNullOrWhiteSpace(searchId))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@ID", searchId);
                }

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                gridLogs.DataSource = dt;
            }
        }

        // search button click event
        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadLogs(txtSearchBar.Text.Trim());
        }
    }
}
