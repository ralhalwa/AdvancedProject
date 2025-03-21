namespace FormApp.Forms
{
    partial class CreateManager
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
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(114, 19);
            label1.TabIndex = 0;
            label1.Text = "Ahmed Awadhi";
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
            // button1
            // 
            button1.BackColor = Color.FromArgb(249, 115, 22);
            button1.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(12, 76);
            button1.Name = "button1";
            button1.Size = new Size(81, 33);
            button1.TabIndex = 1;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(270, 140);
            label3.Name = "label3";
            label3.Size = new Size(292, 33);
            label3.TabIndex = 2;
            label3.Text = "Create Manager Account";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(219, 219, 219);
            textBox1.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.FromArgb(64, 64, 64);
            textBox1.Location = new Point(245, 200);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 22);
            textBox1.TabIndex = 3;
            textBox1.Text = "First Name ";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(219, 219, 219);
            textBox2.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.ForeColor = Color.FromArgb(64, 64, 64);
            textBox2.Location = new Point(405, 200);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 22);
            textBox2.TabIndex = 4;
            textBox2.Text = "Last Name";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(219, 219, 219);
            textBox3.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.ForeColor = Color.FromArgb(64, 64, 64);
            textBox3.Location = new Point(245, 229);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(310, 22);
            textBox3.TabIndex = 5;
            textBox3.Text = "Email";
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(219, 219, 219);
            textBox4.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.ForeColor = Color.FromArgb(64, 64, 64);
            textBox4.Location = new Point(245, 258);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(310, 22);
            textBox4.TabIndex = 6;
            textBox4.Text = "Password";
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.FromArgb(219, 219, 219);
            textBox5.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox5.ForeColor = Color.FromArgb(64, 64, 64);
            textBox5.Location = new Point(245, 287);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(310, 22);
            textBox5.TabIndex = 7;
            textBox5.Text = "Confirm Password";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(249, 115, 22);
            button2.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(325, 316);
            button2.Name = "button2";
            button2.Size = new Size(150, 33);
            button2.TabIndex = 8;
            button2.Text = "Create";
            button2.UseVisualStyleBackColor = false;
            // 
            // CreateManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(panel1);
            Name = "CreateManager";
            Text = "CreateManager";
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
        private TextBox textBox4;
        private TextBox textBox5;
        private Button button2;
    }
}