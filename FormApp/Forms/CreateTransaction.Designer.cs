namespace FormApp.Forms
{
    partial class CreateTransaction
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
            lblDivider = new Label();
            lblRole = new Label();
            lblName = new Label();
            btnBack = new Button();
            lblCreateTransaction = new Label();
            txtUserID = new TextBox();
            cmbRentalStatus = new ComboBox();
            txtPickupDate = new TextBox();
            txtReturnDate = new TextBox();
            txtPeriod = new TextBox();
            txtFee = new TextBox();
            cmbPaymentStatus = new ComboBox();
            txtDeposit = new TextBox();
            btnCreate = new Button();
            SuspendLayout();
            // 
            // lblDivider
            // 
            lblDivider.BackColor = Color.FromArgb(236, 236, 236);
            lblDivider.Location = new Point(-11, 128);
            lblDivider.Name = "lblDivider";
            lblDivider.Size = new Size(1395, 2);
            lblDivider.TabIndex = 22;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRole.ForeColor = Color.FromArgb(142, 142, 147);
            lblRole.Location = new Point(28, 67);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(61, 32);
            lblRole.TabIndex = 21;
            lblRole.Text = "Role";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI Semibold", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(28, 23);
            lblName.Name = "lblName";
            lblName.Size = new Size(95, 40);
            lblName.TabIndex = 20;
            lblName.Text = "Name";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(249, 115, 22);
            btnBack.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(28, 149);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(147, 46);
            btnBack.TabIndex = 35;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            // 
            // lblCreateTransaction
            // 
            lblCreateTransaction.AutoSize = true;
            lblCreateTransaction.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCreateTransaction.Location = new Point(498, 229);
            lblCreateTransaction.Name = "lblCreateTransaction";
            lblCreateTransaction.Size = new Size(399, 59);
            lblCreateTransaction.TabIndex = 36;
            lblCreateTransaction.Text = "Create Transaction";
            // 
            // txtUserID
            // 
            txtUserID.BackColor = Color.WhiteSmoke;
            txtUserID.Location = new Point(429, 326);
            txtUserID.Name = "txtUserID";
            txtUserID.Size = new Size(260, 39);
            txtUserID.TabIndex = 37;
            // 
            // cmbRentalStatus
            // 
            cmbRentalStatus.FormattingEnabled = true;
            cmbRentalStatus.Location = new Point(706, 326);
            cmbRentalStatus.Name = "cmbRentalStatus";
            cmbRentalStatus.Size = new Size(260, 40);
            cmbRentalStatus.TabIndex = 39;
            // 
            // txtPickupDate
            // 
            txtPickupDate.BackColor = Color.WhiteSmoke;
            txtPickupDate.Location = new Point(429, 391);
            txtPickupDate.Name = "txtPickupDate";
            txtPickupDate.Size = new Size(537, 39);
            txtPickupDate.TabIndex = 40;
            // 
            // txtReturnDate
            // 
            txtReturnDate.BackColor = Color.WhiteSmoke;
            txtReturnDate.Location = new Point(429, 453);
            txtReturnDate.Name = "txtReturnDate";
            txtReturnDate.Size = new Size(537, 39);
            txtReturnDate.TabIndex = 41;
            // 
            // txtPeriod
            // 
            txtPeriod.BackColor = Color.WhiteSmoke;
            txtPeriod.Location = new Point(429, 515);
            txtPeriod.Name = "txtPeriod";
            txtPeriod.Size = new Size(260, 39);
            txtPeriod.TabIndex = 42;
            // 
            // txtFee
            // 
            txtFee.BackColor = Color.WhiteSmoke;
            txtFee.Location = new Point(706, 515);
            txtFee.Name = "txtFee";
            txtFee.Size = new Size(260, 39);
            txtFee.TabIndex = 43;
            // 
            // cmbPaymentStatus
            // 
            cmbPaymentStatus.FormattingEnabled = true;
            cmbPaymentStatus.Location = new Point(706, 578);
            cmbPaymentStatus.Name = "cmbPaymentStatus";
            cmbPaymentStatus.Size = new Size(260, 40);
            cmbPaymentStatus.TabIndex = 45;
            // 
            // txtDeposit
            // 
            txtDeposit.BackColor = Color.WhiteSmoke;
            txtDeposit.Location = new Point(429, 578);
            txtDeposit.Name = "txtDeposit";
            txtDeposit.Size = new Size(260, 39);
            txtDeposit.TabIndex = 44;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.FromArgb(249, 115, 22);
            btnCreate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreate.ForeColor = Color.White;
            btnCreate.Location = new Point(614, 650);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(168, 57);
            btnCreate.TabIndex = 46;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = false;
            // 
            // CreateTransaction
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1385, 838);
            Controls.Add(btnCreate);
            Controls.Add(cmbPaymentStatus);
            Controls.Add(txtDeposit);
            Controls.Add(txtFee);
            Controls.Add(txtPeriod);
            Controls.Add(txtReturnDate);
            Controls.Add(txtPickupDate);
            Controls.Add(cmbRentalStatus);
            Controls.Add(txtUserID);
            Controls.Add(lblCreateTransaction);
            Controls.Add(btnBack);
            Controls.Add(lblDivider);
            Controls.Add(lblRole);
            Controls.Add(lblName);
            Name = "CreateTransaction";
            Text = "Create Transaction";
            Load += CreateTransaction_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDivider;
        private Label lblRole;
        private Label lblName;
        private Button btnBack;
        private Label lblCreateTransaction;
        private TextBox txtUserID;
        private ComboBox cmbRentalStatus;
        private TextBox txtPickupDate;
        private TextBox txtReturnDate;
        private TextBox txtPeriod;
        private TextBox txtFee;
        private ComboBox cmbPaymentStatus;
        private TextBox txtDeposit;
        private Button btnCreate;
    }
}