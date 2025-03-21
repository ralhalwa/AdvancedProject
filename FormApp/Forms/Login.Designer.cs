namespace FormApp.Forms
{
    partial class Login
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
            pictureBox1 = new PictureBox();
            txtEmail = new TextBox();
            lblTitle = new Label();
            txtPassword = new TextBox();
            btnSignIn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo;
            pictureBox1.Location = new Point(150, 130);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(418, 465);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.WhiteSmoke;
            txtEmail.Location = new Point(617, 314);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(447, 39);
            txtEmail.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(617, 225);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(185, 65);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Sign In";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.WhiteSmoke;
            txtPassword.Location = new Point(617, 377);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(447, 39);
            txtPassword.TabIndex = 3;
            // 
            // btnSignIn
            // 
            btnSignIn.BackColor = Color.FromArgb(249, 115, 22);
            btnSignIn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignIn.ForeColor = Color.White;
            btnSignIn.Location = new Point(617, 445);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(447, 56);
            btnSignIn.TabIndex = 4;
            btnSignIn.Text = "Sign In";
            btnSignIn.UseVisualStyleBackColor = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1230, 738);
            Controls.Add(btnSignIn);
            Controls.Add(txtPassword);
            Controls.Add(lblTitle);
            Controls.Add(txtEmail);
            Controls.Add(pictureBox1);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txtEmail;
        private Label lblTitle;
        private TextBox txtPassword;
        private Button btnSignIn;
    }
}