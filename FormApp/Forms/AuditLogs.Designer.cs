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
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI Semibold", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(31, 23);
            lblName.Name = "lblName";
            lblName.Size = new Size(239, 40);
            lblName.TabIndex = 0;
            lblName.Text = "Khalid Almurbati";
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRole.ForeColor = Color.FromArgb(142, 142, 147);
            lblRole.Location = new Point(31, 67);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(164, 32);
            lblRole.TabIndex = 1;
            lblRole.Text = "Administrator";
            // 
            // lblDivider
            // 
            lblDivider.BackColor = Color.FromArgb(236, 236, 236);
            lblDivider.Location = new Point(-8, 128);
            lblDivider.Name = "lblDivider";
            lblDivider.Size = new Size(1276, 2);
            lblDivider.TabIndex = 2;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(236, 236, 236);
            label1.Location = new Point(368, 130);
            label1.Name = "label1";
            label1.Size = new Size(2, 622);
            label1.TabIndex = 3;
            // 
            // lblDashboard
            // 
            lblDashboard.AutoSize = true;
            lblDashboard.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDashboard.Location = new Point(31, 147);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new Size(150, 37);
            lblDashboard.TabIndex = 4;
            lblDashboard.Text = "Dashboard";
            // 
            // lblRentalRequests
            // 
            lblRentalRequests.AutoSize = true;
            lblRentalRequests.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRentalRequests.Location = new Point(31, 211);
            lblRentalRequests.Name = "lblRentalRequests";
            lblRentalRequests.Size = new Size(211, 37);
            lblRentalRequests.TabIndex = 5;
            lblRentalRequests.Text = "Rental Requests";
            // 
            // lblRentalTransactions
            // 
            lblRentalTransactions.AutoSize = true;
            lblRentalTransactions.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRentalTransactions.Location = new Point(31, 277);
            lblRentalTransactions.Name = "lblRentalTransactions";
            lblRentalTransactions.Size = new Size(254, 37);
            lblRentalTransactions.TabIndex = 6;
            lblRentalTransactions.Text = "Rental Transactions";
            // 
            // lblReturnRecords
            // 
            lblReturnRecords.AutoSize = true;
            lblReturnRecords.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReturnRecords.Location = new Point(31, 342);
            lblReturnRecords.Name = "lblReturnRecords";
            lblReturnRecords.Size = new Size(203, 37);
            lblReturnRecords.TabIndex = 7;
            lblReturnRecords.Text = "Return Records";
            // 
            // lblEquipmentManagement
            // 
            lblEquipmentManagement.AutoSize = true;
            lblEquipmentManagement.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEquipmentManagement.Location = new Point(31, 409);
            lblEquipmentManagement.Name = "lblEquipmentManagement";
            lblEquipmentManagement.Size = new Size(320, 37);
            lblEquipmentManagement.TabIndex = 8;
            lblEquipmentManagement.Text = "Equipment Management";
            // 
            // lblAuditLogs
            // 
            lblAuditLogs.AutoSize = true;
            lblAuditLogs.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAuditLogs.Location = new Point(31, 478);
            lblAuditLogs.Name = "lblAuditLogs";
            lblAuditLogs.Size = new Size(148, 37);
            lblAuditLogs.TabIndex = 9;
            lblAuditLogs.Text = "Audit Logs";
            // 
            // lblLogOut
            // 
            lblLogOut.AutoSize = true;
            lblLogOut.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogOut.Location = new Point(31, 545);
            lblLogOut.Name = "lblLogOut";
            lblLogOut.Size = new Size(115, 37);
            lblLogOut.TabIndex = 10;
            lblLogOut.Text = "Log Out";
            // 
            // lblExit
            // 
            lblExit.AutoSize = true;
            lblExit.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExit.Location = new Point(31, 612);
            lblExit.Name = "lblExit";
            lblExit.Size = new Size(62, 37);
            lblExit.TabIndex = 11;
            lblExit.Text = "Exit";
            // 
            // txtSearchBar
            // 
            txtSearchBar.BackColor = Color.WhiteSmoke;
            txtSearchBar.Location = new Point(401, 155);
            txtSearchBar.Name = "txtSearchBar";
            txtSearchBar.Size = new Size(626, 39);
            txtSearchBar.TabIndex = 12;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(249, 115, 22);
            btnSearch.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(1033, 153);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(162, 46);
            btnSearch.TabIndex = 13;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(368, 211);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(860, 528);
            dataGridView1.TabIndex = 14;
            // 
            // AuditLogs
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1230, 738);
            Controls.Add(dataGridView1);
            Controls.Add(btnSearch);
            Controls.Add(txtSearchBar);
            Controls.Add(lblExit);
            Controls.Add(lblLogOut);
            Controls.Add(lblAuditLogs);
            Controls.Add(lblEquipmentManagement);
            Controls.Add(lblReturnRecords);
            Controls.Add(lblRentalTransactions);
            Controls.Add(lblRentalRequests);
            Controls.Add(lblDashboard);
            Controls.Add(label1);
            Controls.Add(lblDivider);
            Controls.Add(lblRole);
            Controls.Add(lblName);
            Name = "AuditLogs";
            Text = "Audit Logs";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private DataGridView dataGridView1;
    }
}