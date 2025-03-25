using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormApp.Classes;

namespace FormApp.Forms
{
    public partial class Dashboard : Form
    {
        public Dashboard()
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
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            SidebarHelper.AdjustSidebarForRole(
        UserSession.RoleID,
        new List<Label> {
            lblDashboard,
            lblRentalRequests,
            lblRentalTransactions,
            lblReturnRecords,
            lblEquipmentManagement,
            lblAuditLogs,
            lblPerformDBBackup,
            lblGenerateReports,
            lblLogOut,
            lblExit
        },
        new List<Label> {
            lblAuditLogs,
            lblPerformDBBackup,
            lblGenerateReports
        },
        topStart: lblDashboard.Top, // or a fixed value like 120
        verticalSpacing: 10
    );
        }

        private void lblAuditLogs_Click(object sender, EventArgs e)
        {
            AuditLogs auditLogs = new AuditLogs();
            auditLogs.Show();
            this.Hide();
        }

        private void lblBackup_Click(object sender, EventArgs e)
        {
            DatabaseBackup databaseBackup = new DatabaseBackup();
            databaseBackup.Show();
            this.Hide();
        }

        private void lblGenerateReports_Click(object sender, EventArgs e)
        {
            GenerateReports generateReports = new GenerateReports();
            generateReports.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateTransaction ct = new CreateTransaction();
            ct.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateTransaction ut = new UpdateTransaction(1);
            ut.Show();
            this.Hide();
        }

        private void HighlightSidebar(Label selected)
        {
            foreach (Control ctrl in flowSidebar.Controls)
            {
                if (ctrl is Label lbl)
                {
                    lbl.BackColor = Color.Transparent; // Default background
                    lbl.ForeColor = Color.Black;
                    lbl.Font = new Font(lbl.Font, FontStyle.Regular);
                }
            }

            selected.BackColor = Color.Orange;  // Highlight selected
            selected.ForeColor = Color.White;
            selected.Font = new Font(selected.Font, FontStyle.Bold);
        }
    }
}
