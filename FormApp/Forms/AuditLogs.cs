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
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using ClassLibrary.Persistence;

namespace FormApp.Forms
{
    public partial class AuditLogs : Form
    {
        private readonly DBContext _context;

        public AuditLogs()
        {
            InitializeComponent();

            // instantiate DBContext
            _context = new DBContext();

            // apply placeholder to the search bar
            PlaceholderService.SetPlaceholder(txtSearchBar, "Log ID");

            // displaying user info
            lblName.Text = UserSession.FullName;

            if (UserSession.RoleID == 1)
            {
                lblRole.Text = "Admin";
            }

            else if (UserSession.RoleID == 2)
            {
                lblRole.Text = "Manager";
            }

            // centering the form
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void AuditLogs_Load(object sender, EventArgs e)
        {
            LoadLogs(); // load all logs on form load
        }

        // load the grid view and filter logs by id
        private void LoadLogs(string searchId = "")
        {
            var logsQuery = _context.Logs.AsQueryable();

            if (!string.IsNullOrWhiteSpace(searchId) && int.TryParse(searchId, out int id))
            {
                logsQuery = logsQuery.Where(log => log.Id == id);
            }

            var logList = logsQuery
                .Select(log => new
                {
                    log.Id,
                    log.UserId,
                    log.Action,
                    log.TimeStamp,
                    log.AffectedData,
                    log.Source
                })
                .ToList();

            gridLogs.DataSource = logList;
        }

        // search button click event
        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadLogs(txtSearchBar.Text.Trim());
        }
    }
}
