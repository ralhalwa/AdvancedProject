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
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            lblDashboard = new Label();
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
            flowLayoutPanel2.SuspendLayout();
            pnlInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)recentlyAddedEquipmentGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)latestRentalRequestGrid).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(lblName);
            flowLayoutPanel2.Controls.Add(lblPosition);
            flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel2.Location = new Point(-2, 1);
            flowLayoutPanel2.Margin = new Padding(0, 4, 0, 0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Padding = new Padding(3);
            flowLayoutPanel2.Size = new Size(853, 62);
            flowLayoutPanel2.TabIndex = 1;
            flowLayoutPanel2.Paint += flowLayoutPanel2_Paint;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(6, 3);
            lblName.Name = "lblName";
            lblName.Size = new Size(104, 31);
            lblName.TabIndex = 0;
            lblName.Text = "Sharmin";
            // 
            // lblPosition
            // 
            lblPosition.AutoSize = true;
            lblPosition.Location = new Point(6, 34);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(53, 20);
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
            pnlInfo.Location = new Point(260, 76);
            pnlInfo.Name = "pnlInfo";
            pnlInfo.Size = new Size(571, 161);
            pnlInfo.TabIndex = 2;
            // 
            // lblOverdueRequests
            // 
            lblOverdueRequests.AutoSize = true;
            lblOverdueRequests.Location = new Point(498, 126);
            lblOverdueRequests.Name = "lblOverdueRequests";
            lblOverdueRequests.Size = new Size(18, 20);
            lblOverdueRequests.TabIndex = 13;
            lblOverdueRequests.Text = "...";
            // 
            // lblPendingRequests
            // 
            lblPendingRequests.AutoSize = true;
            lblPendingRequests.Location = new Point(498, 94);
            lblPendingRequests.Name = "lblPendingRequests";
            lblPendingRequests.Size = new Size(18, 20);
            lblPendingRequests.TabIndex = 12;
            lblPendingRequests.Text = "...";
            // 
            // lblActiveRentals
            // 
            lblActiveRentals.AutoSize = true;
            lblActiveRentals.Location = new Point(498, 62);
            lblActiveRentals.Name = "lblActiveRentals";
            lblActiveRentals.Size = new Size(18, 20);
            lblActiveRentals.TabIndex = 11;
            lblActiveRentals.Text = "...";
            // 
            // lblrentedEquipment
            // 
            lblrentedEquipment.AutoSize = true;
            lblrentedEquipment.Location = new Point(222, 126);
            lblrentedEquipment.Name = "lblrentedEquipment";
            lblrentedEquipment.Size = new Size(18, 20);
            lblrentedEquipment.TabIndex = 10;
            lblrentedEquipment.Text = "...";
            lblrentedEquipment.Click += label11_Click;
            // 
            // lblavEq
            // 
            lblavEq.AutoSize = true;
            lblavEq.Location = new Point(222, 94);
            lblavEq.Name = "lblavEq";
            lblavEq.Size = new Size(18, 20);
            lblavEq.TabIndex = 9;
            lblavEq.Text = "...";
            // 
            // lbleqTotal
            // 
            lbleqTotal.AutoSize = true;
            lbleqTotal.Location = new Point(222, 62);
            lbleqTotal.Name = "lbleqTotal";
            lbleqTotal.Size = new Size(18, 20);
            lbleqTotal.TabIndex = 8;
            lbleqTotal.Text = "...";
            lbleqTotal.Click += label9_Click;
            // 
            // lblOverdue
            // 
            lblOverdue.AutoSize = true;
            lblOverdue.Location = new Point(325, 126);
            lblOverdue.Name = "lblOverdue";
            lblOverdue.Size = new Size(128, 20);
            lblOverdue.TabIndex = 7;
            lblOverdue.Text = "Overdue Requests";
            lblOverdue.Click += lblOverdue_Click;
            // 
            // lblActiveRental
            // 
            lblActiveRental.AutoSize = true;
            lblActiveRental.Location = new Point(325, 62);
            lblActiveRental.Name = "lblActiveRental";
            lblActiveRental.Size = new Size(102, 20);
            lblActiveRental.TabIndex = 6;
            lblActiveRental.Text = "Active Rentals";
            // 
            // lblPending
            // 
            lblPending.AutoSize = true;
            lblPending.Location = new Point(325, 94);
            lblPending.Name = "lblPending";
            lblPending.Size = new Size(125, 20);
            lblPending.TabIndex = 5;
            lblPending.Text = "Pending Requests";
            // 
            // lblRentedEq
            // 
            lblRentedEq.AutoSize = true;
            lblRentedEq.Location = new Point(10, 126);
            lblRentedEq.Name = "lblRentedEq";
            lblRentedEq.Size = new Size(132, 20);
            lblRentedEq.TabIndex = 4;
            lblRentedEq.Text = "Rented Equipment";
            // 
            // lblTotalEq
            // 
            lblTotalEq.AutoSize = true;
            lblTotalEq.Location = new Point(10, 62);
            lblTotalEq.Name = "lblTotalEq";
            lblTotalEq.Size = new Size(108, 20);
            lblTotalEq.TabIndex = 3;
            lblTotalEq.Text = "Total Summary";
            // 
            // lblAvailableEq
            // 
            lblAvailableEq.AutoSize = true;
            lblAvailableEq.Location = new Point(10, 94);
            lblAvailableEq.Name = "lblAvailableEq";
            lblAvailableEq.Size = new Size(147, 20);
            lblAvailableEq.TabIndex = 2;
            lblAvailableEq.Text = "Available Equipment";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(325, 4);
            label2.Name = "label2";
            label2.Size = new Size(169, 28);
            label2.TabIndex = 1;
            label2.Text = "Rental Summary";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(10, 4);
            label1.Name = "label1";
            label1.Size = new Size(210, 28);
            label1.TabIndex = 0;
            label1.Text = "Equipment Summary";
            // 
            // lblRecentEq
            // 
            lblRecentEq.AutoSize = true;
            lblRecentEq.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecentEq.Location = new Point(260, 259);
            lblRecentEq.Name = "lblRecentEq";
            lblRecentEq.Size = new Size(230, 23);
            lblRecentEq.TabIndex = 3;
            lblRecentEq.Text = "Recently Added Equipment";
            lblRecentEq.Click += lblRecentEq_Click;
            // 
            // recentlyAddedEquipmentGrid
            // 
            recentlyAddedEquipmentGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            recentlyAddedEquipmentGrid.Location = new Point(260, 285);
            recentlyAddedEquipmentGrid.Name = "recentlyAddedEquipmentGrid";
            recentlyAddedEquipmentGrid.RowHeadersWidth = 51;
            recentlyAddedEquipmentGrid.Size = new Size(556, 88);
            recentlyAddedEquipmentGrid.TabIndex = 4;
            // 
            // lblRecentRentalReq
            // 
            lblRecentRentalReq.AutoSize = true;
            lblRecentRentalReq.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecentRentalReq.Location = new Point(260, 388);
            lblRecentRentalReq.Name = "lblRecentRentalReq";
            lblRecentRentalReq.Size = new Size(183, 23);
            lblRecentRentalReq.TabIndex = 5;
            lblRecentRentalReq.Text = "Latest Rental Request";
            // 
            // latestRentalRequestGrid
            // 
            latestRentalRequestGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            latestRentalRequestGrid.Location = new Point(260, 414);
            latestRentalRequestGrid.Name = "latestRentalRequestGrid";
            latestRentalRequestGrid.RowHeadersWidth = 51;
            latestRentalRequestGrid.Size = new Size(556, 90);
            latestRentalRequestGrid.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(-2, 60);
            panel1.Name = "panel1";
            panel1.Size = new Size(849, 3);
            panel1.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.Location = new Point(217, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(3, 383);
            panel2.TabIndex = 8;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gainsboro;
            panel3.Location = new Point(240, 70);
            panel3.Name = "panel3";
            panel3.Size = new Size(3, 455);
            panel3.TabIndex = 8;
            panel3.Paint += panel3_Paint;
            // 
            // lblDashboard
            // 
            lblDashboard.BackColor = Color.FromArgb(255, 128, 0);
            lblDashboard.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold);
            lblDashboard.ForeColor = Color.FromArgb(255, 128, 0);
            lblDashboard.Location = new Point(-2, 72);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new Size(242, 40);
            lblDashboard.TabIndex = 55;
            lblDashboard.Text = "Dashboard";
            lblDashboard.Click += label15_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.FromArgb(255, 128, 0);
            label16.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold);
            label16.ForeColor = Color.White;
            label16.Location = new Point(26, 80);
            label16.Name = "label16";
            label16.Size = new Size(93, 23);
            label16.TabIndex = 14;
            label16.Text = "Dashboard";
            // 
            // lblRequest
            // 
            lblRequest.AutoSize = true;
            lblRequest.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRequest.Location = new Point(26, 126);
            lblRequest.Name = "lblRequest";
            lblRequest.Size = new Size(133, 23);
            lblRequest.TabIndex = 44;
            lblRequest.Text = "Rental Requests";
            lblRequest.Click += lblRequest_Click;
            // 
            // lblTransactions
            // 
            lblTransactions.AutoSize = true;
            lblTransactions.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTransactions.Location = new Point(26, 170);
            lblTransactions.Name = "lblTransactions";
            lblTransactions.Size = new Size(158, 23);
            lblTransactions.TabIndex = 45;
            lblTransactions.Text = "Rental Transactions";
            lblTransactions.Click += lblTransactions_Click;
            // 
            // lblEquipmentManagement
            // 
            lblEquipmentManagement.AutoSize = true;
            lblEquipmentManagement.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEquipmentManagement.Location = new Point(26, 259);
            lblEquipmentManagement.Name = "lblEquipmentManagement";
            lblEquipmentManagement.Size = new Size(201, 23);
            lblEquipmentManagement.TabIndex = 47;
            lblEquipmentManagement.Text = "Equipment Management";
            lblEquipmentManagement.Click += lblEquipmentManagement_Click;
            // 
            // lblReturnRecords
            // 
            lblReturnRecords.AutoSize = true;
            lblReturnRecords.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReturnRecords.Location = new Point(26, 214);
            lblReturnRecords.Name = "lblReturnRecords";
            lblReturnRecords.Size = new Size(128, 23);
            lblReturnRecords.TabIndex = 46;
            lblReturnRecords.Text = "Return Records";
            lblReturnRecords.Click += lblReturnRecords_Click;
            // 
            // lblGenerateReport
            // 
            lblGenerateReport.AutoSize = true;
            lblGenerateReport.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGenerateReport.Location = new Point(26, 397);
            lblGenerateReport.Name = "lblGenerateReport";
            lblGenerateReport.Size = new Size(144, 23);
            lblGenerateReport.TabIndex = 56;
            lblGenerateReport.Text = "Generate Reports";
            // 
            // lblDBbackup
            // 
            lblDBbackup.AutoSize = true;
            lblDBbackup.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDBbackup.Location = new Point(26, 350);
            lblDBbackup.Name = "lblDBbackup";
            lblDBbackup.Size = new Size(208, 23);
            lblDBbackup.TabIndex = 57;
            lblDBbackup.Text = "Perform Database Backup";
            // 
            // lblViewAuditLogs
            // 
            lblViewAuditLogs.AutoSize = true;
            lblViewAuditLogs.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblViewAuditLogs.Location = new Point(26, 306);
            lblViewAuditLogs.Name = "lblViewAuditLogs";
            lblViewAuditLogs.Size = new Size(133, 23);
            lblViewAuditLogs.TabIndex = 48;
            lblViewAuditLogs.Text = "View Audit Logs";
            // 
            // lblExit
            // 
            lblExit.AutoSize = true;
            lblExit.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExit.Location = new Point(26, 481);
            lblExit.Name = "lblExit";
            lblExit.Size = new Size(38, 23);
            lblExit.TabIndex = 58;
            lblExit.Text = "Exit";
            lblExit.Click += lblExit_Click;
            // 
            // lblLogOut
            // 
            lblLogOut.AutoSize = true;
            lblLogOut.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogOut.Location = new Point(26, 440);
            lblLogOut.Name = "lblLogOut";
            lblLogOut.Size = new Size(72, 23);
            lblLogOut.TabIndex = 59;
            lblLogOut.Text = "Log Out";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(852, 524);
            Controls.Add(lblLogOut);
            Controls.Add(lblExit);
            Controls.Add(lblViewAuditLogs);
            Controls.Add(lblDBbackup);
            Controls.Add(lblGenerateReport);
            Controls.Add(lblReturnRecords);
            Controls.Add(lblEquipmentManagement);
            Controls.Add(lblTransactions);
            Controls.Add(lblRequest);
            Controls.Add(label16);
            Controls.Add(lblDashboard);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(latestRentalRequestGrid);
            Controls.Add(lblRecentRentalReq);
            Controls.Add(recentlyAddedEquipmentGrid);
            Controls.Add(lblRecentEq);
            Controls.Add(pnlInfo);
            Controls.Add(flowLayoutPanel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += Dashboard_Load;
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            pnlInfo.ResumeLayout(false);
            pnlInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)recentlyAddedEquipmentGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)latestRentalRequestGrid).EndInit();
            panel1.ResumeLayout(false);
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
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label lbleqTotal;
        private Label lblOverdueRequests;
        private Label lblPendingRequests;
        private Label lblActiveRentals;
        private Label lblrentedEquipment;
        private Label lblavEq;
        private Label lblDashboard;
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
    }
}