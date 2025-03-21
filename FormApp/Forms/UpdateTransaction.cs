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
    public partial class UpdateTransaction : Form
    {
        public UpdateTransaction()
        {
            InitializeComponent();

            // setting placeholders
            PlaceholderService.SetPlaceholder(txtUserID, "User ID");
            PlaceholderService.SetPlaceholder(txtPickupDate, "Pickup Date");
            PlaceholderService.SetPlaceholder(txtReturnDate, "Return Date");
            PlaceholderService.SetPlaceholder(txtPeriod, "Period");
            PlaceholderService.SetPlaceholder(txtFee, "Fee");
            PlaceholderService.SetPlaceholder(txtDeposit, "Deposit");
        }

        private void UpdateTransaction_Load(object sender, EventArgs e)
        {

        }
    }
}
