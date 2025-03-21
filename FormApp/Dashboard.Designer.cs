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
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblRecentEq = new Label();
            dataGridView1 = new DataGridView();
            lblRecentRentalReq = new Label();
            dataGridView2 = new DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
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
            pnlInfo.Controls.Add(label14);
            pnlInfo.Controls.Add(label13);
            pnlInfo.Controls.Add(label12);
            pnlInfo.Controls.Add(label11);
            pnlInfo.Controls.Add(label10);
            pnlInfo.Controls.Add(label9);
            pnlInfo.Controls.Add(label8);
            pnlInfo.Controls.Add(label7);
            pnlInfo.Controls.Add(label6);
            pnlInfo.Controls.Add(label5);
            pnlInfo.Controls.Add(label4);
            pnlInfo.Controls.Add(label3);
            pnlInfo.Controls.Add(label2);
            pnlInfo.Controls.Add(label1);
            pnlInfo.Location = new Point(260, 76);
            pnlInfo.Name = "pnlInfo";
            pnlInfo.Size = new Size(571, 161);
            pnlInfo.TabIndex = 2;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(498, 126);
            label14.Name = "label14";
            label14.Size = new Size(18, 20);
            label14.TabIndex = 13;
            label14.Text = "...";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(498, 94);
            label13.Name = "label13";
            label13.Size = new Size(18, 20);
            label13.TabIndex = 12;
            label13.Text = "...";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(498, 62);
            label12.Name = "label12";
            label12.Size = new Size(18, 20);
            label12.TabIndex = 11;
            label12.Text = "...";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(222, 126);
            label11.Name = "label11";
            label11.Size = new Size(18, 20);
            label11.TabIndex = 10;
            label11.Text = "...";
            label11.Click += label11_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(222, 94);
            label10.Name = "label10";
            label10.Size = new Size(18, 20);
            label10.TabIndex = 9;
            label10.Text = "...";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(222, 62);
            label9.Name = "label9";
            label9.Size = new Size(18, 20);
            label9.TabIndex = 8;
            label9.Text = "...";
            label9.Click += label9_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(325, 126);
            label8.Name = "label8";
            label8.Size = new Size(128, 20);
            label8.TabIndex = 7;
            label8.Text = "Overdue Requests";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(325, 62);
            label7.Name = "label7";
            label7.Size = new Size(102, 20);
            label7.TabIndex = 6;
            label7.Text = "Active Rentals";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(325, 94);
            label6.Name = "label6";
            label6.Size = new Size(125, 20);
            label6.TabIndex = 5;
            label6.Text = "Pending Requests";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 126);
            label5.Name = "label5";
            label5.Size = new Size(132, 20);
            label5.TabIndex = 4;
            label5.Text = "Rented Equipment";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 62);
            label4.Name = "label4";
            label4.Size = new Size(108, 20);
            label4.TabIndex = 3;
            label4.Text = "Total Summary";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 94);
            label3.Name = "label3";
            label3.Size = new Size(147, 20);
            label3.TabIndex = 2;
            label3.Text = "Available Equipment";
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
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(260, 285);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(556, 88);
            dataGridView1.TabIndex = 4;
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
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(260, 414);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(556, 90);
            dataGridView2.TabIndex = 6;
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
            Controls.Add(dataGridView2);
            Controls.Add(lblRecentRentalReq);
            Controls.Add(dataGridView1);
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
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
        private DataGridView dataGridView1;
        private Label lblRecentRentalReq;
        private DataGridView dataGridView2;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label9;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
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