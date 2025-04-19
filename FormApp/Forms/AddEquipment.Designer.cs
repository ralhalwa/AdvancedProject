namespace FormApp.Forms
{
    partial class AddEquipment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEquipment));
            flowLayoutPanel1 = new FlowLayoutPanel();
            lblUserName = new Label();
            lblPosition = new Label();
            btnBack = new Button();
            lblAddEquipment = new Label();
            txtName = new TextBox();
            txtDescription = new TextBox();
            txtPrice = new TextBox();
            cmbCategory = new ComboBox();
            cmbAvailability = new ComboBox();
            cmbCondition = new ComboBox();
            btnAdd = new Button();
            lblDivider = new Label();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(lblUserName);
            flowLayoutPanel1.Controls.Add(lblPosition);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(6, 9);
            flowLayoutPanel1.Margin = new Padding(0, 0, 4, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(3);
            flowLayoutPanel1.Size = new Size(851, 65);
            flowLayoutPanel1.TabIndex = 0;
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
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(249, 115, 22);
            btnBack.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(6, 96);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(113, 35);
            btnBack.TabIndex = 1;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // lblAddEquipment
            // 
            lblAddEquipment.AutoSize = true;
            lblAddEquipment.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            lblAddEquipment.Location = new Point(288, 129);
            lblAddEquipment.Name = "lblAddEquipment";
            lblAddEquipment.Size = new Size(222, 38);
            lblAddEquipment.TabIndex = 2;
            lblAddEquipment.Text = "Add Equipment";
            // 
            // txtName
            // 
            txtName.ForeColor = SystemColors.ScrollBar;
            txtName.Location = new Point(230, 198);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Name";
            txtName.Size = new Size(176, 27);
            txtName.TabIndex = 3;
            // 
            // txtDescription
            // 
            txtDescription.ForeColor = SystemColors.ScrollBar;
            txtDescription.Location = new Point(230, 244);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.PlaceholderText = "Description";
            txtDescription.Size = new Size(368, 27);
            txtDescription.TabIndex = 5;
            txtDescription.Text = "Description";
            // 
            // txtPrice
            // 
            txtPrice.ForeColor = SystemColors.ScrollBar;
            txtPrice.Location = new Point(230, 301);
            txtPrice.Name = "txtPrice";
            txtPrice.PlaceholderText = "Price";
            txtPrice.Size = new Size(176, 27);
            txtPrice.TabIndex = 6;
            txtPrice.Text = "Price";
            // 
            // cmbCategory
            // 
            cmbCategory.ForeColor = Color.Black;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(422, 197);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(176, 28);
            cmbCategory.TabIndex = 7;
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
            // 
            // cmbAvailability
            // 
            cmbAvailability.DisplayMember = "Status";
            cmbAvailability.ForeColor = Color.Black;
            cmbAvailability.FormattingEnabled = true;
            cmbAvailability.Location = new Point(422, 301);
            cmbAvailability.Name = "cmbAvailability";
            cmbAvailability.Size = new Size(176, 28);
            cmbAvailability.TabIndex = 8;
            cmbAvailability.Text = "Availibility";
            // 
            // cmbCondition
            // 
            cmbCondition.ForeColor = Color.Black;
            cmbCondition.FormattingEnabled = true;
            cmbCondition.Location = new Point(230, 350);
            cmbCondition.Name = "cmbCondition";
            cmbCondition.Size = new Size(368, 28);
            cmbCondition.TabIndex = 9;
            cmbCondition.Text = "Condition";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(249, 115, 22);
            btnAdd.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(325, 404);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(172, 35);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblDivider
            // 
            lblDivider.BackColor = Color.FromArgb(236, 236, 236);
            lblDivider.Location = new Point(-5, 80);
            lblDivider.Margin = new Padding(2, 0, 2, 0);
            lblDivider.Name = "lblDivider";
            lblDivider.Size = new Size(858, 1);
            lblDivider.TabIndex = 63;
            // 
            // AddEquipment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(852, 524);
            Controls.Add(lblDivider);
            Controls.Add(btnAdd);
            Controls.Add(cmbCondition);
            Controls.Add(cmbAvailability);
            Controls.Add(cmbCategory);
            Controls.Add(txtPrice);
            Controls.Add(txtDescription);
            Controls.Add(txtName);
            Controls.Add(lblAddEquipment);
            Controls.Add(btnBack);
            Controls.Add(flowLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddEquipment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddEquipment";
            Load += AddEquipment_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label lblUserName;
        private Label lblPosition;
        private Button btnBack;
        private Label lblAddEquipment;
        private TextBox txtName;
        private TextBox txtDescription;
        private TextBox txtPrice;
        private ComboBox cmbCategory;
        private ComboBox cmbAvailability;
        private ComboBox cmbCondition;
        private Button btnAdd;
        private Label lblDivider;
    }
}