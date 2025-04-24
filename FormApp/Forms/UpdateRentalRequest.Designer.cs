namespace FormApp.Forms
{
    partial class UpdateRentalRequest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateRentalRequest));
            lblDivider = new Label();
            btnSave = new Button();
            txtReqId = new TextBox();
            lblUpdateRentalRequest = new Label();
            btnBack = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            lblUserName = new Label();
            lblPosition = new Label();
            label1 = new Label();
            label2 = new Label();
            txtEqName = new TextBox();
            lblStartDate = new Label();
            dptStartDate = new DateTimePicker();
            label3 = new Label();
            dptReturnDate = new DateTimePicker();
            label4 = new Label();
            txtCost = new TextBox();
            lblRentalStatus = new Label();
            cmbRentalStatus = new ComboBox();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblDivider
            // 
            lblDivider.BackColor = Color.FromArgb(236, 236, 236);
            lblDivider.Location = new Point(-2, 80);
            lblDivider.Margin = new Padding(2, 0, 2, 0);
            lblDivider.Name = "lblDivider";
            lblDivider.Size = new Size(858, 1);
            lblDivider.TabIndex = 74;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(249, 115, 22);
            btnSave.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(338, 450);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(172, 35);
            btnSave.TabIndex = 73;
            btnSave.Text = "Save Changes";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtReqId
            // 
            txtReqId.BackColor = Color.WhiteSmoke;
            txtReqId.ForeColor = SystemColors.ScrollBar;
            txtReqId.Location = new Point(205, 234);
            txtReqId.Name = "txtReqId";
            txtReqId.ReadOnly = true;
            txtReqId.Size = new Size(176, 27);
            txtReqId.TabIndex = 67;
            // 
            // lblUpdateRentalRequest
            // 
            lblUpdateRentalRequest.AutoSize = true;
            lblUpdateRentalRequest.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            lblUpdateRentalRequest.Location = new Point(276, 142);
            lblUpdateRentalRequest.Name = "lblUpdateRentalRequest";
            lblUpdateRentalRequest.Size = new Size(315, 38);
            lblUpdateRentalRequest.TabIndex = 66;
            lblUpdateRentalRequest.Text = "Update Rental Request";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(249, 115, 22);
            btnBack.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(9, 96);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(113, 35);
            btnBack.TabIndex = 65;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(lblUserName);
            flowLayoutPanel1.Controls.Add(lblPosition);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(9, 9);
            flowLayoutPanel1.Margin = new Padding(0, 0, 4, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(3);
            flowLayoutPanel1.Size = new Size(851, 65);
            flowLayoutPanel1.TabIndex = 64;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblUserName.Location = new Point(6, 3);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(86, 31);
            lblUserName.TabIndex = 0;
            lblUserName.Text = "Admin";
            // 
            // lblPosition
            // 
            lblPosition.AutoSize = true;
            lblPosition.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblPosition.ForeColor = Color.FromArgb(142, 142, 147);
            lblPosition.Location = new Point(6, 34);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(39, 20);
            lblPosition.TabIndex = 1;
            lblPosition.Text = "Role";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(205, 211);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 75;
            label1.Text = "Request ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(478, 211);
            label2.Name = "label2";
            label2.Size = new Size(128, 20);
            label2.TabIndex = 76;
            label2.Text = "Equipment Name:";
            // 
            // txtEqName
            // 
            txtEqName.BackColor = Color.WhiteSmoke;
            txtEqName.ForeColor = SystemColors.ScrollBar;
            txtEqName.Location = new Point(478, 234);
            txtEqName.Name = "txtEqName";
            txtEqName.ReadOnly = true;
            txtEqName.Size = new Size(176, 27);
            txtEqName.TabIndex = 77;
            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.Location = new Point(205, 283);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(79, 20);
            lblStartDate.TabIndex = 78;
            lblStartDate.Text = "Start Date:";
            // 
            // dptStartDate
            // 
            dptStartDate.Format = DateTimePickerFormat.Short;
            dptStartDate.Location = new Point(205, 306);
            dptStartDate.Name = "dptStartDate";
            dptStartDate.Size = new Size(176, 27);
            dptStartDate.TabIndex = 79;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(478, 283);
            label3.Name = "label3";
            label3.Size = new Size(91, 20);
            label3.TabIndex = 80;
            label3.Text = "Return Date:";
            // 
            // dptReturnDate
            // 
            dptReturnDate.Format = DateTimePickerFormat.Short;
            dptReturnDate.Location = new Point(478, 306);
            dptReturnDate.Name = "dptReturnDate";
            dptReturnDate.Size = new Size(176, 27);
            dptReturnDate.TabIndex = 81;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(205, 366);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 82;
            label4.Text = "Cost:";
            // 
            // txtCost
            // 
            txtCost.BackColor = Color.WhiteSmoke;
            txtCost.ForeColor = SystemColors.ScrollBar;
            txtCost.Location = new Point(205, 389);
            txtCost.Name = "txtCost";
            txtCost.Size = new Size(176, 27);
            txtCost.TabIndex = 83;
            // 
            // lblRentalStatus
            // 
            lblRentalStatus.AutoSize = true;
            lblRentalStatus.Location = new Point(478, 366);
            lblRentalStatus.Name = "lblRentalStatus";
            lblRentalStatus.Size = new Size(98, 20);
            lblRentalStatus.TabIndex = 84;
            lblRentalStatus.Text = "Rental Status:";
            // 
            // cmbRentalStatus
            // 
            cmbRentalStatus.FormattingEnabled = true;
            cmbRentalStatus.Location = new Point(478, 389);
            cmbRentalStatus.Name = "cmbRentalStatus";
            cmbRentalStatus.Size = new Size(176, 28);
            cmbRentalStatus.TabIndex = 85;
            // 
            // UpdateRentalRequest
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(852, 524);
            Controls.Add(cmbRentalStatus);
            Controls.Add(lblRentalStatus);
            Controls.Add(txtCost);
            Controls.Add(label4);
            Controls.Add(dptReturnDate);
            Controls.Add(label3);
            Controls.Add(dptStartDate);
            Controls.Add(lblStartDate);
            Controls.Add(txtEqName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblDivider);
            Controls.Add(btnSave);
            Controls.Add(txtReqId);
            Controls.Add(lblUpdateRentalRequest);
            Controls.Add(btnBack);
            Controls.Add(flowLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "UpdateRentalRequest";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UpdateRentalRequest";
            Load += UpdateRentalRequest_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDivider;
        private Button btnSave;
        private TextBox txtReqId;
        private Label lblUpdateRentalRequest;
        private Button btnBack;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label lblUserName;
        private Label lblPosition;
        private Label label1;
        private Label label2;
        private TextBox txtEqName;
        private Label lblStartDate;
        private DateTimePicker dptStartDate;
        private Label label3;
        private DateTimePicker dptReturnDate;
        private Label label4;
        private TextBox txtCost;
        private Label lblRentalStatus;
        private ComboBox cmbRentalStatus;
    }
}