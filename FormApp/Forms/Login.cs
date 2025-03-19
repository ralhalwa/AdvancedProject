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

namespace FormApp.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            // apply placeholders to email and password fields
            PlaceholderService.SetPlaceholder(txtEmail, "Email");
            PlaceholderService.SetPlaceholder(txtPassword, "Password");
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
