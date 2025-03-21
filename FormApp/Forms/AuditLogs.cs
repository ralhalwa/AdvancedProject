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
    public partial class AuditLogs : Form
    {
        public AuditLogs()
        {
            InitializeComponent();

            // apply placeholder to the search bar
            PlaceholderService.SetPlaceholder(txtSearchBar, "Log ID");

            // centering the form
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void AuditLogs_Load(object sender, EventArgs e)
        {

        }
    }
}
