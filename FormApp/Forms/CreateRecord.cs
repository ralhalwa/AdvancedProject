using ClassLibrary.Models;
using ClassLibrary.Persistence;
using FormApp.Classes;
using Microsoft.EntityFrameworkCore;
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
    public partial class CreateRecord : Form
    {

        DBContext context;
        public CreateRecord()
        {
            InitializeComponent();
            context = new DBContext();
        }

        private void CreateRecord_Load(object sender, EventArgs e)
        {
            LoadConditions();
        }

        private void LoadConditions()
        {
            cmbCondition.DataSource = context.ConditionStatuses.ToList();
            cmbCondition.DisplayMember = "Status";
            cmbCondition.ValueMember = "Id";
            cmbCondition.SelectedItem = null;
        }


        //private void btnCreate_Click(object sender, EventArgs e)
        //{


        //}

        private void ClearControls()
        {
            txtEquipmentId.Text = "";
            cmbCondition.SelectedIndex = -1;
            txtLateFees.Text = "";
            dtpReturnDate.Value = DateTime.Today;
        }

        private void btnCreate_Click_1(object sender, EventArgs e)
        {

            try
            {
                // Validate Empty Inputs
                if (string.IsNullOrWhiteSpace(txtEquipmentId.Text) ||
                    cmbCondition.SelectedItem == null ||
                    string.IsNullOrWhiteSpace(txtLateFees.Text))
                {
                    MessageBox.Show("Please fill all fields!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validate Equipment ID is Numeric
                if (!int.TryParse(txtEquipmentId.Text, out int equipmentId))
                {
                    MessageBox.Show("Invalid Equipment ID!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validate Late Fees is Numeric
                if (!decimal.TryParse(txtLateFees.Text, out decimal lateFees))
                {
                    MessageBox.Show("Invalid Late Fees!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validate Return Date is Today or Future
                if (dtpReturnDate.Value.Date < DateTime.Today)
                {
                    MessageBox.Show("Return Date cannot be before today's date!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Check if Equipment Exists
                bool exists = context.Equipment.Any(e => e.Id == equipmentId);
                if (!exists)
                {
                    MessageBox.Show("Equipment ID not found in database!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Create Return Record
                ReturnRecord record = new ReturnRecord
                {
                    Equipment = equipmentId,
                    Condition = Convert.ToInt32(cmbCondition.SelectedValue),
                    ReturnDate = dtpReturnDate.Value,
                    LateFees = lateFees
                };

                // Insert into DB
                context.ReturnRecords.Add(record);
                context.SaveChanges();

                // Log the action
                Log log = new Log
                {
                    UserId = UserSession.UserID,
                    Action = "Create Return Record",
                    TimeStamp = DateTime.Now,
                    AffectedData = $"Return Record for Equipment ID: {record.Equipment}, Return Date: {record.ReturnDate.ToShortDateString()}",
                    Source = "CreateRecord Form"
                };
                context.Logs.Add(log);
                context.SaveChanges(); // Save log entry

                MessageBox.Show("Record created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearControls();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormHelper.NavigateTo<ReturnRecords>(this);
        }
    }
}
