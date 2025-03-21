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
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            button2 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 70);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(12, 37);
            label2.Name = "label2";
            label2.Size = new Size(51, 14);
            label2.TabIndex = 1;
            label2.Text = "Manager";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(114, 19);
            label1.TabIndex = 0;
            label1.Text = "Ahmed Awadhi";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(249, 115, 22);
            button1.ForeColor = Color.White;
            button1.Location = new Point(12, 76);
            button1.Name = "button1";
            button1.Size = new Size(81, 33);
            button1.TabIndex = 1;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(310, 140);
            label3.Name = "label3";
            label3.Size = new Size(186, 33);
            label3.TabIndex = 2;
            label3.Text = "Add Equipment";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(219, 219, 219);
            textBox1.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.FromArgb(64, 64, 64);
            textBox1.Location = new Point(245, 198);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 22);
            textBox1.TabIndex = 3;
            textBox1.Text = "Name";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(219, 219, 219);
            textBox2.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.ForeColor = Color.FromArgb(64, 64, 64);
            textBox2.Location = new Point(245, 225);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(310, 22);
            textBox2.TabIndex = 4;
            textBox2.Text = "Description";
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(219, 219, 219);
            textBox3.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.ForeColor = Color.FromArgb(64, 64, 64);
            textBox3.Location = new Point(245, 253);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 22);
            textBox3.TabIndex = 5;
            textBox3.Text = "Price";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(219, 219, 219);
            comboBox1.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.ForeColor = Color.FromArgb(64, 64, 64);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(405, 197);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(150, 22);
            comboBox1.TabIndex = 6;
            comboBox1.Text = "Category";
            // 
            // comboBox2
            // 
            comboBox2.BackColor = Color.FromArgb(219, 219, 219);
            comboBox2.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox2.ForeColor = Color.FromArgb(64, 64, 64);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(405, 253);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(150, 22);
            comboBox2.TabIndex = 7;
            comboBox2.Text = "Availability";
            // 
            // comboBox3
            // 
            comboBox3.BackColor = Color.FromArgb(219, 219, 219);
            comboBox3.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox3.ForeColor = Color.FromArgb(64, 64, 64);
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(245, 281);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(310, 22);
            comboBox3.TabIndex = 8;
            comboBox3.Text = "Condition";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(249, 115, 22);
            button2.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(325, 309);
            button2.Name = "button2";
            button2.Size = new Size(150, 33);
            button2.TabIndex = 9;
            button2.Text = "Add";
            button2.UseVisualStyleBackColor = false;
            // 
            // AddEquipment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(panel1);
            Name = "AddEquipment";
            Text = "AddEquipment";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Button button1;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private Button button2;
    }
}