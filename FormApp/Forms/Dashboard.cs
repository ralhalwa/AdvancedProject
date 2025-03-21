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

        }

        private void lblAuditLogs_Click(object sender, EventArgs e)
        {
            AuditLogs auditLogs = new AuditLogs();
            auditLogs.Show();
            this.Hide();
        }
    }
}
