namespace FormApp
{
    partial class EquipmentManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EquipmentManagement));
            flowLayoutPanel2 = new FlowLayoutPanel();
            lblName = new Label();
            lblPosition = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            btnEdit = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            eqGrid = new DataGridView();
            btnRefresh = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            lblLogOut = new Label();
            lblExit = new Label();
            lblViewAuditLogs = new Label();
            lblDBbackup = new Label();
            lblGenerateReport = new Label();
            lblReturnRecords = new Label();
            lblEquipmentManagement = new Label();
            lblTransactions = new Label();
            lblRequest = new Label();
            label16 = new Label();
            lblDashboard = new Label();
            panel3 = new Panel();
            flowLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)eqGrid).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(lblName);
            flowLayoutPanel2.Controls.Add(lblPosition);
            flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel2.Location = new Point(-2, 0);
            flowLayoutPanel2.Margin = new Padding(0, 6, 0, 0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Padding = new Padding(5, 5, 5, 5);
            flowLayoutPanel2.Size = new Size(1398, 106);
            flowLayoutPanel2.TabIndex = 4;
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
            panel1.Location = new Point(-2, 99);
            panel1.Margin = new Padding(5, 5, 5, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1384, 5);
            panel1.TabIndex = 10;
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
            // btnEdit
            // 
            btnEdit.BackColor = Color.Black;
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(694, 730);
            btnEdit.Margin = new Padding(5, 5, 5, 5);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(200, 62);
            btnEdit.TabIndex = 30;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(931, 730);
            btnDelete.Margin = new Padding(5, 5, 5, 5);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(200, 62);
            btnDelete.TabIndex = 29;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Black;
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(462, 730);
            btnAdd.Margin = new Padding(5, 5, 5, 5);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(200, 62);
            btnAdd.TabIndex = 28;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // eqGrid
            // 
            eqGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            eqGrid.Location = new Point(462, 214);
            eqGrid.Margin = new Padding(5, 5, 5, 5);
            eqGrid.Name = "eqGrid";
            eqGrid.RowHeadersWidth = 51;
            eqGrid.Size = new Size(882, 506);
            eqGrid.TabIndex = 27;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(255, 128, 0);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(1191, 131);
            btnRefresh.Margin = new Padding(5, 5, 5, 5);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(153, 46);
            btnRefresh.TabIndex = 26;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(255, 128, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(1029, 131);
            btnSearch.Margin = new Padding(5, 5, 5, 5);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(153, 46);
            btnSearch.TabIndex = 25;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.ForeColor = SystemColors.ScrollBar;
            txtSearch.Location = new Point(462, 134);
            txtSearch.Margin = new Padding(5, 5, 5, 5);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(518, 39);
            txtSearch.TabIndex = 24;
            txtSearch.Text = "Equipment ID";
            // 
            // lblLogOut
            // 
            lblLogOut.AutoSize = true;
            lblLogOut.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogOut.Location = new Point(44, 709);
            lblLogOut.Margin = new Padding(5, 0, 5, 0);
            lblLogOut.Name = "lblLogOut";
            lblLogOut.Size = new Size(120, 38);
            lblLogOut.TabIndex = 70;
            lblLogOut.Text = "Log Out";
            lblLogOut.Click += lblLogOut_Click;
            // 
            // lblExit
            // 
            lblExit.AutoSize = true;
            lblExit.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExit.Location = new Point(44, 774);
            lblExit.Margin = new Padding(5, 0, 5, 0);
            lblExit.Name = "lblExit";
            lblExit.Size = new Size(63, 38);
            lblExit.TabIndex = 69;
            lblExit.Text = "Exit";
            lblExit.Click += lblExit_Click;
            // 
            // lblViewAuditLogs
            // 
            lblViewAuditLogs.AutoSize = true;
            lblViewAuditLogs.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblViewAuditLogs.Location = new Point(44, 494);
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
            lblDBbackup.Location = new Point(44, 565);
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
            lblGenerateReport.Location = new Point(44, 640);
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
            lblReturnRecords.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReturnRecords.Location = new Point(44, 347);
            lblReturnRecords.Margin = new Padding(5, 0, 5, 0);
            lblReturnRecords.Name = "lblReturnRecords";
            lblReturnRecords.Size = new Size(208, 38);
            lblReturnRecords.TabIndex = 63;
            lblReturnRecords.Text = "Return Records";
            lblReturnRecords.Click += lblReturnRecords_Click;
            // 
            // lblEquipmentManagement
            // 
            lblEquipmentManagement.AutoSize = true;
            lblEquipmentManagement.BackColor = Color.FromArgb(255, 128, 0);
            lblEquipmentManagement.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEquipmentManagement.ForeColor = Color.White;
            lblEquipmentManagement.Location = new Point(44, 419);
            lblEquipmentManagement.Margin = new Padding(5, 0, 5, 0);
            lblEquipmentManagement.Name = "lblEquipmentManagement";
            lblEquipmentManagement.Size = new Size(333, 38);
            lblEquipmentManagement.TabIndex = 64;
            lblEquipmentManagement.Text = "Equipment Management";
            // 
            // lblTransactions
            // 
            lblTransactions.AutoSize = true;
            lblTransactions.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTransactions.Location = new Point(44, 277);
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
            lblRequest.Location = new Point(44, 206);
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
            label16.Location = new Point(44, 133);
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
            lblDashboard.Location = new Point(-2, 419);
            lblDashboard.Margin = new Padding(5, 0, 5, 0);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new Size(393, 64);
            lblDashboard.TabIndex = 66;
            lblDashboard.Text = "Dashboard";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gainsboro;
            panel3.Location = new Point(401, 110);
            panel3.Margin = new Padding(5, 5, 5, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(5, 728);
            panel3.TabIndex = 71;
            // 
            // EquipmentManagement
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1384, 838);
            Controls.Add(panel3);
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
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(eqGrid);
            Controls.Add(btnRefresh);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 5, 5, 5);
            Name = "EquipmentManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EquipmentManagement";
            Load += EquipmentManagement_Load;
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)eqGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel2;
        private Label lblName;
        private Label lblPosition;
        private Panel panel1;
        private Panel panel2;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnAdd;
        private DataGridView eqGrid;
        private Button btnRefresh;
        private Button btnSearch;
        private TextBox txtSearch;
        private Label lblLogOut;
        private Label lblExit;
        private Label lblViewAuditLogs;
        private Label lblDBbackup;
        private Label lblGenerateReport;
        private Label lblReturnRecords;
        private Label lblEquipmentManagement;
        private Label lblTransactions;
        private Label lblRequest;
        private Label label16;
        private Label lblDashboard;
        private Panel panel3;
    }
}