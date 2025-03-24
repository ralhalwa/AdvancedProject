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
using FormApp.Classes;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace FormApp
{
    public partial class Dashboard : Form

    {

        public Dashboard()
        {
            InitializeComponent();


            lblName.Text = UserSession.FullName;

            if (UserSession.RoleID == 1)
            {
                lblPosition.Text = "Admin";
            }

            else if (UserSession.RoleID == 2)
            {
                lblPosition.Text = "Manager";

                lblDBbackup.Hide();
                lblViewAuditLogs.Hide();
                lblGenerateReport.Hide();
            }


        }



        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            RentalRequest r = new RentalRequest();
            r.Show();

        }

        private void btnRentalTransactions_Click(object sender, EventArgs e)
        {
            this.Hide();
            RentalTransactions t = new RentalTransactions();
            t.Show();
        }

        private void btnRentalRecords_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReturnRecords ret = new ReturnRecords();
            ret.Show();
        }

        private void btnEquipmentManagement_Click(object sender, EventArgs e)
        {
            this.Hide();
            EquipmentManagement eq = new EquipmentManagement();
            eq.Show();
        }

        private void btnAuditLogs_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void btnDbBackup_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblRecentEq_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }



        private void lblOverdue_Click(object sender, EventArgs e)
        {

        }

        private void lblTransactions_Click(object sender, EventArgs e)
        {
            this.Hide();
            RentalTransactions t = new RentalTransactions();
            t.Show();
        }

        private void lblReturnRecords_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReturnRecords rr = new ReturnRecords();
            rr.Show();
        }

        private void lblRequest_Click(object sender, EventArgs e)
        {
            this.Hide();
                RentalRequest ret = new RentalRequest();
            ret.Show();
        }
    }
}
