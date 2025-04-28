﻿namespace FormApp.Forms
{
    partial class UpdateTransaction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateTransaction));
            btnUpdate = new Button();
            cmbPaymentStatus = new ComboBox();
            txtDeposit = new TextBox();
            txtFee = new TextBox();
            txtReturnDate = new TextBox();
            txtPickupDate = new TextBox();
            cmbRentalStatus = new ComboBox();
            txtUserID = new TextBox();
            lblCreateTransaction = new Label();
            btnBack = new Button();
            lblDivider = new Label();
            lblRole = new Label();
            lblName = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(249, 115, 22);
            btnUpdate.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(395, 551);
            btnUpdate.Margin = new Padding(2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(113, 35);
            btnUpdate.TabIndex = 60;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // cmbPaymentStatus
            // 
            cmbPaymentStatus.FormattingEnabled = true;
            cmbPaymentStatus.Location = new Point(250, 479);
            cmbPaymentStatus.Margin = new Padding(2);
            cmbPaymentStatus.Name = "cmbPaymentStatus";
            cmbPaymentStatus.Size = new Size(415, 28);
            cmbPaymentStatus.TabIndex = 59;
            // 
            // txtDeposit
            // 
            txtDeposit.BackColor = Color.WhiteSmoke;
            txtDeposit.Location = new Point(489, 410);
            txtDeposit.Margin = new Padding(2);
            txtDeposit.Name = "txtDeposit";
            txtDeposit.Size = new Size(176, 27);
            txtDeposit.TabIndex = 58;
            // 
            // txtFee
            // 
            txtFee.BackColor = Color.WhiteSmoke;
            txtFee.Location = new Point(250, 410);
            txtFee.Margin = new Padding(2);
            txtFee.Name = "txtFee";
            txtFee.Size = new Size(176, 27);
            txtFee.TabIndex = 57;
            // 
            // txtReturnDate
            // 
            txtReturnDate.BackColor = Color.WhiteSmoke;
            txtReturnDate.Location = new Point(489, 338);
            txtReturnDate.Margin = new Padding(2);
            txtReturnDate.Name = "txtReturnDate";
            txtReturnDate.Size = new Size(176, 27);
            txtReturnDate.TabIndex = 55;
            // 
            // txtPickupDate
            // 
            txtPickupDate.BackColor = Color.WhiteSmoke;
            txtPickupDate.Location = new Point(250, 338);
            txtPickupDate.Margin = new Padding(2);
            txtPickupDate.Name = "txtPickupDate";
            txtPickupDate.Size = new Size(176, 27);
            txtPickupDate.TabIndex = 54;
            // 
            // cmbRentalStatus
            // 
            cmbRentalStatus.FormattingEnabled = true;
            cmbRentalStatus.Location = new Point(489, 269);
            cmbRentalStatus.Margin = new Padding(2);
            cmbRentalStatus.Name = "cmbRentalStatus";
            cmbRentalStatus.Size = new Size(176, 28);
            cmbRentalStatus.TabIndex = 53;
            // 
            // txtUserID
            // 
            txtUserID.BackColor = Color.WhiteSmoke;
            txtUserID.Location = new Point(250, 269);
            txtUserID.Margin = new Padding(2);
            txtUserID.Name = "txtUserID";
            txtUserID.ReadOnly = true;
            txtUserID.Size = new Size(176, 27);
            txtUserID.TabIndex = 52;
            // 
            // lblCreateTransaction
            // 
            lblCreateTransaction.AutoSize = true;
            lblCreateTransaction.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblCreateTransaction.Location = new Point(318, 161);
            lblCreateTransaction.Margin = new Padding(2, 0, 2, 0);
            lblCreateTransaction.Name = "lblCreateTransaction";
            lblCreateTransaction.Size = new Size(292, 41);
            lblCreateTransaction.TabIndex = 51;
            lblCreateTransaction.Text = "Update Transaction";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(249, 115, 22);
            btnBack.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(9, 96);
            btnBack.Margin = new Padding(2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(113, 35);
            btnBack.TabIndex = 50;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // lblDivider
            // 
            lblDivider.BackColor = Color.FromArgb(236, 236, 236);
            lblDivider.Location = new Point(-6, 82);
            lblDivider.Margin = new Padding(2, 0, 2, 0);
            lblDivider.Name = "lblDivider";
            lblDivider.Size = new Size(920, 1);
            lblDivider.TabIndex = 49;
            // 
            // lblRole
            // 
            lblRole.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRole.ForeColor = Color.FromArgb(142, 142, 147);
            lblRole.Location = new Point(10, 60);
            lblRole.Margin = new Padding(2, 0, 2, 0);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(154, 20);
            lblRole.TabIndex = 48;
            lblRole.Text = "Role";
            // 
            // lblName
            // 
            lblName.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblName.Location = new Point(4, 9);
            lblName.Margin = new Padding(2, 0, 2, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(217, 41);
            lblName.TabIndex = 47;
            lblName.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(250, 247);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 77;
            label1.Text = "User ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(489, 247);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 78;
            label2.Text = "Rental Status:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(250, 316);
            label3.Name = "label3";
            label3.Size = new Size(93, 20);
            label3.TabIndex = 79;
            label3.Text = "PickUp Date:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(489, 316);
            label4.Name = "label4";
            label4.Size = new Size(91, 20);
            label4.TabIndex = 80;
            label4.Text = "Return Date:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(250, 388);
            label5.Name = "label5";
            label5.Size = new Size(35, 20);
            label5.TabIndex = 81;
            label5.Text = "Fee:";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(489, 388);
            label6.Name = "label6";
            label6.Size = new Size(64, 20);
            label6.TabIndex = 82;
            label6.Text = "Deposit:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(250, 457);
            label7.Name = "label7";
            label7.Size = new Size(112, 20);
            label7.TabIndex = 83;
            label7.Text = "Payment Status:";
            // 
            // UpdateTransaction
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(927, 648);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnUpdate);
            Controls.Add(cmbPaymentStatus);
            Controls.Add(txtDeposit);
            Controls.Add(txtFee);
            Controls.Add(txtReturnDate);
            Controls.Add(txtPickupDate);
            Controls.Add(cmbRentalStatus);
            Controls.Add(txtUserID);
            Controls.Add(lblCreateTransaction);
            Controls.Add(btnBack);
            Controls.Add(lblDivider);
            Controls.Add(lblRole);
            Controls.Add(lblName);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "UpdateTransaction";
            Text = "Update Transaction";
            Load += UpdateTransaction_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUpdate;
        private ComboBox cmbPaymentStatus;
        private TextBox txtDeposit;
        private TextBox txtFee;
        private TextBox txtReturnDate;
        private TextBox txtPickupDate;
        private ComboBox cmbRentalStatus;
        private TextBox txtUserID;
        private Label lblCreateTransaction;
        private Button btnBack;
        private Label lblDivider;
        private Label lblRole;
        private Label lblName;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}