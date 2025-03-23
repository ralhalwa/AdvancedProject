using FormApp.Classes;
using Microsoft.Data.SqlClient;
using Microsoft.Graph.Models;
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
    public partial class DatabaseBackup : Form
    {
        public DatabaseBackup()
        {
            InitializeComponent();

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
        }

        private void DatabaseBackup_Load(object sender, EventArgs e)
        {
            LoadBackupLogs(); // load past backups on form load
        }

        private void PerformDatabaseBackup()
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show("Backup failed:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInitiateBackup_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Select folder to save the backup file";
                folderDialog.ShowNewFolderButton = true;

                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedPath = folderDialog.SelectedPath;
                    PerformDatabaseBackup(selectedPath);
                }
            }
        }

        private void PerformDatabaseBackup(string folderPath)
        {
            try
            {
                // build the backup file path
                string backupFileName = $"NewDB_Backup_{DateTime.Now:yyyyMMdd_HHmmss}.bak";
                string backupFullPath = Path.Combine(folderPath, backupFileName);

                // SQL command to backup the DB
                string backupQuery = $"BACKUP DATABASE [NewDB] TO DISK = @path";

                using (SqlConnection conn = new SqlConnection(DBConnection.ConnectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(backupQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@path", backupFullPath);
                        cmd.ExecuteNonQuery();
                    }
                }

                // log the backup
                LogBackup(UserSession.UserID, backupFullPath);

                // display success message
                MessageBox.Show("Backup completed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadBackupLogs(); // refresh the grid view
            }
            catch (Exception ex)
            {
                MessageBox.Show("Backup failed:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // inserting a new backup log
        private void LogBackup(int userId, string filePath)
        {
            using (SqlConnection conn = new SqlConnection(DBConnection.ConnectionString))
            {
                conn.Open();
                string insertQuery = @"INSERT INTO Log (UserID, Action, TimeStamp, AffectedData, Source)
                                       VALUES (@UserID, @Action, @TimeStamp, @AffectedData, @Source)";

                using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@UserID", userId);
                    cmd.Parameters.AddWithValue("@Action", "Performed Backup");
                    cmd.Parameters.AddWithValue("@TimeStamp", DateTime.Now);
                    cmd.Parameters.AddWithValue("@AffectedData", "Entire Database");
                    cmd.Parameters.AddWithValue("@Source", filePath);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // filling the grid view with backup logs
        private void LoadBackupLogs()
        {
            using (SqlConnection conn = new SqlConnection(DBConnection.ConnectionString))
            {
                conn.Open();
                string query = "SELECT ID, UserID, Action, TimeStamp, AffectedData, Source " +
                               "FROM Log WHERE Action = 'Performed Backup' ORDER BY TimeStamp DESC";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    gridBackupLogs.DataSource = table;
                }
            }
        }
    }
}
