namespace FormApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            flowLayoutPanel2 = new FlowLayoutPanel();
            lblName = new Label();
            lblPosition = new Label();
            pnlInfo = new Panel();
            lblOverdueRequests = new Label();
            lblPendingRequests = new Label();
            lblActiveRentals = new Label();
            lblrentedEquipment = new Label();
            lblavEq = new Label();
            lbleqTotal = new Label();
            lblOverdue = new Label();
            lblActiveRental = new Label();
            lblPending = new Label();
            lblRentedEq = new Label();
            lblTotalEq = new Label();
            lblAvailableEq = new Label();
            label2 = new Label();
            label1 = new Label();
            lblRecentEq = new Label();
            recentlyAddedEquipmentGrid = new DataGridView();
            lblRecentRentalReq = new Label();
            latestRentalRequestGrid = new DataGridView();
            label16 = new Label();
            lblRequest = new Label();
            lblTransactions = new Label();
            lblEquipmentManagement = new Label();
            lblReturnRecords = new Label();
            lblGenerateReport = new Label();
            lblDBbackup = new Label();
            lblViewAuditLogs = new Label();
            lblExit = new Label();
            lblLogOut = new Label();
            sidebarPanel = new FlowLayoutPanel();
            panel1 = new Panel();
            label3 = new Label();
            lblDivider = new Label();
            flowLayoutPanel2.SuspendLayout();
            pnlInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)recentlyAddedEquipmentGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)latestRentalRequestGrid).BeginInit();
            sidebarPanel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(lblName);
            flowLayoutPanel2.Controls.Add(lblPosition);
            flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel2.Location = new Point(9, 15);
            flowLayoutPanel2.Margin = new Padding(0, 6, 0, 0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Padding = new Padding(5);
            flowLayoutPanel2.Size = new Size(1386, 99);
            flowLayoutPanel2.TabIndex = 1;
            flowLayoutPanel2.Paint += flowLayoutPanel2_Paint;
            // 
            // lblName
            // 
            lblName.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(10, 5);
            lblName.Margin = new Padding(5, 0, 5, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(167, 50);
            lblName.TabIndex = 0;
            lblName.Text = "Sharmin";
            // 
            // lblPosition
            // 
            lblPosition.Location = new Point(10, 55);
            lblPosition.Margin = new Padding(5, 0, 5, 0);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(84, 32);
            lblPosition.TabIndex = 1;
            lblPosition.Text = "Admin";
            // 
            // pnlInfo
            // 
            pnlInfo.Controls.Add(lblOverdueRequests);
            pnlInfo.Controls.Add(lblPendingRequests);
            pnlInfo.Controls.Add(lblActiveRentals);
            pnlInfo.Controls.Add(lblrentedEquipment);
            pnlInfo.Controls.Add(lblavEq);
            pnlInfo.Controls.Add(lbleqTotal);
            pnlInfo.Controls.Add(lblOverdue);
            pnlInfo.Controls.Add(lblActiveRental);
            pnlInfo.Controls.Add(lblPending);
            pnlInfo.Controls.Add(lblRentedEq);
            pnlInfo.Controls.Add(lblTotalEq);
            pnlInfo.Controls.Add(lblAvailableEq);
            pnlInfo.Controls.Add(label2);
            pnlInfo.Controls.Add(label1);
            pnlInfo.Location = new Point(425, 139);
            pnlInfo.Margin = new Padding(5);
            pnlInfo.Name = "pnlInfo";
            pnlInfo.Size = new Size(928, 258);
            pnlInfo.TabIndex = 2;
            // 
            // lblOverdueRequests
            // 
            lblOverdueRequests.AutoSize = true;
            lblOverdueRequests.Location = new Point(809, 202);
            lblOverdueRequests.Margin = new Padding(5, 0, 5, 0);
            lblOverdueRequests.Name = "lblOverdueRequests";
            lblOverdueRequests.Size = new Size(29, 32);
            lblOverdueRequests.TabIndex = 13;
            lblOverdueRequests.Text = "...";
            // 
            // lblPendingRequests
            // 
            lblPendingRequests.AutoSize = true;
            lblPendingRequests.Location = new Point(809, 150);
            lblPendingRequests.Margin = new Padding(5, 0, 5, 0);
            lblPendingRequests.Name = "lblPendingRequests";
            lblPendingRequests.Size = new Size(29, 32);
            lblPendingRequests.TabIndex = 12;
            lblPendingRequests.Text = "...";
            // 
            // lblActiveRentals
            // 
            lblActiveRentals.AutoSize = true;
            lblActiveRentals.Location = new Point(809, 99);
            lblActiveRentals.Margin = new Padding(5, 0, 5, 0);
            lblActiveRentals.Name = "lblActiveRentals";
            lblActiveRentals.Size = new Size(29, 32);
            lblActiveRentals.TabIndex = 11;
            lblActiveRentals.Text = "...";
            // 
            // lblrentedEquipment
            // 
            lblrentedEquipment.AutoSize = true;
            lblrentedEquipment.Location = new Point(361, 202);
            lblrentedEquipment.Margin = new Padding(5, 0, 5, 0);
            lblrentedEquipment.Name = "lblrentedEquipment";
            lblrentedEquipment.Size = new Size(29, 32);
            lblrentedEquipment.TabIndex = 10;
            lblrentedEquipment.Text = "...";
            lblrentedEquipment.Click += label11_Click;
            // 
            // lblavEq
            // 
            lblavEq.AutoSize = true;
            lblavEq.Location = new Point(361, 150);
            lblavEq.Margin = new Padding(5, 0, 5, 0);
            lblavEq.Name = "lblavEq";
            lblavEq.Size = new Size(29, 32);
            lblavEq.TabIndex = 9;
            lblavEq.Text = "...";
            // 
            // lbleqTotal
            // 
            lbleqTotal.AutoSize = true;
            lbleqTotal.Location = new Point(361, 99);
            lbleqTotal.Margin = new Padding(5, 0, 5, 0);
            lbleqTotal.Name = "lbleqTotal";
            lbleqTotal.Size = new Size(29, 32);
            lbleqTotal.TabIndex = 8;
            lbleqTotal.Text = "...";
            lbleqTotal.Click += label9_Click;
            // 
            // lblOverdue
            // 
            lblOverdue.AutoSize = true;
            lblOverdue.Location = new Point(528, 202);
            lblOverdue.Margin = new Padding(5, 0, 5, 0);
            lblOverdue.Name = "lblOverdue";
            lblOverdue.Size = new Size(208, 32);
            lblOverdue.TabIndex = 7;
            lblOverdue.Text = "Overdue Requests";
            lblOverdue.Click += lblOverdue_Click;
            // 
            // lblActiveRental
            // 
            lblActiveRental.AutoSize = true;
            lblActiveRental.Location = new Point(528, 99);
            lblActiveRental.Margin = new Padding(5, 0, 5, 0);
            lblActiveRental.Name = "lblActiveRental";
            lblActiveRental.Size = new Size(162, 32);
            lblActiveRental.TabIndex = 6;
            lblActiveRental.Text = "Active Rentals";
            // 
            // lblPending
            // 
            lblPending.AutoSize = true;
            lblPending.Location = new Point(528, 150);
            lblPending.Margin = new Padding(5, 0, 5, 0);
            lblPending.Name = "lblPending";
            lblPending.Size = new Size(203, 32);
            lblPending.TabIndex = 5;
            lblPending.Text = "Pending Requests";
            // 
            // lblRentedEq
            // 
            lblRentedEq.AutoSize = true;
            lblRentedEq.Location = new Point(16, 202);
            lblRentedEq.Margin = new Padding(5, 0, 5, 0);
            lblRentedEq.Name = "lblRentedEq";
            lblRentedEq.Size = new Size(212, 32);
            lblRentedEq.TabIndex = 4;
            lblRentedEq.Text = "Rented Equipment";
            // 
            // lblTotalEq
            // 
            lblTotalEq.AutoSize = true;
            lblTotalEq.Location = new Point(16, 99);
            lblTotalEq.Margin = new Padding(5, 0, 5, 0);
            lblTotalEq.Name = "lblTotalEq";
            lblTotalEq.Size = new Size(173, 32);
            lblTotalEq.TabIndex = 3;
            lblTotalEq.Text = "Total Summary";
            // 
            // lblAvailableEq
            // 
            lblAvailableEq.AutoSize = true;
            lblAvailableEq.Location = new Point(16, 150);
            lblAvailableEq.Margin = new Padding(5, 0, 5, 0);
            lblAvailableEq.Name = "lblAvailableEq";
            lblAvailableEq.Size = new Size(233, 32);
            lblAvailableEq.TabIndex = 2;
            lblAvailableEq.Text = "Available Equipment";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(528, 6);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(266, 45);
            label2.TabIndex = 1;
            label2.Text = "Rental Summary";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(16, 6);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(334, 45);
            label1.TabIndex = 0;
            label1.Text = "Equipment Summary";
            // 
            // lblRecentEq
            // 
            lblRecentEq.AutoSize = true;
            lblRecentEq.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecentEq.Location = new Point(425, 431);
            lblRecentEq.Margin = new Padding(5, 0, 5, 0);
            lblRecentEq.Name = "lblRecentEq";
            lblRecentEq.Size = new Size(373, 38);
            lblRecentEq.TabIndex = 3;
            lblRecentEq.Text = "Recently Added Equipment";
            lblRecentEq.Click += lblRecentEq_Click;
            // 
            // recentlyAddedEquipmentGrid
            // 
            recentlyAddedEquipmentGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            recentlyAddedEquipmentGrid.Location = new Point(425, 473);
            recentlyAddedEquipmentGrid.Margin = new Padding(5);
            recentlyAddedEquipmentGrid.Name = "recentlyAddedEquipmentGrid";
            recentlyAddedEquipmentGrid.RowHeadersWidth = 51;
            recentlyAddedEquipmentGrid.Size = new Size(904, 141);
            recentlyAddedEquipmentGrid.TabIndex = 4;
            // 
            // lblRecentRentalReq
            // 
            lblRecentRentalReq.AutoSize = true;
            lblRecentRentalReq.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecentRentalReq.Location = new Point(425, 638);
            lblRecentRentalReq.Margin = new Padding(5, 0, 5, 0);
            lblRecentRentalReq.Name = "lblRecentRentalReq";
            lblRecentRentalReq.Size = new Size(298, 38);
            lblRecentRentalReq.TabIndex = 5;
            lblRecentRentalReq.Text = "Latest Rental Request";
            // 
            // latestRentalRequestGrid
            // 
            latestRentalRequestGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            latestRentalRequestGrid.Location = new Point(425, 679);
            latestRentalRequestGrid.Margin = new Padding(5);
            latestRentalRequestGrid.Name = "latestRentalRequestGrid";
            latestRentalRequestGrid.RowHeadersWidth = 51;
            latestRentalRequestGrid.Size = new Size(904, 144);
            latestRentalRequestGrid.TabIndex = 6;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.FromArgb(249, 115, 22);
            label16.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold);
            label16.ForeColor = Color.White;
            label16.Location = new Point(29, 12);
            label16.Margin = new Padding(5, 0, 5, 0);
            label16.Name = "label16";
            label16.Size = new Size(150, 37);
            label16.TabIndex = 14;
            label16.Text = "Dashboard";
            // 
            // lblRequest
            // 
            lblRequest.AutoSize = true;
            lblRequest.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRequest.Location = new Point(30, 78);
            lblRequest.Margin = new Padding(30, 8, 15, 20);
            lblRequest.Name = "lblRequest";
            lblRequest.Size = new Size(217, 38);
            lblRequest.TabIndex = 44;
            lblRequest.Text = "Rental Requests";
            lblRequest.Click += lblRequest_Click;
            // 
            // lblTransactions
            // 
            lblTransactions.AutoSize = true;
            lblTransactions.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTransactions.Location = new Point(30, 144);
            lblTransactions.Margin = new Padding(30, 8, 15, 20);
            lblTransactions.Name = "lblTransactions";
            lblTransactions.Size = new Size(260, 38);
            lblTransactions.TabIndex = 45;
            lblTransactions.Text = "Rental Transactions";
            lblTransactions.Click += lblTransactions_Click;
            // 
            // lblEquipmentManagement
            // 
            lblEquipmentManagement.AutoSize = true;
            lblEquipmentManagement.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEquipmentManagement.Location = new Point(30, 276);
            lblEquipmentManagement.Margin = new Padding(30, 8, 15, 20);
            lblEquipmentManagement.Name = "lblEquipmentManagement";
            lblEquipmentManagement.Size = new Size(333, 38);
            lblEquipmentManagement.TabIndex = 47;
            lblEquipmentManagement.Text = "Equipment Management";
            lblEquipmentManagement.Click += lblEquipmentManagement_Click;
            // 
            // lblReturnRecords
            // 
            lblReturnRecords.AutoSize = true;
            lblReturnRecords.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReturnRecords.Location = new Point(30, 210);
            lblReturnRecords.Margin = new Padding(30, 8, 15, 20);
            lblReturnRecords.Name = "lblReturnRecords";
            lblReturnRecords.Size = new Size(208, 38);
            lblReturnRecords.TabIndex = 46;
            lblReturnRecords.Text = "Return Records";
            lblReturnRecords.Click += lblReturnRecords_Click;
            // 
            // lblGenerateReport
            // 
            lblGenerateReport.AutoSize = true;
            lblGenerateReport.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGenerateReport.Location = new Point(30, 474);
            lblGenerateReport.Margin = new Padding(30, 8, 15, 20);
            lblGenerateReport.Name = "lblGenerateReport";
            lblGenerateReport.Size = new Size(239, 38);
            lblGenerateReport.TabIndex = 56;
            lblGenerateReport.Text = "Generate Reports";
            lblGenerateReport.Click += lblGenerateReport_Click;
            // 
            // lblDBbackup
            // 
            lblDBbackup.AutoSize = true;
            lblDBbackup.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDBbackup.Location = new Point(30, 408);
            lblDBbackup.Margin = new Padding(30, 8, 15, 20);
            lblDBbackup.Name = "lblDBbackup";
            lblDBbackup.Size = new Size(348, 38);
            lblDBbackup.TabIndex = 57;
            lblDBbackup.Text = "Perform Database Backup";
            lblDBbackup.Click += lblDBbackup_Click;
            // 
            // lblViewAuditLogs
            // 
            lblViewAuditLogs.AutoSize = true;
            lblViewAuditLogs.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblViewAuditLogs.Location = new Point(30, 342);
            lblViewAuditLogs.Margin = new Padding(30, 8, 15, 20);
            lblViewAuditLogs.Name = "lblViewAuditLogs";
            lblViewAuditLogs.Size = new Size(223, 38);
            lblViewAuditLogs.TabIndex = 48;
            lblViewAuditLogs.Text = "View Audit Logs";
            lblViewAuditLogs.Click += lblViewAuditLogs_Click;
            // 
            // lblExit
            // 
            lblExit.AutoSize = true;
            lblExit.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExit.Location = new Point(30, 606);
            lblExit.Margin = new Padding(30, 8, 15, 20);
            lblExit.Name = "lblExit";
            lblExit.Size = new Size(63, 38);
            lblExit.TabIndex = 58;
            lblExit.Text = "Exit";
            lblExit.Click += lblExit_Click;
            // 
            // lblLogOut
            // 
            lblLogOut.AutoSize = true;
            lblLogOut.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogOut.Location = new Point(30, 540);
            lblLogOut.Margin = new Padding(30, 8, 15, 20);
            lblLogOut.Name = "lblLogOut";
            lblLogOut.Size = new Size(120, 38);
            lblLogOut.TabIndex = 59;
            lblLogOut.Text = "Log Out";
            lblLogOut.Click += lblLogOut_Click;
            // 
            // sidebarPanel
            // 
            sidebarPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            sidebarPanel.Controls.Add(panel1);
            sidebarPanel.Controls.Add(lblRequest);
            sidebarPanel.Controls.Add(lblTransactions);
            sidebarPanel.Controls.Add(lblReturnRecords);
            sidebarPanel.Controls.Add(lblEquipmentManagement);
            sidebarPanel.Controls.Add(lblViewAuditLogs);
            sidebarPanel.Controls.Add(lblDBbackup);
            sidebarPanel.Controls.Add(lblGenerateReport);
            sidebarPanel.Controls.Add(lblLogOut);
            sidebarPanel.Controls.Add(lblExit);
            sidebarPanel.FlowDirection = FlowDirection.TopDown;
            sidebarPanel.Location = new Point(-7, 133);
            sidebarPanel.MinimumSize = new Size(379, 706);
            sidebarPanel.Name = "sidebarPanel";
            sidebarPanel.Size = new Size(379, 706);
            sidebarPanel.TabIndex = 60;
            sidebarPanel.WrapContents = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(249, 115, 22);
            panel1.Controls.Add(label16);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(393, 64);
            panel1.TabIndex = 63;
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(236, 236, 236);
            label3.Location = new Point(374, 130);
            label3.Name = "label3";
            label3.Size = new Size(2, 710);
            label3.TabIndex = 61;
            // 
            // lblDivider
            // 
            lblDivider.BackColor = Color.FromArgb(236, 236, 236);
            lblDivider.Location = new Point(-8, 128);
            lblDivider.Name = "lblDivider";
            lblDivider.Size = new Size(1395, 2);
            lblDivider.TabIndex = 62;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1385, 838);
            Controls.Add(lblDivider);
            Controls.Add(label3);
            Controls.Add(sidebarPanel);
            Controls.Add(latestRentalRequestGrid);
            Controls.Add(lblRecentRentalReq);
            Controls.Add(recentlyAddedEquipmentGrid);
            Controls.Add(lblRecentEq);
            Controls.Add(pnlInfo);
            Controls.Add(flowLayoutPanel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += Dashboard_Load;
            flowLayoutPanel2.ResumeLayout(false);
            pnlInfo.ResumeLayout(false);
            pnlInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)recentlyAddedEquipmentGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)latestRentalRequestGrid).EndInit();
            sidebarPanel.ResumeLayout(false);
            sidebarPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FlowLayoutPanel flowLayoutPanel2;
        private Label lblName;
        private Label lblPosition;
        private Panel pnlInfo;
        private Label lblRecentEq;
        private DataGridView recentlyAddedEquipmentGrid;
        private Label lblRecentRentalReq;
        private DataGridView latestRentalRequestGrid;
        private Label lblOverdue;
        private Label lblActiveRental;
        private Label lblPending;
        private Label lblRentedEq;
        private Label lblTotalEq;
        private Label lblAvailableEq;
        private Label label2;
        private Label label1;
        private Label lbleqTotal;
        private Label lblOverdueRequests;
        private Label lblPendingRequests;
        private Label lblActiveRentals;
        private Label lblrentedEquipment;
        private Label lblavEq;
        private Label label16;
        private Label lblRequest;
        private Label lblTransactions;
        private Label lblEquipmentManagement;
        private Label lblReturnRecords;
        private Label lblGenerateReport;
        private Label lblDBbackup;
        private Label lblViewAuditLogs;
        private Label lblExit;
        private Label lblLogOut;
        private FlowLayoutPanel sidebarPanel;
        private Label label3;
        private Label lblDivider;
        private Panel panel1;
    }
}