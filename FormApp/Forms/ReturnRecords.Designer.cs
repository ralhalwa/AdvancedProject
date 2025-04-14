namespace FormApp
{
    partial class ReturnRecords
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnRecords));
            flowLayoutPanel2 = new FlowLayoutPanel();
            lblName = new Label();
            lblPosition = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            txtReturnRecordId = new TextBox();
            btnSearch = new Button();
            ReturnRecordGrid = new DataGridView();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnCreate = new Button();
            panel3 = new Panel();
            lblLogOut = new Label();
            lblViewAuditLogs = new Label();
            lblDBbackup = new Label();
            lblGenerateReport = new Label();
            lblReturnRecords = new Label();
            lblEquipmentManagement = new Label();
            lblTransactions = new Label();
            lblRequest = new Label();
            label16 = new Label();
            lblDashboard = new Label();
            btnRefresh = new Button();
            lblExit = new Label();
            flowLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ReturnRecordGrid).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(lblName);
            flowLayoutPanel2.Controls.Add(lblPosition);
            flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel2.Location = new Point(-5, 0);
            flowLayoutPanel2.Margin = new Padding(0, 6, 0, 0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Padding = new Padding(5, 5, 5, 5);
            flowLayoutPanel2.Size = new Size(1394, 106);
            flowLayoutPanel2.TabIndex = 3;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
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
            lblPosition.AutoSize = true;
            lblPosition.Location = new Point(10, 55);
            lblPosition.Margin = new Padding(5, 0, 5, 0);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(84, 32);
            lblPosition.TabIndex = 1;
            lblPosition.Text = "Admin";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(5, 110);
            panel1.Margin = new Padding(5, 5, 5, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1375, 5);
            panel1.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.Location = new Point(353, 3);
            panel2.Margin = new Padding(5, 5, 5, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(5, 613);
            panel2.TabIndex = 8;
            // 
            // txtReturnRecordId
            // 
            txtReturnRecordId.ForeColor = SystemColors.ScrollBar;
            txtReturnRecordId.Location = new Point(444, 138);
            txtReturnRecordId.Margin = new Padding(5, 5, 5, 5);
            txtReturnRecordId.Name = "txtReturnRecordId";
            txtReturnRecordId.Size = new Size(493, 39);
            txtReturnRecordId.TabIndex = 18;
            txtReturnRecordId.Text = "Rental Record ID";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(255, 128, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(970, 133);
            btnSearch.Margin = new Padding(5, 5, 5, 5);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(184, 56);
            btnSearch.TabIndex = 19;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // ReturnRecordGrid
            // 
            ReturnRecordGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ReturnRecordGrid.Location = new Point(444, 211);
            ReturnRecordGrid.Margin = new Padding(5, 5, 5, 5);
            ReturnRecordGrid.Name = "ReturnRecordGrid";
            ReturnRecordGrid.RowHeadersWidth = 51;
            ReturnRecordGrid.Size = new Size(907, 488);
            ReturnRecordGrid.TabIndex = 21;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Black;
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(696, 731);
            btnUpdate.Margin = new Padding(5, 5, 5, 5);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(200, 62);
            btnUpdate.TabIndex = 26;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(942, 731);
            btnDelete.Margin = new Padding(5, 5, 5, 5);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(200, 62);
            btnDelete.TabIndex = 25;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.Black;
            btnCreate.ForeColor = Color.White;
            btnCreate.Location = new Point(444, 731);
            btnCreate.Margin = new Padding(5, 5, 5, 5);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(200, 62);
            btnCreate.TabIndex = 24;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gainsboro;
            panel3.Location = new Point(398, 125);
            panel3.Margin = new Padding(5, 5, 5, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(5, 730);
            panel3.TabIndex = 27;
            // 
            // lblLogOut
            // 
            lblLogOut.AutoSize = true;
            lblLogOut.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogOut.Location = new Point(50, 709);
            lblLogOut.Margin = new Padding(5, 0, 5, 0);
            lblLogOut.Name = "lblLogOut";
            lblLogOut.Size = new Size(120, 38);
            lblLogOut.TabIndex = 69;
            lblLogOut.Text = "Log Out";
            lblLogOut.Click += lblLogOut_Click;
            // 
            // lblViewAuditLogs
            // 
            lblViewAuditLogs.AutoSize = true;
            lblViewAuditLogs.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblViewAuditLogs.Location = new Point(50, 494);
            lblViewAuditLogs.Margin = new Padding(5, 0, 5, 0);
            lblViewAuditLogs.Name = "lblViewAuditLogs";
            lblViewAuditLogs.Size = new Size(223, 38);
            lblViewAuditLogs.TabIndex = 65;
            lblViewAuditLogs.Text = "View Audit Logs";
            lblViewAuditLogs.Click += lblViewAuditLogs_Click;
            // 
            // lblDBbackup
            // 
            lblDBbackup.AutoSize = true;
            lblDBbackup.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDBbackup.Location = new Point(50, 565);
            lblDBbackup.Margin = new Padding(5, 0, 5, 0);
            lblDBbackup.Name = "lblDBbackup";
            lblDBbackup.Size = new Size(348, 38);
            lblDBbackup.TabIndex = 68;
            lblDBbackup.Text = "Perform Database Backup";
            lblDBbackup.Click += lblDBbackup_Click;
            // 
            // lblGenerateReport
            // 
            lblGenerateReport.AutoSize = true;
            lblGenerateReport.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGenerateReport.Location = new Point(50, 640);
            lblGenerateReport.Margin = new Padding(5, 0, 5, 0);
            lblGenerateReport.Name = "lblGenerateReport";
            lblGenerateReport.Size = new Size(239, 38);
            lblGenerateReport.TabIndex = 67;
            lblGenerateReport.Text = "Generate Reports";
            lblGenerateReport.Click += lblGenerateReport_Click;
            // 
            // lblReturnRecords
            // 
            lblReturnRecords.AutoSize = true;
            lblReturnRecords.BackColor = Color.FromArgb(255, 128, 0);
            lblReturnRecords.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReturnRecords.ForeColor = Color.White;
            lblReturnRecords.Location = new Point(50, 347);
            lblReturnRecords.Margin = new Padding(5, 0, 5, 0);
            lblReturnRecords.Name = "lblReturnRecords";
            lblReturnRecords.Size = new Size(208, 38);
            lblReturnRecords.TabIndex = 63;
            lblReturnRecords.Text = "Return Records";
            // 
            // lblEquipmentManagement
            // 
            lblEquipmentManagement.AutoSize = true;
            lblEquipmentManagement.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEquipmentManagement.Location = new Point(50, 419);
            lblEquipmentManagement.Margin = new Padding(5, 0, 5, 0);
            lblEquipmentManagement.Name = "lblEquipmentManagement";
            lblEquipmentManagement.Size = new Size(333, 38);
            lblEquipmentManagement.TabIndex = 64;
            lblEquipmentManagement.Text = "Equipment Management";
            lblEquipmentManagement.Click += lblEquipmentManagement_Click;
            // 
            // lblTransactions
            // 
            lblTransactions.AutoSize = true;
            lblTransactions.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTransactions.Location = new Point(50, 277);
            lblTransactions.Margin = new Padding(5, 0, 5, 0);
            lblTransactions.Name = "lblTransactions";
            lblTransactions.Size = new Size(260, 38);
            lblTransactions.TabIndex = 62;
            lblTransactions.Text = "Rental Transactions";
            lblTransactions.Click += lblTransactions_Click;
            // 
            // lblRequest
            // 
            lblRequest.AutoSize = true;
            lblRequest.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRequest.Location = new Point(50, 206);
            lblRequest.Margin = new Padding(5, 0, 5, 0);
            lblRequest.Name = "lblRequest";
            lblRequest.Size = new Size(217, 38);
            lblRequest.TabIndex = 61;
            lblRequest.Text = "Rental Requests";
            lblRequest.Click += lblRequest_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.White;
            label16.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold);
            label16.ForeColor = Color.Black;
            label16.Location = new Point(50, 133);
            label16.Margin = new Padding(5, 0, 5, 0);
            label16.Name = "label16";
            label16.Size = new Size(150, 37);
            label16.TabIndex = 60;
            label16.Text = "Dashboard";
            label16.Click += label16_Click;
            // 
            // lblDashboard
            // 
            lblDashboard.BackColor = Color.FromArgb(255, 128, 0);
            lblDashboard.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold);
            lblDashboard.ForeColor = Color.FromArgb(255, 128, 0);
            lblDashboard.Location = new Point(5, 347);
            lblDashboard.Margin = new Padding(5, 0, 5, 0);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new Size(393, 64);
            lblDashboard.TabIndex = 66;
            lblDashboard.Text = "Dashboard";
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(255, 128, 0);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(1164, 131);
            btnRefresh.Margin = new Padding(5, 5, 5, 5);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(187, 56);
            btnRefresh.TabIndex = 70;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // lblExit
            // 
            lblExit.AutoSize = true;
            lblExit.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExit.Location = new Point(50, 787);
            lblExit.Margin = new Padding(5, 0, 5, 0);
            lblExit.Name = "lblExit";
            lblExit.Size = new Size(63, 38);
            lblExit.TabIndex = 71;
            lblExit.Text = "Exit";
            lblExit.Click += lblExit_Click;
            // 
            // ReturnRecords
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1384, 838);
            Controls.Add(lblExit);
            Controls.Add(btnRefresh);
            Controls.Add(lblLogOut);
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
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnCreate);
            Controls.Add(ReturnRecordGrid);
            Controls.Add(btnSearch);
            Controls.Add(txtReturnRecordId);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 5, 5, 5);
            Name = "ReturnRecords";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ReturnRecords";
            Load += ReturnRecords_Load_1;
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ReturnRecordGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel2;
        private Label lblName;
        private Label lblPosition;
        private Panel panel1;
        private Panel panel2;
        private TextBox txtReturnRecordId;
        private Button btnSearch;
        private DataGridView ReturnRecordGrid;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnCreate;
        private Panel panel3;
        private Label lblLogOut;
        private Label lblViewAuditLogs;
        private Label lblDBbackup;
        private Label lblGenerateReport;
        private Label lblReturnRecords;
        private Label lblEquipmentManagement;
        private Label lblTransactions;
        private Label lblRequest;
        private Label label16;
        private Label lblDashboard;
        private Button btnRefresh;
        private Label lblExit;
    }
}