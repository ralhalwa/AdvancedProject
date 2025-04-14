namespace FormApp.Forms
{
    partial class DatabaseBackup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblGenerateReports = new Label();
            lblPerformDBBackup = new Label();
            gridBackupLogs = new DataGridView();
            btnInitiateBackup = new Button();
            lblExit = new Label();
            lblLogOut = new Label();
            lblAuditLogs = new Label();
            lblEquipmentManagement = new Label();
            lblReturnRecords = new Label();
            lblRentalTransactions = new Label();
            lblRentalRequests = new Label();
            lblDashboard = new Label();
            label1 = new Label();
            lblDivider = new Label();
            lblRole = new Label();
            lblName = new Label();
            lblBackup = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)gridBackupLogs).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblGenerateReports
            // 
            lblGenerateReports.AutoSize = true;
            lblGenerateReports.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGenerateReports.Location = new Point(30, 475);
            lblGenerateReports.Margin = new Padding(30, 8, 15, 20);
            lblGenerateReports.Name = "lblGenerateReports";
            lblGenerateReports.Size = new Size(230, 37);
            lblGenerateReports.TabIndex = 33;
            lblGenerateReports.Text = "Generate Reports";
            lblGenerateReports.Click += lblGenerateReports_Click;
            // 
            // lblPerformDBBackup
            // 
            lblPerformDBBackup.AutoSize = true;
            lblPerformDBBackup.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPerformDBBackup.Location = new Point(1539, 548);
            lblPerformDBBackup.Name = "lblPerformDBBackup";
            lblPerformDBBackup.Size = new Size(0, 37);
            lblPerformDBBackup.TabIndex = 32;
            // 
            // gridBackupLogs
            // 
            gridBackupLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridBackupLogs.Location = new Point(374, 211);
            gridBackupLogs.Name = "gridBackupLogs";
            gridBackupLogs.RowHeadersWidth = 82;
            gridBackupLogs.Size = new Size(1013, 630);
            gridBackupLogs.TabIndex = 31;
            // 
            // btnInitiateBackup
            // 
            btnInitiateBackup.BackColor = Color.FromArgb(249, 115, 22);
            btnInitiateBackup.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInitiateBackup.ForeColor = Color.White;
            btnInitiateBackup.Location = new Point(388, 150);
            btnInitiateBackup.Name = "btnInitiateBackup";
            btnInitiateBackup.Size = new Size(299, 46);
            btnInitiateBackup.TabIndex = 30;
            btnInitiateBackup.Text = "Initiate New Backup";
            btnInitiateBackup.UseVisualStyleBackColor = false;
            btnInitiateBackup.Click += btnInitiateBackup_Click;
            // 
            // lblExit
            // 
            lblExit.AutoSize = true;
            lblExit.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExit.Location = new Point(30, 605);
            lblExit.Margin = new Padding(30, 8, 15, 20);
            lblExit.Name = "lblExit";
            lblExit.Size = new Size(62, 37);
            lblExit.TabIndex = 28;
            lblExit.Text = "Exit";
            lblExit.Click += lblExit_Click;
            // 
            // lblLogOut
            // 
            lblLogOut.AutoSize = true;
            lblLogOut.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogOut.Location = new Point(30, 540);
            lblLogOut.Margin = new Padding(30, 8, 15, 20);
            lblLogOut.Name = "lblLogOut";
            lblLogOut.Size = new Size(115, 37);
            lblLogOut.TabIndex = 27;
            lblLogOut.Text = "Log Out";
            lblLogOut.Click += lblLogOut_Click;
            // 
            // lblAuditLogs
            // 
            lblAuditLogs.AutoSize = true;
            lblAuditLogs.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAuditLogs.Location = new Point(30, 340);
            lblAuditLogs.Margin = new Padding(30, 8, 15, 20);
            lblAuditLogs.Name = "lblAuditLogs";
            lblAuditLogs.Size = new Size(213, 37);
            lblAuditLogs.TabIndex = 26;
            lblAuditLogs.Text = "View Audit Logs";
            lblAuditLogs.Click += lblAuditLogs_Click;
            // 
            // lblEquipmentManagement
            // 
            lblEquipmentManagement.AutoSize = true;
            lblEquipmentManagement.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEquipmentManagement.Location = new Point(30, 275);
            lblEquipmentManagement.Margin = new Padding(30, 8, 15, 20);
            lblEquipmentManagement.Name = "lblEquipmentManagement";
            lblEquipmentManagement.Size = new Size(320, 37);
            lblEquipmentManagement.TabIndex = 25;
            lblEquipmentManagement.Text = "Equipment Management";
            lblEquipmentManagement.Click += lblEquipmentManagement_Click;
            // 
            // lblReturnRecords
            // 
            lblReturnRecords.AutoSize = true;
            lblReturnRecords.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReturnRecords.Location = new Point(30, 210);
            lblReturnRecords.Margin = new Padding(30, 8, 15, 20);
            lblReturnRecords.Name = "lblReturnRecords";
            lblReturnRecords.Size = new Size(203, 37);
            lblReturnRecords.TabIndex = 24;
            lblReturnRecords.Text = "Return Records";
            lblReturnRecords.Click += lblReturnRecords_Click;
            // 
            // lblRentalTransactions
            // 
            lblRentalTransactions.AutoSize = true;
            lblRentalTransactions.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRentalTransactions.Location = new Point(30, 145);
            lblRentalTransactions.Margin = new Padding(30, 8, 15, 20);
            lblRentalTransactions.Name = "lblRentalTransactions";
            lblRentalTransactions.Size = new Size(254, 37);
            lblRentalTransactions.TabIndex = 23;
            lblRentalTransactions.Text = "Rental Transactions";
            lblRentalTransactions.Click += lblRentalTransactions_Click;
            // 
            // lblRentalRequests
            // 
            lblRentalRequests.AutoSize = true;
            lblRentalRequests.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRentalRequests.Location = new Point(30, 80);
            lblRentalRequests.Margin = new Padding(30, 8, 15, 20);
            lblRentalRequests.Name = "lblRentalRequests";
            lblRentalRequests.Size = new Size(211, 37);
            lblRentalRequests.TabIndex = 22;
            lblRentalRequests.Text = "Rental Requests";
            lblRentalRequests.Click += lblRentalRequests_Click;
            // 
            // lblDashboard
            // 
            lblDashboard.AutoSize = true;
            lblDashboard.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDashboard.Location = new Point(30, 15);
            lblDashboard.Margin = new Padding(30, 15, 15, 20);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new Size(150, 37);
            lblDashboard.TabIndex = 21;
            lblDashboard.Text = "Dashboard";
            lblDashboard.Click += lblDashboard_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(236, 236, 236);
            label1.Location = new Point(374, 130);
            label1.Name = "label1";
            label1.Size = new Size(2, 670);
            label1.TabIndex = 20;
            // 
            // lblDivider
            // 
            lblDivider.BackColor = Color.FromArgb(236, 236, 236);
            lblDivider.Location = new Point(-8, 128);
            lblDivider.Name = "lblDivider";
            lblDivider.Size = new Size(1395, 2);
            lblDivider.TabIndex = 19;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRole.ForeColor = Color.FromArgb(142, 142, 147);
            lblRole.Location = new Point(31, 67);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(61, 32);
            lblRole.TabIndex = 18;
            lblRole.Text = "Role";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI Semibold", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(31, 23);
            lblName.Name = "lblName";
            lblName.Size = new Size(95, 40);
            lblName.TabIndex = 17;
            lblName.Text = "Name";
            // 
            // lblBackup
            // 
            lblBackup.AutoSize = true;
            lblBackup.BackColor = Color.FromArgb(249, 115, 22);
            lblBackup.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBackup.ForeColor = Color.White;
            lblBackup.Location = new Point(29, 12);
            lblBackup.Margin = new Padding(30, 8, 15, 20);
            lblBackup.Name = "lblBackup";
            lblBackup.Size = new Size(332, 37);
            lblBackup.TabIndex = 38;
            lblBackup.Text = "Perform Database Backup";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.Controls.Add(lblDashboard);
            flowLayoutPanel1.Controls.Add(lblRentalRequests);
            flowLayoutPanel1.Controls.Add(lblRentalTransactions);
            flowLayoutPanel1.Controls.Add(lblReturnRecords);
            flowLayoutPanel1.Controls.Add(lblEquipmentManagement);
            flowLayoutPanel1.Controls.Add(lblAuditLogs);
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(lblGenerateReports);
            flowLayoutPanel1.Controls.Add(lblLogOut);
            flowLayoutPanel1.Controls.Add(lblExit);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(-17, 133);
            flowLayoutPanel1.MinimumSize = new Size(379, 706);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(390, 706);
            flowLayoutPanel1.TabIndex = 39;
            flowLayoutPanel1.WrapContents = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(249, 115, 22);
            panel1.Controls.Add(lblBackup);
            panel1.Location = new Point(3, 400);
            panel1.Name = "panel1";
            panel1.Size = new Size(384, 64);
            panel1.TabIndex = 40;
            // 
            // DatabaseBackup
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1385, 838);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(lblPerformDBBackup);
            Controls.Add(gridBackupLogs);
            Controls.Add(btnInitiateBackup);
            Controls.Add(label1);
            Controls.Add(lblDivider);
            Controls.Add(lblRole);
            Controls.Add(lblName);
            Name = "DatabaseBackup";
            Text = "Database Backup";
            Load += DatabaseBackup_Load;
            ((System.ComponentModel.ISupportInitialize)gridBackupLogs).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblGenerateReports;
        private Label lblPerformDBBackup;
        private DataGridView gridBackupLogs;
        private Button btnInitiateBackup;
        private Label lblExit;
        private Label lblLogOut;
        private Label lblAuditLogs;
        private Label lblEquipmentManagement;
        private Label lblReturnRecords;
        private Label lblRentalTransactions;
        private Label lblRentalRequests;
        private Label lblDashboard;
        private Label label1;
        private Label lblDivider;
        private Label lblRole;
        private Label lblName;
        private Label lblBackup;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
    }
}