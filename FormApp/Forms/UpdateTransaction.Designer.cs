namespace FormApp.Forms
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
            SuspendLayout();
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(249, 115, 22);
            btnUpdate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(615, 653);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(168, 57);
            btnUpdate.TabIndex = 60;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // cmbPaymentStatus
            // 
            cmbPaymentStatus.FormattingEnabled = true;
            cmbPaymentStatus.Location = new Point(430, 581);
            cmbPaymentStatus.Name = "cmbPaymentStatus";
            cmbPaymentStatus.Size = new Size(537, 40);
            cmbPaymentStatus.TabIndex = 59;
            // 
            // txtDeposit
            // 
            txtDeposit.BackColor = Color.WhiteSmoke;
            txtDeposit.Location = new Point(707, 518);
            txtDeposit.Name = "txtDeposit";
            txtDeposit.Size = new Size(260, 39);
            txtDeposit.TabIndex = 58;
            // 
            // txtFee
            // 
            txtFee.BackColor = Color.WhiteSmoke;
            txtFee.Location = new Point(430, 518);
            txtFee.Name = "txtFee";
            txtFee.Size = new Size(260, 39);
            txtFee.TabIndex = 57;
            // 
            // txtReturnDate
            // 
            txtReturnDate.BackColor = Color.WhiteSmoke;
            txtReturnDate.Location = new Point(430, 456);
            txtReturnDate.Name = "txtReturnDate";
            txtReturnDate.Size = new Size(537, 39);
            txtReturnDate.TabIndex = 55;
            // 
            // txtPickupDate
            // 
            txtPickupDate.BackColor = Color.WhiteSmoke;
            txtPickupDate.Location = new Point(430, 394);
            txtPickupDate.Name = "txtPickupDate";
            txtPickupDate.Size = new Size(537, 39);
            txtPickupDate.TabIndex = 54;
            // 
            // cmbRentalStatus
            // 
            cmbRentalStatus.FormattingEnabled = true;
            cmbRentalStatus.Location = new Point(707, 329);
            cmbRentalStatus.Name = "cmbRentalStatus";
            cmbRentalStatus.Size = new Size(260, 40);
            cmbRentalStatus.TabIndex = 53;
            // 
            // txtUserID
            // 
            txtUserID.BackColor = Color.WhiteSmoke;
            txtUserID.Location = new Point(430, 329);
            txtUserID.Name = "txtUserID";
            txtUserID.Size = new Size(260, 39);
            txtUserID.TabIndex = 52;
            // 
            // lblCreateTransaction
            // 
            lblCreateTransaction.AutoSize = true;
            lblCreateTransaction.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCreateTransaction.Location = new Point(490, 232);
            lblCreateTransaction.Name = "lblCreateTransaction";
            lblCreateTransaction.Size = new Size(417, 59);
            lblCreateTransaction.TabIndex = 51;
            lblCreateTransaction.Text = "Update Transaction";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(249, 115, 22);
            btnBack.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(29, 152);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(147, 46);
            btnBack.TabIndex = 50;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            // 
            // lblDivider
            // 
            lblDivider.BackColor = Color.FromArgb(236, 236, 236);
            lblDivider.Location = new Point(-10, 131);
            lblDivider.Name = "lblDivider";
            lblDivider.Size = new Size(1395, 2);
            lblDivider.TabIndex = 49;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRole.ForeColor = Color.FromArgb(142, 142, 147);
            lblRole.Location = new Point(29, 70);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(61, 32);
            lblRole.TabIndex = 48;
            lblRole.Text = "Role";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI Semibold", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(29, 26);
            lblName.Name = "lblName";
            lblName.Size = new Size(95, 40);
            lblName.TabIndex = 47;
            lblName.Text = "Name";
            // 
            // UpdateTransaction
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1385, 838);
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
    }
}