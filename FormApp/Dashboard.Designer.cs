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
            flowLayoutPanel1 = new FlowLayoutPanel();
            button1 = new Button();
            btnReturnRequest = new Button();
            btnRentalTransactions = new Button();
            btnReturnRecords = new Button();
            btnEquipmentManagement = new Button();
            btnAuditLogs = new Button();
            btnDbBackup = new Button();
            btnGenerateReport = new Button();
            btnLogout = new Button();
            btnExit = new Button();
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
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            pnlInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(btnReturnRequest);
            flowLayoutPanel1.Controls.Add(btnRentalTransactions);
            flowLayoutPanel1.Controls.Add(btnReturnRecords);
            flowLayoutPanel1.Controls.Add(btnEquipmentManagement);
            flowLayoutPanel1.Controls.Add(btnAuditLogs);
            flowLayoutPanel1.Controls.Add(btnDbBackup);
            flowLayoutPanel1.Controls.Add(btnGenerateReport);
            flowLayoutPanel1.Controls.Add(btnLogout);
            flowLayoutPanel1.Controls.Add(btnExit);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(-2, 60);
            flowLayoutPanel1.Margin = new Padding(10);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(0, 15, 0, 0);
            flowLayoutPanel1.Size = new Size(211, 389);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(3, 18);
            button1.Name = "button1";
            button1.Size = new Size(208, 29);
            button1.TabIndex = 0;
            button1.Text = "Dashboard";
            button1.UseVisualStyleBackColor = false;
            // 
            // btnReturnRequest
            // 
            btnReturnRequest.Location = new Point(3, 53);
            btnReturnRequest.Name = "btnReturnRequest";
            btnReturnRequest.Size = new Size(208, 29);
            btnReturnRequest.TabIndex = 1;
            btnReturnRequest.Text = "Rental Requests";
            btnReturnRequest.UseVisualStyleBackColor = true;
            btnReturnRequest.Click += button2_Click;
            // 
            // btnRentalTransactions
            // 
            btnRentalTransactions.Location = new Point(3, 88);
            btnRentalTransactions.Name = "btnRentalTransactions";
            btnRentalTransactions.Size = new Size(208, 29);
            btnRentalTransactions.TabIndex = 2;
            btnRentalTransactions.Text = "Rental Transactions";
            btnRentalTransactions.UseVisualStyleBackColor = true;
            btnRentalTransactions.Click += btnRentalTransactions_Click;
            // 
            // btnReturnRecords
            // 
            btnReturnRecords.Location = new Point(3, 123);
            btnReturnRecords.Name = "btnReturnRecords";
            btnReturnRecords.Size = new Size(208, 29);
            btnReturnRecords.TabIndex = 3;
            btnReturnRecords.Text = "Return Records";
            btnReturnRecords.UseVisualStyleBackColor = true;
            btnReturnRecords.Click += btnRentalRecords_Click;
            // 
            // btnEquipmentManagement
            // 
            btnEquipmentManagement.Location = new Point(3, 158);
            btnEquipmentManagement.Name = "btnEquipmentManagement";
            btnEquipmentManagement.Size = new Size(208, 29);
            btnEquipmentManagement.TabIndex = 4;
            btnEquipmentManagement.Text = "Equipment Management";
            btnEquipmentManagement.UseVisualStyleBackColor = true;
            btnEquipmentManagement.Click += btnEquipmentManagement_Click;
            // 
            // btnAuditLogs
            // 
            btnAuditLogs.Location = new Point(3, 193);
            btnAuditLogs.Name = "btnAuditLogs";
            btnAuditLogs.Size = new Size(208, 29);
            btnAuditLogs.TabIndex = 5;
            btnAuditLogs.Text = "View Audit Logs";
            btnAuditLogs.UseVisualStyleBackColor = true;
            btnAuditLogs.Click += btnAuditLogs_Click;
            // 
            // btnDbBackup
            // 
            btnDbBackup.Location = new Point(3, 228);
            btnDbBackup.Name = "btnDbBackup";
            btnDbBackup.Size = new Size(208, 29);
            btnDbBackup.TabIndex = 6;
            btnDbBackup.Text = "Perform Database Backup";
            btnDbBackup.UseVisualStyleBackColor = true;
            btnDbBackup.Click += btnDbBackup_Click;
            // 
            // btnGenerateReport
            // 
            btnGenerateReport.Location = new Point(3, 263);
            btnGenerateReport.Name = "btnGenerateReport";
            btnGenerateReport.Size = new Size(208, 29);
            btnGenerateReport.TabIndex = 7;
            btnGenerateReport.Text = "Generate Report";
            btnGenerateReport.UseVisualStyleBackColor = true;
            btnGenerateReport.Click += btnGenerateReport_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(3, 298);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(208, 29);
            btnLogout.TabIndex = 8;
            btnLogout.Text = "Log Out";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(3, 333);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(208, 29);
            btnExit.TabIndex = 9;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += button10_Click;
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
            flowLayoutPanel2.Size = new Size(802, 62);
            flowLayoutPanel2.TabIndex = 1;
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
            pnlInfo.Location = new Point(232, 73);
            pnlInfo.Name = "pnlInfo";
            pnlInfo.Size = new Size(568, 152);
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
            lblRecentEq.Location = new Point(232, 246);
            lblRecentEq.Name = "lblRecentEq";
            lblRecentEq.Size = new Size(230, 23);
            lblRecentEq.TabIndex = 3;
            lblRecentEq.Text = "Recently Added Equipment";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(232, 272);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(556, 67);
            dataGridView1.TabIndex = 4;
            // 
            // lblRecentRentalReq
            // 
            lblRecentRentalReq.AutoSize = true;
            lblRecentRentalReq.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecentRentalReq.Location = new Point(232, 342);
            lblRecentRentalReq.Name = "lblRecentRentalReq";
            lblRecentRentalReq.Size = new Size(183, 23);
            lblRecentRentalReq.TabIndex = 5;
            lblRecentRentalReq.Text = "Latest Rental Request";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(232, 365);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(556, 67);
            dataGridView2.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(-2, 67);
            panel1.Name = "panel1";
            panel1.Size = new Size(806, 3);
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
            panel3.Location = new Point(215, 72);
            panel3.Name = "panel3";
            panel3.Size = new Size(3, 393);
            panel3.TabIndex = 8;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(dataGridView2);
            Controls.Add(lblRecentRentalReq);
            Controls.Add(dataGridView1);
            Controls.Add(lblRecentEq);
            Controls.Add(pnlInfo);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            flowLayoutPanel1.ResumeLayout(false);
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

        private FlowLayoutPanel flowLayoutPanel1;
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
        private Button button1;
        private Button btnReturnRequest;
        private Button btnRentalTransactions;
        private Button btnReturnRecords;
        private Button btnEquipmentManagement;
        private Button btnAuditLogs;
        private Button btnDbBackup;
        private Button btnGenerateReport;
        private Button btnLogout;
        private Button btnExit;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label9;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
    }
}