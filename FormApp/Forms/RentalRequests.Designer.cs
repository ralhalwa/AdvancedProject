namespace FormApp
{
    partial class RentalRequests
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RentalRequests));
            flowLayoutPanel2 = new FlowLayoutPanel();
            lblName = new Label();
            lblPosition = new Label();
            lblDivider = new Label();
            label16 = new Label();
            lblRequest = new Label();
            lblTransactions = new Label();
            requestId = new TextBox();
            btnSearch = new Button();
            RentalRequestGrid = new DataGridView();
            btnAccept = new Button();
            btnReject = new Button();
            lblLogOut = new Label();
            lblViewAuditLogs = new Label();
            lblDBbackup = new Label();
            lblGenerateReport = new Label();
            lblReturnRecords = new Label();
            lblEquipmentManagement = new Label();
            lblExit = new Label();
            btnRefresh = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)RentalRequestGrid).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(lblName);
            flowLayoutPanel2.Controls.Add(lblPosition);
            flowLayoutPanel2.Controls.Add(lblDivider);
            flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel2.Location = new Point(6, 9);
            flowLayoutPanel2.Margin = new Padding(0, 4, 0, 0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Padding = new Padding(3);
            flowLayoutPanel2.Size = new Size(851, 65);
            flowLayoutPanel2.TabIndex = 2;
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
            lblPosition.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblPosition.ForeColor = Color.FromArgb(142, 142, 147);
            lblPosition.Location = new Point(6, 34);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(39, 20);
            lblPosition.TabIndex = 1;
            lblPosition.Text = "Role";
            // 
            // lblDivider
            // 
            lblDivider.BackColor = Color.FromArgb(236, 236, 236);
            lblDivider.Location = new Point(5, 54);
            lblDivider.Margin = new Padding(2, 0, 2, 0);
            lblDivider.Name = "lblDivider";
            lblDivider.Size = new Size(858, 1);
            lblDivider.TabIndex = 63;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.White;
            label16.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold);
            label16.ForeColor = Color.Black;
            label16.Location = new Point(18, 9);
            label16.Margin = new Padding(18, 9, 9, 12);
            label16.Name = "label16";
            label16.Size = new Size(93, 23);
            label16.TabIndex = 14;
            label16.Text = "Dashboard";
            label16.Click += label16_Click;
            // 
            // lblRequest
            // 
            lblRequest.AutoSize = true;
            lblRequest.BackColor = Color.FromArgb(249, 115, 22);
            lblRequest.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRequest.ForeColor = Color.White;
            lblRequest.Location = new Point(20, 9);
            lblRequest.Margin = new Padding(18, 9, 9, 12);
            lblRequest.Name = "lblRequest";
            lblRequest.Size = new Size(133, 23);
            lblRequest.TabIndex = 61;
            lblRequest.Text = "Rental Requests";
            // 
            // lblTransactions
            // 
            lblTransactions.AutoSize = true;
            lblTransactions.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTransactions.Location = new Point(18, 93);
            lblTransactions.Margin = new Padding(18, 5, 9, 12);
            lblTransactions.Name = "lblTransactions";
            lblTransactions.Size = new Size(158, 23);
            lblTransactions.TabIndex = 62;
            lblTransactions.Text = "Rental Transactions";
            lblTransactions.Click += lblTransactions_Click;
            // 
            // requestId
            // 
            requestId.ForeColor = SystemColors.ScrollBar;
            requestId.Location = new Point(235, 92);
            requestId.Name = "requestId";
            requestId.Size = new Size(371, 27);
            requestId.TabIndex = 11;
            requestId.Text = "Rental Request ID";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(249, 115, 22);
            btnSearch.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(612, 87);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(113, 35);
            btnSearch.TabIndex = 12;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // RentalRequestGrid
            // 
            RentalRequestGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            RentalRequestGrid.Location = new Point(235, 129);
            RentalRequestGrid.Name = "RentalRequestGrid";
            RentalRequestGrid.RowHeadersWidth = 51;
            RentalRequestGrid.Size = new Size(605, 325);
            RentalRequestGrid.TabIndex = 14;
            RentalRequestGrid.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnAccept
            // 
            btnAccept.BackColor = Color.LightGreen;
            btnAccept.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnAccept.ForeColor = Color.White;
            btnAccept.Location = new Point(235, 473);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(123, 39);
            btnAccept.TabIndex = 15;
            btnAccept.Text = "Accept";
            btnAccept.UseVisualStyleBackColor = false;
            btnAccept.Click += btnAccept_Click;
            // 
            // btnReject
            // 
            btnReject.BackColor = Color.Red;
            btnReject.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnReject.ForeColor = Color.White;
            btnReject.Location = new Point(410, 473);
            btnReject.Name = "btnReject";
            btnReject.Size = new Size(123, 39);
            btnReject.TabIndex = 16;
            btnReject.Text = "Reject";
            btnReject.UseVisualStyleBackColor = false;
            btnReject.Click += btnReject_Click;
            // 
            // lblLogOut
            // 
            lblLogOut.AutoSize = true;
            lblLogOut.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogOut.Location = new Point(18, 333);
            lblLogOut.Margin = new Padding(18, 5, 9, 12);
            lblLogOut.Name = "lblLogOut";
            lblLogOut.Size = new Size(72, 23);
            lblLogOut.TabIndex = 69;
            lblLogOut.Text = "Log Out";
            lblLogOut.Click += lblLogOut_Click;
            // 
            // lblViewAuditLogs
            // 
            lblViewAuditLogs.AutoSize = true;
            lblViewAuditLogs.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblViewAuditLogs.Location = new Point(18, 213);
            lblViewAuditLogs.Margin = new Padding(18, 5, 9, 12);
            lblViewAuditLogs.Name = "lblViewAuditLogs";
            lblViewAuditLogs.Size = new Size(133, 23);
            lblViewAuditLogs.TabIndex = 65;
            lblViewAuditLogs.Text = "View Audit Logs";
            lblViewAuditLogs.Click += lblViewAuditLogs_Click;
            // 
            // lblDBbackup
            // 
            lblDBbackup.AutoSize = true;
            lblDBbackup.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDBbackup.Location = new Point(18, 253);
            lblDBbackup.Margin = new Padding(18, 5, 9, 12);
            lblDBbackup.Name = "lblDBbackup";
            lblDBbackup.Size = new Size(208, 23);
            lblDBbackup.TabIndex = 68;
            lblDBbackup.Text = "Perform Database Backup";
            lblDBbackup.Click += lblDBbackup_Click;
            // 
            // lblGenerateReport
            // 
            lblGenerateReport.AutoSize = true;
            lblGenerateReport.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGenerateReport.Location = new Point(18, 293);
            lblGenerateReport.Margin = new Padding(18, 5, 9, 12);
            lblGenerateReport.Name = "lblGenerateReport";
            lblGenerateReport.Size = new Size(144, 23);
            lblGenerateReport.TabIndex = 67;
            lblGenerateReport.Text = "Generate Reports";
            lblGenerateReport.Click += lblGenerateReport_Click;
            // 
            // lblReturnRecords
            // 
            lblReturnRecords.AutoSize = true;
            lblReturnRecords.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReturnRecords.Location = new Point(18, 133);
            lblReturnRecords.Margin = new Padding(18, 5, 9, 12);
            lblReturnRecords.Name = "lblReturnRecords";
            lblReturnRecords.Size = new Size(128, 23);
            lblReturnRecords.TabIndex = 63;
            lblReturnRecords.Text = "Return Records";
            lblReturnRecords.Click += lblReturnRecords_Click;
            // 
            // lblEquipmentManagement
            // 
            lblEquipmentManagement.AutoSize = true;
            lblEquipmentManagement.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEquipmentManagement.Location = new Point(18, 173);
            lblEquipmentManagement.Margin = new Padding(18, 5, 9, 12);
            lblEquipmentManagement.Name = "lblEquipmentManagement";
            lblEquipmentManagement.Size = new Size(201, 23);
            lblEquipmentManagement.TabIndex = 64;
            lblEquipmentManagement.Text = "Equipment Management";
            lblEquipmentManagement.Click += lblEquipmentManagement_Click;
            // 
            // lblExit
            // 
            lblExit.AutoSize = true;
            lblExit.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExit.Location = new Point(18, 373);
            lblExit.Margin = new Padding(18, 5, 9, 12);
            lblExit.Name = "lblExit";
            lblExit.Size = new Size(38, 23);
            lblExit.TabIndex = 70;
            lblExit.Text = "Exit";
            lblExit.Click += lblExit_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(249, 115, 22);
            btnRefresh.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(727, 87);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(113, 35);
            btnRefresh.TabIndex = 13;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.Controls.Add(label16);
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(lblTransactions);
            flowLayoutPanel1.Controls.Add(lblReturnRecords);
            flowLayoutPanel1.Controls.Add(lblEquipmentManagement);
            flowLayoutPanel1.Controls.Add(lblViewAuditLogs);
            flowLayoutPanel1.Controls.Add(lblDBbackup);
            flowLayoutPanel1.Controls.Add(lblGenerateReport);
            flowLayoutPanel1.Controls.Add(lblLogOut);
            flowLayoutPanel1.Controls.Add(lblExit);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(-10, 83);
            flowLayoutPanel1.Margin = new Padding(2);
            flowLayoutPanel1.MinimumSize = new Size(233, 441);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(240, 441);
            flowLayoutPanel1.TabIndex = 39;
            flowLayoutPanel1.WrapContents = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(249, 115, 22);
            panel1.Controls.Add(lblRequest);
            panel1.Location = new Point(2, 46);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(236, 40);
            panel1.TabIndex = 72;
            // 
            // RentalRequests
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(852, 524);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(btnReject);
            Controls.Add(btnAccept);
            Controls.Add(RentalRequestGrid);
            Controls.Add(btnRefresh);
            Controls.Add(btnSearch);
            Controls.Add(requestId);
            Controls.Add(flowLayoutPanel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "RentalRequests";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RentalRequest";
            Load += RentalRequest_Load;
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)RentalRequestGrid).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel2;
        private Label lblName;
        private Label lblPosition;
        private TextBox requestId;
        private Button btnSearch;
        private DataGridView RentalRequestGrid;
        private Button btnAccept;
        private Button btnReject;
        private Label lblLogOut;
        private Label lblViewAuditLogs;
        private Label lblDBbackup;
        private Label lblGenerateReport;
        private Label lblReturnRecords;
        private Label lblEquipmentManagement;
        private Label lblTransactions;
        private Label lblRequest;
        private Label label16;
        private Label lblExit;
        private Button btnRefresh;
        private Button btnFiler;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Label lblDivider;
    }
}