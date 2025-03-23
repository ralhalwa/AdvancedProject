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
            label2 = new Label();
            lblBackup = new Label();
            ((System.ComponentModel.ISupportInitialize)gridBackupLogs).BeginInit();
            SuspendLayout();
            // 
            // lblGenerateReports
            // 
            lblGenerateReports.AutoSize = true;
            lblGenerateReports.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGenerateReports.Location = new Point(31, 620);
            lblGenerateReports.Name = "lblGenerateReports";
            lblGenerateReports.Size = new Size(230, 37);
            lblGenerateReports.TabIndex = 33;
            lblGenerateReports.Text = "Generate Reports";
            // 
            // lblPerformDBBackup
            // 
            lblPerformDBBackup.AutoSize = true;
            lblPerformDBBackup.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPerformDBBackup.Location = new Point(31, 548);
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
            lblExit.Location = new Point(31, 763);
            lblExit.Name = "lblExit";
            lblExit.Size = new Size(62, 37);
            lblExit.TabIndex = 28;
            lblExit.Text = "Exit";
            // 
            // lblLogOut
            // 
            lblLogOut.AutoSize = true;
            lblLogOut.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogOut.Location = new Point(31, 689);
            lblLogOut.Name = "lblLogOut";
            lblLogOut.Size = new Size(115, 37);
            lblLogOut.TabIndex = 27;
            lblLogOut.Text = "Log Out";
            // 
            // lblAuditLogs
            // 
            lblAuditLogs.AutoSize = true;
            lblAuditLogs.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAuditLogs.Location = new Point(31, 478);
            lblAuditLogs.Name = "lblAuditLogs";
            lblAuditLogs.Size = new Size(213, 37);
            lblAuditLogs.TabIndex = 26;
            lblAuditLogs.Text = "View Audit Logs";
            // 
            // lblEquipmentManagement
            // 
            lblEquipmentManagement.AutoSize = true;
            lblEquipmentManagement.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEquipmentManagement.Location = new Point(31, 409);
            lblEquipmentManagement.Name = "lblEquipmentManagement";
            lblEquipmentManagement.Size = new Size(320, 37);
            lblEquipmentManagement.TabIndex = 25;
            lblEquipmentManagement.Text = "Equipment Management";
            // 
            // lblReturnRecords
            // 
            lblReturnRecords.AutoSize = true;
            lblReturnRecords.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReturnRecords.Location = new Point(31, 342);
            lblReturnRecords.Name = "lblReturnRecords";
            lblReturnRecords.Size = new Size(203, 37);
            lblReturnRecords.TabIndex = 24;
            lblReturnRecords.Text = "Return Records";
            // 
            // lblRentalTransactions
            // 
            lblRentalTransactions.AutoSize = true;
            lblRentalTransactions.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRentalTransactions.Location = new Point(31, 277);
            lblRentalTransactions.Name = "lblRentalTransactions";
            lblRentalTransactions.Size = new Size(254, 37);
            lblRentalTransactions.TabIndex = 23;
            lblRentalTransactions.Text = "Rental Transactions";
            // 
            // lblRentalRequests
            // 
            lblRentalRequests.AutoSize = true;
            lblRentalRequests.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRentalRequests.Location = new Point(31, 211);
            lblRentalRequests.Name = "lblRentalRequests";
            lblRentalRequests.Size = new Size(211, 37);
            lblRentalRequests.TabIndex = 22;
            lblRentalRequests.Text = "Rental Requests";
            // 
            // lblDashboard
            // 
            lblDashboard.AutoSize = true;
            lblDashboard.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDashboard.Location = new Point(31, 147);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new Size(150, 37);
            lblDashboard.TabIndex = 21;
            lblDashboard.Text = "Dashboard";
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
            // label2
            // 
            label2.BackColor = Color.FromArgb(249, 115, 22);
            label2.Location = new Point(-8, 537);
            label2.Name = "label2";
            label2.Size = new Size(384, 64);
            label2.TabIndex = 37;
            // 
            // lblBackup
            // 
            lblBackup.AutoSize = true;
            lblBackup.BackColor = Color.FromArgb(249, 115, 22);
            lblBackup.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBackup.ForeColor = Color.White;
            lblBackup.Location = new Point(31, 550);
            lblBackup.Name = "lblBackup";
            lblBackup.Size = new Size(332, 37);
            lblBackup.TabIndex = 38;
            lblBackup.Text = "Perform Database Backup";
            // 
            // DatabaseBackup
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1385, 838);
            Controls.Add(lblBackup);
            Controls.Add(label2);
            Controls.Add(lblGenerateReports);
            Controls.Add(lblPerformDBBackup);
            Controls.Add(gridBackupLogs);
            Controls.Add(btnInitiateBackup);
            Controls.Add(lblExit);
            Controls.Add(lblLogOut);
            Controls.Add(lblAuditLogs);
            Controls.Add(lblEquipmentManagement);
            Controls.Add(lblReturnRecords);
            Controls.Add(lblRentalTransactions);
            Controls.Add(lblRentalRequests);
            Controls.Add(lblDashboard);
            Controls.Add(label1);
            Controls.Add(lblDivider);
            Controls.Add(lblRole);
            Controls.Add(lblName);
            Name = "DatabaseBackup";
            Text = "Database Backup";
            Load += DatabaseBackup_Load;
            ((System.ComponentModel.ISupportInitialize)gridBackupLogs).EndInit();
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
        private Label label2;
        private Label lblBackup;
    }
}