namespace FormApp.Forms
{
    partial class Dashboard
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
            lblBackup = new Label();
            lblGenerateReports = new Label();
            lblPerformDBBackup = new Label();
            lblExit = new Label();
            lblLogOut = new Label();
            lblAuditLogs = new Label();
            lblEquipmentManagement = new Label();
            lblReturnRecords = new Label();
            lblRentalTransactions = new Label();
            lblRentalRequests = new Label();
            label1 = new Label();
            lblDivider = new Label();
            lblRole = new Label();
            lblName = new Label();
            lblDashboard = new Label();
            button1 = new Button();
            button2 = new Button();
            flowSidebar = new FlowLayoutPanel();
            panelSidebarHighlight = new Panel();
            flowSidebar.SuspendLayout();
            panelSidebarHighlight.SuspendLayout();
            SuspendLayout();
            // 
            // lblBackup
            // 
            lblBackup.AutoSize = true;
            lblBackup.BackColor = Color.Transparent;
            lblBackup.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBackup.ForeColor = Color.Black;
            lblBackup.Location = new Point(3, 378);
            lblBackup.Name = "lblBackup";
            lblBackup.Padding = new Padding(25, 25, 0, 0);
            lblBackup.Size = new Size(357, 62);
            lblBackup.TabIndex = 56;
            lblBackup.Text = "Perform Database Backup";
            lblBackup.Click += lblBackup_Click;
            // 
            // lblGenerateReports
            // 
            lblGenerateReports.AutoSize = true;
            lblGenerateReports.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGenerateReports.Location = new Point(3, 440);
            lblGenerateReports.Name = "lblGenerateReports";
            lblGenerateReports.Padding = new Padding(25, 25, 0, 0);
            lblGenerateReports.Size = new Size(255, 62);
            lblGenerateReports.TabIndex = 54;
            lblGenerateReports.Text = "Generate Reports";
            lblGenerateReports.Click += lblGenerateReports_Click;
            // 
            // lblPerformDBBackup
            // 
            lblPerformDBBackup.AutoSize = true;
            lblPerformDBBackup.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPerformDBBackup.Location = new Point(532, 635);
            lblPerformDBBackup.Name = "lblPerformDBBackup";
            lblPerformDBBackup.Size = new Size(0, 37);
            lblPerformDBBackup.TabIndex = 53;
            // 
            // lblExit
            // 
            lblExit.AutoSize = true;
            lblExit.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExit.Location = new Point(3, 564);
            lblExit.Name = "lblExit";
            lblExit.Padding = new Padding(25, 25, 0, 0);
            lblExit.Size = new Size(87, 62);
            lblExit.TabIndex = 50;
            lblExit.Text = "Exit";
            // 
            // lblLogOut
            // 
            lblLogOut.AutoSize = true;
            lblLogOut.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogOut.Location = new Point(3, 502);
            lblLogOut.Name = "lblLogOut";
            lblLogOut.Padding = new Padding(25, 25, 0, 0);
            lblLogOut.Size = new Size(140, 62);
            lblLogOut.TabIndex = 49;
            lblLogOut.Text = "Log Out";
            // 
            // lblAuditLogs
            // 
            lblAuditLogs.AutoSize = true;
            lblAuditLogs.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAuditLogs.Location = new Point(3, 316);
            lblAuditLogs.Name = "lblAuditLogs";
            lblAuditLogs.Padding = new Padding(25, 25, 0, 0);
            lblAuditLogs.Size = new Size(238, 62);
            lblAuditLogs.TabIndex = 48;
            lblAuditLogs.Text = "View Audit Logs";
            lblAuditLogs.Click += lblAuditLogs_Click;
            // 
            // lblEquipmentManagement
            // 
            lblEquipmentManagement.AutoSize = true;
            lblEquipmentManagement.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEquipmentManagement.Location = new Point(3, 254);
            lblEquipmentManagement.Name = "lblEquipmentManagement";
            lblEquipmentManagement.Padding = new Padding(25, 25, 0, 0);
            lblEquipmentManagement.Size = new Size(345, 62);
            lblEquipmentManagement.TabIndex = 47;
            lblEquipmentManagement.Text = "Equipment Management";
            // 
            // lblReturnRecords
            // 
            lblReturnRecords.AutoSize = true;
            lblReturnRecords.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReturnRecords.Location = new Point(3, 192);
            lblReturnRecords.Name = "lblReturnRecords";
            lblReturnRecords.Padding = new Padding(25, 25, 0, 0);
            lblReturnRecords.Size = new Size(228, 62);
            lblReturnRecords.TabIndex = 46;
            lblReturnRecords.Text = "Return Records";
            // 
            // lblRentalTransactions
            // 
            lblRentalTransactions.AutoSize = true;
            lblRentalTransactions.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRentalTransactions.Location = new Point(3, 130);
            lblRentalTransactions.Name = "lblRentalTransactions";
            lblRentalTransactions.Padding = new Padding(25, 25, 0, 0);
            lblRentalTransactions.Size = new Size(279, 62);
            lblRentalTransactions.TabIndex = 45;
            lblRentalTransactions.Text = "Rental Transactions";
            // 
            // lblRentalRequests
            // 
            lblRentalRequests.AutoSize = true;
            lblRentalRequests.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRentalRequests.Location = new Point(3, 68);
            lblRentalRequests.Name = "lblRentalRequests";
            lblRentalRequests.Padding = new Padding(25, 25, 0, 0);
            lblRentalRequests.Size = new Size(236, 62);
            lblRentalRequests.TabIndex = 44;
            lblRentalRequests.Text = "Rental Requests";
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(236, 236, 236);
            label1.Location = new Point(377, 128);
            label1.Name = "label1";
            label1.Size = new Size(2, 720);
            label1.TabIndex = 42;
            // 
            // lblDivider
            // 
            lblDivider.BackColor = Color.FromArgb(236, 236, 236);
            lblDivider.Location = new Point(-5, 126);
            lblDivider.Name = "lblDivider";
            lblDivider.Size = new Size(1395, 2);
            lblDivider.TabIndex = 41;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRole.ForeColor = Color.FromArgb(142, 142, 147);
            lblRole.Location = new Point(34, 65);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(61, 32);
            lblRole.TabIndex = 40;
            lblRole.Text = "Role";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI Semibold", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(34, 21);
            lblName.Name = "lblName";
            lblName.Size = new Size(95, 40);
            lblName.TabIndex = 39;
            lblName.Text = "Name";
            // 
            // lblDashboard
            // 
            lblDashboard.AutoSize = true;
            lblDashboard.BackColor = Color.Transparent;
            lblDashboard.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDashboard.ForeColor = Color.White;
            lblDashboard.Location = new Point(3, -14);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Padding = new Padding(25, 25, 0, 0);
            lblDashboard.Size = new Size(175, 62);
            lblDashboard.TabIndex = 57;
            lblDashboard.Text = "Dashboard";
            // 
            // button1
            // 
            button1.Location = new Point(421, 146);
            button1.Name = "button1";
            button1.Size = new Size(291, 46);
            button1.TabIndex = 58;
            button1.Text = "Create Transaction";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(736, 146);
            button2.Name = "button2";
            button2.Size = new Size(291, 46);
            button2.TabIndex = 59;
            button2.Text = "Update Transaction\r\n\r\n";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // flowSidebar
            // 
            flowSidebar.Controls.Add(panelSidebarHighlight);
            flowSidebar.Controls.Add(lblRentalRequests);
            flowSidebar.Controls.Add(lblRentalTransactions);
            flowSidebar.Controls.Add(lblReturnRecords);
            flowSidebar.Controls.Add(lblEquipmentManagement);
            flowSidebar.Controls.Add(lblAuditLogs);
            flowSidebar.Controls.Add(lblBackup);
            flowSidebar.Controls.Add(lblGenerateReports);
            flowSidebar.Controls.Add(lblLogOut);
            flowSidebar.Controls.Add(lblExit);
            flowSidebar.FlowDirection = FlowDirection.TopDown;
            flowSidebar.Location = new Point(-5, 126);
            flowSidebar.Name = "flowSidebar";
            flowSidebar.Size = new Size(384, 731);
            flowSidebar.TabIndex = 60;
            flowSidebar.WrapContents = false;
            // 
            // panelSidebarHighlight
            // 
            panelSidebarHighlight.BackColor = Color.FromArgb(249, 115, 22);
            panelSidebarHighlight.Controls.Add(lblDashboard);
            panelSidebarHighlight.Location = new Point(3, 3);
            panelSidebarHighlight.Name = "panelSidebarHighlight";
            panelSidebarHighlight.Size = new Size(381, 62);
            panelSidebarHighlight.TabIndex = 57;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1385, 838);
            Controls.Add(flowSidebar);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lblPerformDBBackup);
            Controls.Add(label1);
            Controls.Add(lblDivider);
            Controls.Add(lblRole);
            Controls.Add(lblName);
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Load;
            flowSidebar.ResumeLayout(false);
            flowSidebar.PerformLayout();
            panelSidebarHighlight.ResumeLayout(false);
            panelSidebarHighlight.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBackup;
        private Label lblGenerateReports;
        private Label lblPerformDBBackup;
        private Label lblExit;
        private Label lblLogOut;
        private Label lblAuditLogs;
        private Label lblEquipmentManagement;
        private Label lblReturnRecords;
        private Label lblRentalTransactions;
        private Label lblRentalRequests;
        private Label label1;
        private Label lblDivider;
        private Label lblRole;
        private Label lblName;
        private Label lblDashboard;
        private Button button1;
        private Button button2;
        private FlowLayoutPanel flowSidebar;
        private Panel panelSidebarHighlight;
    }
}