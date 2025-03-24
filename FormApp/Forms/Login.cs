using FormApp.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary.Persistence;
using BCrypt.Net;

namespace FormApp.Forms
{
    public partial class Login : Form
    {
        private readonly DBContext _context; // instantiate DBContext
        public Login()
        {
            InitializeComponent();
            _context = new DBContext();

            // apply placeholders to email and password fields
            PlaceholderService.SetPlaceholder(txtEmail, "Email");
            PlaceholderService.SetPlaceholder(txtPassword, "Password");

            // centering the form
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            // check if user exists
            var user = _context.Users.FirstOrDefault(u => u.Email.ToLower() == email.ToLower() && u.Password == password);

            if (user != null)
            {
                // store session data
                UserSession.UserID = user.Id;
                UserSession.FullName = $"{user.Fname} {user.Lname}";
                UserSession.Email = user.Email;
                UserSession.RoleID = user.RoleId;

                // display successful login message
                MessageBox.Show($"Welcome {UserSession.FullName}!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // open dashboard and close login form
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
                this.Hide();
            }
            else
            {
                // display unsuccessful login message
                MessageBox.Show("Invalid email or password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
