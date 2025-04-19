namespace FormApp.Forms
{
    partial class UpdateRecord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateRecord));
            btnSave = new Button();
            dtpReturnDate = new DateTimePicker();
            cmbCondition = new ComboBox();
            txtRecordID = new TextBox();
            lblAddEquipment = new Label();
            btnBack = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            lblUserName = new Label();
            lblPosition = new Label();
            txtLateFees = new TextBox();
            txtEquipmentID = new TextBox();
            lblDivider = new Label();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(249, 115, 22);
            btnSave.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(354, 379);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(176, 35);
            btnSave.TabIndex = 30;
            btnSave.Text = "Save Changes";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // dtpReturnDate
            // 
            dtpReturnDate.Location = new Point(252, 337);
            dtpReturnDate.Name = "dtpReturnDate";
            dtpReturnDate.Size = new Size(368, 27);
            dtpReturnDate.TabIndex = 29;
            // 
            // cmbCondition
            // 
            cmbCondition.ForeColor = SystemColors.ScrollBar;
            cmbCondition.FormattingEnabled = true;
            cmbCondition.Location = new Point(252, 293);
            cmbCondition.Name = "cmbCondition";
            cmbCondition.Size = new Size(176, 28);
            cmbCondition.TabIndex = 28;
            cmbCondition.Text = "Condition";
            // 
            // txtRecordID
            // 
            txtRecordID.ForeColor = SystemColors.ScrollBar;
            txtRecordID.Location = new Point(252, 233);
            txtRecordID.Name = "txtRecordID";
            txtRecordID.PlaceholderText = "Return Record Id";
            txtRecordID.ReadOnly = true;
            txtRecordID.Size = new Size(176, 27);
            txtRecordID.TabIndex = 26;
            // 
            // lblAddEquipment
            // 
            lblAddEquipment.AutoSize = true;
            lblAddEquipment.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            lblAddEquipment.Location = new Point(335, 154);
            lblAddEquipment.Name = "lblAddEquipment";
            lblAddEquipment.Size = new Size(210, 38);
            lblAddEquipment.TabIndex = 25;
            lblAddEquipment.Text = "Update Record";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(249, 115, 22);
            btnBack.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(9, 96);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(113, 35);
            btnBack.TabIndex = 24;
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
            flowLayoutPanel1.TabIndex = 23;
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
            // txtLateFees
            // 
            txtLateFees.ForeColor = SystemColors.ScrollBar;
            txtLateFees.Location = new Point(444, 293);
            txtLateFees.Name = "txtLateFees";
            txtLateFees.PlaceholderText = "LateFees";
            txtLateFees.Size = new Size(176, 27);
            txtLateFees.TabIndex = 31;
            // 
            // txtEquipmentID
            // 
            txtEquipmentID.ForeColor = SystemColors.ScrollBar;
            txtEquipmentID.Location = new Point(444, 233);
            txtEquipmentID.Name = "txtEquipmentID";
            txtEquipmentID.PlaceholderText = "Equipment Id";
            txtEquipmentID.ReadOnly = true;
            txtEquipmentID.Size = new Size(176, 27);
            txtEquipmentID.TabIndex = 32;
            // 
            // lblDivider
            // 
            lblDivider.BackColor = Color.FromArgb(236, 236, 236);
            lblDivider.Location = new Point(-5, 80);
            lblDivider.Margin = new Padding(2, 0, 2, 0);
            lblDivider.Name = "lblDivider";
            lblDivider.Size = new Size(858, 1);
            lblDivider.TabIndex = 65;
            // 
            // UpdateRecord
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(852, 524);
            Controls.Add(lblDivider);
            Controls.Add(txtEquipmentID);
            Controls.Add(txtLateFees);
            Controls.Add(btnSave);
            Controls.Add(dtpReturnDate);
            Controls.Add(cmbCondition);
            Controls.Add(txtRecordID);
            Controls.Add(lblAddEquipment);
            Controls.Add(btnBack);
            Controls.Add(flowLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "UpdateRecord";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UpdateRecord";
            Load += UpdateRecord_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private DateTimePicker dtpReturnDate;
        private ComboBox cmbCondition;
        private TextBox txtRecordID;
        private Label lblAddEquipment;
        private Button btnBack;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label lblUserName;
        private Label lblPosition;
        private TextBox txtLateFees;
        private TextBox txtEquipmentID;
        private Label lblDivider;
    }
}