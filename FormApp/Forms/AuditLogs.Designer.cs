namespace FormApp.Forms
{
    partial class AuditLogs
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
            lblName = new Label();
            lblRole = new Label();
            lblDivider = new Label();
            label1 = new Label();
            lblDashboard = new Label();
            lblRentalRequests = new Label();
            lblRentalTransactions = new Label();
            lblReturnRecords = new Label();
            lblEquipmentManagement = new Label();
            lblAuditLogs = new Label();
            lblLogOut = new Label();
            lblExit = new Label();
            txtSearchBar = new TextBox();
            btnSearch = new Button();
            gridLogs = new DataGridView();
            lblPerformDBBackup = new Label();
            lblGenerateReports = new Label();
            lblViewAuditLogs = new Label();
            slowbarFlowPanel = new FlowLayoutPanel();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)gridLogs).BeginInit();
            slowbarFlowPanel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI Semibold", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(31, 23);
            lblName.Name = "lblName";
            lblName.Size = new Size(95, 40);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRole.ForeColor = Color.FromArgb(142, 142, 147);
            lblRole.Location = new Point(31, 67);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(61, 32);
            lblRole.TabIndex = 1;
            lblRole.Text = "Role";
            // 
            // lblDivider
            // 
            lblDivider.BackColor = Color.FromArgb(236, 236, 236);
            lblDivider.Location = new Point(-8, 128);
            lblDivider.Name = "lblDivider";
            lblDivider.Size = new Size(1395, 2);
            lblDivider.TabIndex = 2;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(236, 236, 236);
            label1.Location = new Point(374, 130);
            label1.Name = "label1";
            label1.Size = new Size(2, 670);
            label1.TabIndex = 3;
            // 
            // lblDashboard
            // 
            lblDashboard.AutoSize = true;
            lblDashboard.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDashboard.Location = new Point(30, 15);
            lblDashboard.Margin = new Padding(30, 15, 15, 20);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new Size(150, 37);
            lblDashboard.TabIndex = 4;
            lblDashboard.Text = "Dashboard";
            lblDashboard.Click += lblDashboard_Click;
            // 
            // lblRentalRequests
            // 
            lblRentalRequests.AutoSize = true;
            lblRentalRequests.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRentalRequests.Location = new Point(30, 80);
            lblRentalRequests.Margin = new Padding(30, 8, 15, 20);
            lblRentalRequests.Name = "lblRentalRequests";
            lblRentalRequests.Size = new Size(211, 37);
            lblRentalRequests.TabIndex = 5;
            lblRentalRequests.Text = "Rental Requests";
            lblRentalRequests.Click += lblRentalRequests_Click;
            // 
            // lblRentalTransactions
            // 
            lblRentalTransactions.AutoSize = true;
            lblRentalTransactions.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRentalTransactions.Location = new Point(30, 145);
            lblRentalTransactions.Margin = new Padding(30, 8, 15, 20);
            lblRentalTransactions.Name = "lblRentalTransactions";
            lblRentalTransactions.Size = new Size(254, 37);
            lblRentalTransactions.TabIndex = 6;
            lblRentalTransactions.Text = "Rental Transactions";
            lblRentalTransactions.Click += lblRentalTransactions_Click;
            // 
            // lblReturnRecords
            // 
            lblReturnRecords.AutoSize = true;
            lblReturnRecords.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReturnRecords.Location = new Point(30, 210);
            lblReturnRecords.Margin = new Padding(30, 8, 15, 20);
            lblReturnRecords.Name = "lblReturnRecords";
            lblReturnRecords.Size = new Size(203, 37);
            lblReturnRecords.TabIndex = 7;
            lblReturnRecords.Text = "Return Records";
            lblReturnRecords.Click += lblReturnRecords_Click;
            // 
            // lblEquipmentManagement
            // 
            lblEquipmentManagement.AutoSize = true;
            lblEquipmentManagement.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEquipmentManagement.Location = new Point(30, 275);
            lblEquipmentManagement.Margin = new Padding(30, 8, 15, 20);
            lblEquipmentManagement.Name = "lblEquipmentManagement";
            lblEquipmentManagement.Size = new Size(320, 37);
            lblEquipmentManagement.TabIndex = 8;
            lblEquipmentManagement.Text = "Equipment Management";
            lblEquipmentManagement.Click += lblEquipmentManagement_Click;
            // 
            // lblAuditLogs
            // 
            lblAuditLogs.AutoSize = true;
            lblAuditLogs.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAuditLogs.Location = new Point(1525, 457);
            lblAuditLogs.Name = "lblAuditLogs";
            lblAuditLogs.Size = new Size(0, 37);
            lblAuditLogs.TabIndex = 9;
            // 
            // lblLogOut
            // 
            lblLogOut.AutoSize = true;
            lblLogOut.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogOut.Location = new Point(30, 540);
            lblLogOut.Margin = new Padding(30, 8, 15, 20);
            lblLogOut.Name = "lblLogOut";
            lblLogOut.Size = new Size(115, 37);
            lblLogOut.TabIndex = 10;
            lblLogOut.Text = "Log Out";
            lblLogOut.Click += lblLogOut_Click;
            // 
            // lblExit
            // 
            lblExit.AutoSize = true;
            lblExit.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExit.Location = new Point(30, 605);
            lblExit.Margin = new Padding(30, 8, 15, 20);
            lblExit.Name = "lblExit";
            lblExit.Size = new Size(62, 37);
            lblExit.TabIndex = 11;
            lblExit.Text = "Exit";
            lblExit.Click += lblExit_Click;
            // 
            // txtSearchBar
            // 
            txtSearchBar.BackColor = Color.WhiteSmoke;
            txtSearchBar.Location = new Point(401, 152);
            txtSearchBar.Name = "txtSearchBar";
            txtSearchBar.Size = new Size(626, 39);
            txtSearchBar.TabIndex = 12;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(249, 115, 22);
            btnSearch.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(1033, 150);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(162, 46);
            btnSearch.TabIndex = 13;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // gridLogs
            // 
            gridLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridLogs.Location = new Point(378, 211);
            gridLogs.Name = "gridLogs";
            gridLogs.RowHeadersWidth = 82;
            gridLogs.Size = new Size(1009, 628);
            gridLogs.TabIndex = 14;
            // 
            // lblPerformDBBackup
            // 
            lblPerformDBBackup.AutoSize = true;
            lblPerformDBBackup.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPerformDBBackup.Location = new Point(30, 410);
            lblPerformDBBackup.Margin = new Padding(30, 8, 15, 20);
            lblPerformDBBackup.Name = "lblPerformDBBackup";
            lblPerformDBBackup.Size = new Size(332, 37);
            lblPerformDBBackup.TabIndex = 15;
            lblPerformDBBackup.Text = "Perform Database Backup";
            lblPerformDBBackup.Click += lblPerformDBBackup_Click;
            // 
            // lblGenerateReports
            // 
            lblGenerateReports.AutoSize = true;
            lblGenerateReports.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGenerateReports.Location = new Point(30, 475);
            lblGenerateReports.Margin = new Padding(30, 8, 15, 20);
            lblGenerateReports.Name = "lblGenerateReports";
            lblGenerateReports.Size = new Size(230, 37);
            lblGenerateReports.TabIndex = 16;
            lblGenerateReports.Text = "Generate Reports";
            lblGenerateReports.Click += lblGenerateReports_Click;
            // 
            // lblViewAuditLogs
            // 
            lblViewAuditLogs.AutoSize = true;
            lblViewAuditLogs.BackColor = Color.FromArgb(249, 115, 22);
            lblViewAuditLogs.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblViewAuditLogs.ForeColor = Color.White;
            lblViewAuditLogs.Location = new Point(33, 12);
            lblViewAuditLogs.Margin = new Padding(30, 8, 15, 20);
            lblViewAuditLogs.Name = "lblViewAuditLogs";
            lblViewAuditLogs.Size = new Size(213, 37);
            lblViewAuditLogs.TabIndex = 18;
            lblViewAuditLogs.Text = "View Audit Logs";
            // 
            // slowbarFlowPanel
            // 
            slowbarFlowPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            slowbarFlowPanel.Controls.Add(lblDashboard);
            slowbarFlowPanel.Controls.Add(lblRentalRequests);
            slowbarFlowPanel.Controls.Add(lblRentalTransactions);
            slowbarFlowPanel.Controls.Add(lblReturnRecords);
            slowbarFlowPanel.Controls.Add(lblEquipmentManagement);
            slowbarFlowPanel.Controls.Add(panel1);
            slowbarFlowPanel.Controls.Add(lblPerformDBBackup);
            slowbarFlowPanel.Controls.Add(lblGenerateReports);
            slowbarFlowPanel.Controls.Add(lblLogOut);
            slowbarFlowPanel.Controls.Add(lblExit);
            slowbarFlowPanel.FlowDirection = FlowDirection.TopDown;
            slowbarFlowPanel.Location = new Point(-7, 133);
            slowbarFlowPanel.MinimumSize = new Size(300, 700);
            slowbarFlowPanel.Name = "slowbarFlowPanel";
            slowbarFlowPanel.Size = new Size(379, 706);
            slowbarFlowPanel.TabIndex = 19;
            slowbarFlowPanel.WrapContents = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(249, 115, 22);
            panel1.Controls.Add(lblViewAuditLogs);
            panel1.Location = new Point(3, 335);
            panel1.Name = "panel1";
            panel1.Size = new Size(384, 64);
            panel1.TabIndex = 20;
            // 
            // AuditLogs
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1385, 838);
            Controls.Add(slowbarFlowPanel);
            Controls.Add(gridLogs);
            Controls.Add(btnSearch);
            Controls.Add(txtSearchBar);
            Controls.Add(lblAuditLogs);
            Controls.Add(label1);
            Controls.Add(lblDivider);
            Controls.Add(lblRole);
            Controls.Add(lblName);
            Name = "AuditLogs";
            Text = "Audit Logs";
            Load += AuditLogs_Load;
            ((System.ComponentModel.ISupportInitialize)gridLogs).EndInit();
            slowbarFlowPanel.ResumeLayout(false);
            slowbarFlowPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblRole;
        private Label lblDivider;
        private Label label1;
        private Label lblDashboard;
        private Label lblRentalRequests;
        private Label lblRentalTransactions;
        private Label lblReturnRecords;
        private Label lblEquipmentManagement;
        private Label lblAuditLogs;
        private Label lblLogOut;
        private Label lblExit;
        private TextBox txtSearchBar;
        private Button btnSearch;
        private DataGridView gridLogs;
        private Label lblPerformDBBackup;
        private Label lblGenerateReports;
        private Label lblViewAuditLogs;
        private FlowLayoutPanel slowbarFlowPanel;
        private Panel panel1;
    }
}