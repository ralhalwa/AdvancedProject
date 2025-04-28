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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTransaction));
            lblDivider = new Label();
            lblRole = new Label();
            lblName = new Label();
            btnBack = new Button();
            lblCreateTransaction = new Label();
            txtUserID = new TextBox();
            cmbRentalStatus = new ComboBox();
            txtPickupDate = new TextBox();
            txtReturnDate = new TextBox();
            txtFee = new TextBox();
            cmbPaymentStatus = new ComboBox();
            txtDeposit = new TextBox();
            btnCreate = new Button();
            SuspendLayout();
            // 
            // lblDivider
            // 
            lblDivider.BackColor = Color.FromArgb(236, 236, 236);
            lblDivider.Location = new Point(-5, 80);
            lblDivider.Margin = new Padding(2, 0, 2, 0);
            lblDivider.Name = "lblDivider";
            lblDivider.Size = new Size(920, 1);
            lblDivider.TabIndex = 22;
            // 
            // lblRole
            // 
            lblRole.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRole.ForeColor = Color.FromArgb(142, 142, 147);
            lblRole.Location = new Point(10, 60);
            lblRole.Margin = new Padding(2, 0, 2, 0);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(154, 20);
            lblRole.TabIndex = 21;
            lblRole.Text = "Role";
            // 
            // lblName
            // 
            lblName.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblName.Location = new Point(4, 9);
            lblName.Margin = new Padding(2, 0, 2, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(217, 41);
            lblName.TabIndex = 20;
            lblName.Text = "Name";
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
            btnBack.TabIndex = 35;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // lblCreateTransaction
            // 
            lblCreateTransaction.AutoSize = true;
            lblCreateTransaction.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblCreateTransaction.Location = new Point(328, 153);
            lblCreateTransaction.Margin = new Padding(2, 0, 2, 0);
            lblCreateTransaction.Name = "lblCreateTransaction";
            lblCreateTransaction.Size = new Size(279, 41);
            lblCreateTransaction.TabIndex = 36;
            lblCreateTransaction.Text = "Create Transaction";
            // 
            // txtUserID
            // 
            txtUserID.BackColor = Color.WhiteSmoke;
            txtUserID.Location = new Point(277, 241);
            txtUserID.Margin = new Padding(2);
            txtUserID.Name = "txtUserID";
            txtUserID.Size = new Size(162, 27);
            txtUserID.TabIndex = 37;
            // 
            // cmbRentalStatus
            // 
            cmbRentalStatus.BackColor = Color.WhiteSmoke;
            cmbRentalStatus.FormattingEnabled = true;
            cmbRentalStatus.Location = new Point(481, 241);
            cmbRentalStatus.Margin = new Padding(2);
            cmbRentalStatus.Name = "cmbRentalStatus";
            cmbRentalStatus.Size = new Size(162, 28);
            cmbRentalStatus.TabIndex = 39;
            // 
            // txtPickupDate
            // 
            txtPickupDate.BackColor = Color.WhiteSmoke;
            txtPickupDate.Location = new Point(277, 293);
            txtPickupDate.Margin = new Padding(2);
            txtPickupDate.Name = "txtPickupDate";
            txtPickupDate.Size = new Size(366, 27);
            txtPickupDate.TabIndex = 40;
            // 
            // txtReturnDate
            // 
            txtReturnDate.BackColor = Color.WhiteSmoke;
            txtReturnDate.Location = new Point(277, 344);
            txtReturnDate.Margin = new Padding(2);
            txtReturnDate.Name = "txtReturnDate";
            txtReturnDate.Size = new Size(366, 27);
            txtReturnDate.TabIndex = 41;
            // 
            // txtFee
            // 
            txtFee.BackColor = Color.WhiteSmoke;
            txtFee.Location = new Point(277, 390);
            txtFee.Margin = new Padding(2);
            txtFee.Name = "txtFee";
            txtFee.Size = new Size(162, 27);
            txtFee.TabIndex = 43;
            // 
            // cmbPaymentStatus
            // 
            cmbPaymentStatus.BackColor = Color.WhiteSmoke;
            cmbPaymentStatus.FormattingEnabled = true;
            cmbPaymentStatus.Location = new Point(277, 451);
            cmbPaymentStatus.Margin = new Padding(2);
            cmbPaymentStatus.Name = "cmbPaymentStatus";
            cmbPaymentStatus.Size = new Size(366, 28);
            cmbPaymentStatus.TabIndex = 45;
            // 
            // txtDeposit
            // 
            txtDeposit.BackColor = Color.WhiteSmoke;
            txtDeposit.Location = new Point(481, 390);
            txtDeposit.Margin = new Padding(2);
            txtDeposit.Name = "txtDeposit";
            txtDeposit.Size = new Size(162, 27);
            txtDeposit.TabIndex = 44;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.FromArgb(249, 115, 22);
            btnCreate.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnCreate.ForeColor = Color.White;
            btnCreate.Location = new Point(403, 521);
            btnCreate.Margin = new Padding(2);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(113, 35);
            btnCreate.TabIndex = 46;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // CreateTransaction
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(927, 648);
            Controls.Add(btnCreate);
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
        private TextBox txtFee;
        private ComboBox cmbPaymentStatus;
        private TextBox txtDeposit;
        private Button btnCreate;
    }
}