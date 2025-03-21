namespace FormApp
{
    partial class RentalTransactions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RentalTransactions));
            flowLayoutPanel2 = new FlowLayoutPanel();
            lblName = new Label();
            lblPosition = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            btnReject = new Button();
            btnCreate = new Button();
            dataGridView1 = new DataGridView();
            btnFilter = new Button();
            btnSearch = new Button();
            textBox1 = new TextBox();
            btnAccept = new Button();
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
            label1 = new Label();
            flowLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(lblName);
            flowLayoutPanel2.Controls.Add(lblPosition);
            flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel2.Location = new Point(0, 1);
            flowLayoutPanel2.Margin = new Padding(0, 4, 0, 0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Padding = new Padding(3);
            flowLayoutPanel2.Size = new Size(854, 65);
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
            lblPosition.Location = new Point(6, 34);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(53, 20);
            lblPosition.TabIndex = 1;
            lblPosition.Text = "Admin";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(6, 69);
            panel1.Name = "panel1";
            panel1.Size = new Size(843, 3);
            panel1.TabIndex = 8;
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
            panel3.Location = new Point(260, 69);
            panel3.Name = "panel3";
            panel3.Size = new Size(3, 456);
            panel3.TabIndex = 10;
            panel3.Paint += panel3_Paint;
            // 
            // btnReject
            // 
            btnReject.BackColor = Color.Red;
            btnReject.ForeColor = Color.White;
            btnReject.Location = new Point(562, 442);
            btnReject.Name = "btnReject";
            btnReject.Size = new Size(123, 39);
            btnReject.TabIndex = 22;
            btnReject.Text = "Reject";
            btnReject.UseVisualStyleBackColor = false;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.Black;
            btnCreate.ForeColor = Color.White;
            btnCreate.Location = new Point(269, 442);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(123, 39);
            btnCreate.TabIndex = 21;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(269, 139);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(567, 290);
            dataGridView1.TabIndex = 20;
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.FromArgb(255, 128, 0);
            btnFilter.ForeColor = Color.White;
            btnFilter.Location = new Point(742, 87);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(94, 29);
            btnFilter.TabIndex = 19;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(255, 128, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(642, 87);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 18;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.ForeColor = SystemColors.ScrollBar;
            textBox1.Location = new Point(293, 87);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(320, 27);
            textBox1.TabIndex = 17;
            textBox1.Text = "Transaction ID";
            // 
            // btnAccept
            // 
            btnAccept.BackColor = Color.Black;
            btnAccept.ForeColor = Color.White;
            btnAccept.Location = new Point(414, 442);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(123, 39);
            btnAccept.TabIndex = 23;
            btnAccept.Text = "Accept";
            btnAccept.UseVisualStyleBackColor = false;
            // 
            // lblLogOut
            // 
            lblLogOut.AutoSize = true;
            lblLogOut.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogOut.Location = new Point(34, 442);
            lblLogOut.Name = "lblLogOut";
            lblLogOut.Size = new Size(72, 23);
            lblLogOut.TabIndex = 70;
            lblLogOut.Text = "Log Out";
            // 
            // lblExit
            // 
            lblExit.AutoSize = true;
            lblExit.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExit.Location = new Point(34, 483);
            lblExit.Name = "lblExit";
            lblExit.Size = new Size(38, 23);
            lblExit.TabIndex = 69;
            lblExit.Text = "Exit";
            // 
            // lblViewAuditLogs
            // 
            lblViewAuditLogs.AutoSize = true;
            lblViewAuditLogs.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblViewAuditLogs.Location = new Point(34, 308);
            lblViewAuditLogs.Name = "lblViewAuditLogs";
            lblViewAuditLogs.Size = new Size(133, 23);
            lblViewAuditLogs.TabIndex = 65;
            lblViewAuditLogs.Text = "View Audit Logs";
            // 
            // lblDBbackup
            // 
            lblDBbackup.AutoSize = true;
            lblDBbackup.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDBbackup.Location = new Point(34, 352);
            lblDBbackup.Name = "lblDBbackup";
            lblDBbackup.Size = new Size(208, 23);
            lblDBbackup.TabIndex = 68;
            lblDBbackup.Text = "Perform Database Backup";
            // 
            // lblGenerateReport
            // 
            lblGenerateReport.AutoSize = true;
            lblGenerateReport.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGenerateReport.Location = new Point(34, 399);
            lblGenerateReport.Name = "lblGenerateReport";
            lblGenerateReport.Size = new Size(144, 23);
            lblGenerateReport.TabIndex = 67;
            lblGenerateReport.Text = "Generate Reports";
            // 
            // lblReturnRecords
            // 
            lblReturnRecords.AutoSize = true;
            lblReturnRecords.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReturnRecords.Location = new Point(34, 216);
            lblReturnRecords.Name = "lblReturnRecords";
            lblReturnRecords.Size = new Size(128, 23);
            lblReturnRecords.TabIndex = 63;
            lblReturnRecords.Text = "Return Records";
            // 
            // lblEquipmentManagement
            // 
            lblEquipmentManagement.AutoSize = true;
            lblEquipmentManagement.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEquipmentManagement.Location = new Point(34, 261);
            lblEquipmentManagement.Name = "lblEquipmentManagement";
            lblEquipmentManagement.Size = new Size(201, 23);
            lblEquipmentManagement.TabIndex = 64;
            lblEquipmentManagement.Text = "Equipment Management";
            // 
            // lblTransactions
            // 
            lblTransactions.AutoSize = true;
            lblTransactions.BackColor = Color.FromArgb(255, 128, 0);
            lblTransactions.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTransactions.ForeColor = Color.White;
            lblTransactions.Location = new Point(34, 172);
            lblTransactions.Name = "lblTransactions";
            lblTransactions.Size = new Size(158, 23);
            lblTransactions.TabIndex = 46;
            lblTransactions.Text = "Rental Transactions";
            lblTransactions.Click += lblTransactions_Click;
            // 
            // lblRequest
            // 
            lblRequest.AutoSize = true;
            lblRequest.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRequest.Location = new Point(34, 128);
            lblRequest.Name = "lblRequest";
            lblRequest.Size = new Size(133, 23);
            lblRequest.TabIndex = 61;
            lblRequest.Text = "Rental Requests";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.White;
            label16.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold);
            label16.ForeColor = Color.Black;
            label16.Location = new Point(34, 82);
            label16.Name = "label16";
            label16.Size = new Size(93, 23);
            label16.TabIndex = 60;
            label16.Text = "Dashboard";
            // 
            // lblDashboard
            // 
            lblDashboard.BackColor = Color.White;
            lblDashboard.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold);
            lblDashboard.ForeColor = Color.White;
            lblDashboard.Location = new Point(6, 74);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new Size(236, 40);
            lblDashboard.TabIndex = 66;
            lblDashboard.Text = "Dashboard";
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(255, 128, 0);
            label1.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(255, 128, 0);
            label1.Location = new Point(6, 172);
            label1.Name = "label1";
            label1.Size = new Size(242, 40);
            label1.TabIndex = 71;
            label1.Text = "Dashboard";
            // 
            // RentalTransactions
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
            Controls.Add(btnAccept);
            Controls.Add(btnReject);
            Controls.Add(btnCreate);
            Controls.Add(dataGridView1);
            Controls.Add(btnFilter);
            Controls.Add(btnSearch);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "RentalTransactions";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RentalTransactions";
            Load += RentalTransactions_Load;
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel2;
        private Label lblName;
        private Label lblPosition;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button btnReject;
        private Button btnCreate;
        private DataGridView dataGridView1;
        private Button btnFilter;
        private Button btnSearch;
        private TextBox textBox1;
        private Button btnAccept;
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
        private Label label1;
    }
}