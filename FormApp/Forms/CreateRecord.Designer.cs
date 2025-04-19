namespace FormApp.Forms
{
    partial class CreateRecord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateRecord));
            cmbCondition = new ComboBox();
            txtLateFees = new TextBox();
            txtEquipmentId = new TextBox();
            lblAddEquipment = new Label();
            btnBack = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            lblUserName = new Label();
            lblPosition = new Label();
            dtpReturnDate = new DateTimePicker();
            btnCreate = new Button();
            lblDivider = new Label();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // cmbCondition
            // 
            cmbCondition.ForeColor = Color.Black;
            cmbCondition.FormattingEnabled = true;
            cmbCondition.Location = new Point(444, 232);
            cmbCondition.Name = "cmbCondition";
            cmbCondition.Size = new Size(176, 28);
            cmbCondition.TabIndex = 17;
            cmbCondition.Text = "Condition";
            // 
            // txtLateFees
            // 
            txtLateFees.ForeColor = SystemColors.ScrollBar;
            txtLateFees.Location = new Point(252, 336);
            txtLateFees.Name = "txtLateFees";
            txtLateFees.PlaceholderText = "LateFees";
            txtLateFees.Size = new Size(176, 27);
            txtLateFees.TabIndex = 16;
            txtLateFees.Text = "LateFees";
            // 
            // txtEquipmentId
            // 
            txtEquipmentId.ForeColor = SystemColors.ScrollBar;
            txtEquipmentId.Location = new Point(252, 233);
            txtEquipmentId.Name = "txtEquipmentId";
            txtEquipmentId.PlaceholderText = "Equipment Id";
            txtEquipmentId.Size = new Size(176, 27);
            txtEquipmentId.TabIndex = 14;
            // 
            // lblAddEquipment
            // 
            lblAddEquipment.AutoSize = true;
            lblAddEquipment.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            lblAddEquipment.Location = new Point(335, 154);
            lblAddEquipment.Name = "lblAddEquipment";
            lblAddEquipment.Size = new Size(199, 38);
            lblAddEquipment.TabIndex = 13;
            lblAddEquipment.Text = "Create Record";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(249, 115, 22);
            btnBack.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(9, 96);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(113, 35);
            btnBack.TabIndex = 12;
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
            flowLayoutPanel1.TabIndex = 11;
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
            // dtpReturnDate
            // 
            dtpReturnDate.Location = new Point(252, 290);
            dtpReturnDate.Name = "dtpReturnDate";
            dtpReturnDate.Size = new Size(368, 27);
            dtpReturnDate.TabIndex = 21;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.FromArgb(249, 115, 22);
            btnCreate.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnCreate.ForeColor = Color.White;
            btnCreate.Location = new Point(444, 331);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(176, 35);
            btnCreate.TabIndex = 22;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click_1;
            // 
            // lblDivider
            // 
            lblDivider.BackColor = Color.FromArgb(236, 236, 236);
            lblDivider.Location = new Point(-5, 80);
            lblDivider.Margin = new Padding(2, 0, 2, 0);
            lblDivider.Name = "lblDivider";
            lblDivider.Size = new Size(858, 1);
            lblDivider.TabIndex = 64;
            // 
            // CreateRecord
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(852, 524);
            Controls.Add(lblDivider);
            Controls.Add(btnCreate);
            Controls.Add(dtpReturnDate);
            Controls.Add(cmbCondition);
            Controls.Add(txtLateFees);
            Controls.Add(txtEquipmentId);
            Controls.Add(lblAddEquipment);
            Controls.Add(btnBack);
            Controls.Add(flowLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CreateRecord";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CreateRecord";
            Load += CreateRecord_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private ComboBox cmbCondition;
        private ComboBox cmbAvailability;
        private ComboBox cmbCategory;
        private TextBox txtLateFees;
        private TextBox txtDescription;
        private TextBox txtEquipmentId;
        private Label lblAddEquipment;
        private Button btnBack;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label lblUserName;
        private Label lblPosition;
        private DateTimePicker dtpReturnDate;
        private Button btnCreate;
        private Label lblDivider;
    }
}