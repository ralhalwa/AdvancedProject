namespace FormApp.Forms
{
    partial class EditEquipment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditEquipment));
            btnSaveChanges = new Button();
            cmbCondition = new ComboBox();
            cmbAvailability = new ComboBox();
            cmbCategory = new ComboBox();
            txtPrice = new TextBox();
            txtDescription = new TextBox();
            txtName = new TextBox();
            lblAddEquipment = new Label();
            btnBack = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            lblUserName = new Label();
            lblPosition = new Label();
            txtEquipmentID = new TextBox();
            lblDivider = new Label();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.BackColor = Color.FromArgb(249, 115, 22);
            btnSaveChanges.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnSaveChanges.ForeColor = Color.White;
            btnSaveChanges.Location = new Point(328, 404);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(172, 35);
            btnSaveChanges.TabIndex = 20;
            btnSaveChanges.Text = "Save Changes";
            btnSaveChanges.UseVisualStyleBackColor = false;
            btnSaveChanges.Click += btnSaveChanges_Click;
            // 
            // cmbCondition
            // 
            cmbCondition.ForeColor = Color.Black;
            cmbCondition.FormattingEnabled = true;
            cmbCondition.Location = new Point(425, 350);
            cmbCondition.Name = "cmbCondition";
            cmbCondition.Size = new Size(176, 28);
            cmbCondition.TabIndex = 19;
            cmbCondition.Text = "Condition";
            // 
            // cmbAvailability
            // 
            cmbAvailability.ForeColor = Color.Black;
            cmbAvailability.FormattingEnabled = true;
            cmbAvailability.Location = new Point(233, 350);
            cmbAvailability.Name = "cmbAvailability";
            cmbAvailability.Size = new Size(176, 28);
            cmbAvailability.TabIndex = 18;
            cmbAvailability.Text = "Availibility";
            // 
            // cmbCategory
            // 
            cmbCategory.ForeColor = Color.Black;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(233, 301);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(176, 28);
            cmbCategory.TabIndex = 17;
            cmbCategory.Text = "Category";
            // 
            // txtPrice
            // 
            txtPrice.ForeColor = SystemColors.ScrollBar;
            txtPrice.Location = new Point(425, 301);
            txtPrice.Name = "txtPrice";
            txtPrice.PlaceholderText = "Price";
            txtPrice.Size = new Size(176, 27);
            txtPrice.TabIndex = 16;
            txtPrice.Text = "Price";
            // 
            // txtDescription
            // 
            txtDescription.ForeColor = SystemColors.ScrollBar;
            txtDescription.Location = new Point(233, 244);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.PlaceholderText = "Description";
            txtDescription.Size = new Size(368, 27);
            txtDescription.TabIndex = 15;
            txtDescription.Text = "Description";
            // 
            // txtName
            // 
            txtName.ForeColor = SystemColors.ScrollBar;
            txtName.Location = new Point(425, 200);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Name";
            txtName.Size = new Size(176, 27);
            txtName.TabIndex = 14;
            // 
            // lblAddEquipment
            // 
            lblAddEquipment.AutoSize = true;
            lblAddEquipment.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            lblAddEquipment.Location = new Point(291, 129);
            lblAddEquipment.Name = "lblAddEquipment";
            lblAddEquipment.Size = new Size(219, 38);
            lblAddEquipment.TabIndex = 13;
            lblAddEquipment.Text = "Edit Equipment";
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
            // txtEquipmentID
            // 
            txtEquipmentID.Location = new Point(233, 200);
            txtEquipmentID.Name = "txtEquipmentID";
            txtEquipmentID.Size = new Size(176, 27);
            txtEquipmentID.TabIndex = 21;
            // 
            // lblDivider
            // 
            lblDivider.BackColor = Color.FromArgb(236, 236, 236);
            lblDivider.Location = new Point(-5, 80);
            lblDivider.Margin = new Padding(2, 0, 2, 0);
            lblDivider.Name = "lblDivider";
            lblDivider.Size = new Size(858, 1);
            lblDivider.TabIndex = 66;
            // 
            // EditEquipment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(852, 524);
            Controls.Add(lblDivider);
            Controls.Add(txtEquipmentID);
            Controls.Add(btnSaveChanges);
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
            Name = "EditEquipment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditEquipment";
            Load += EditEquipment_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSaveChanges;
        private ComboBox cmbCondition;
        private ComboBox cmbAvailability;
        private ComboBox cmbCategory;
        private TextBox txtPrice;
        private TextBox txtDescription;
        private TextBox txtName;
        private Label lblAddEquipment;
        private Button btnBack;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label lblUserName;
        private Label lblPosition;
        private TextBox txtEquipmentID;
        private Label lblDivider;
    }
}