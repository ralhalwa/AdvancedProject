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
using FormApp.Classes;

namespace FormApp.Forms
{
    public partial class AddEquipment : Form
    {
        DBContext context;
        public AddEquipment()
        {
            InitializeComponent();
            context = new DBContext();

            lblUserName.Text = UserSession.FullName;

            RoleHelper.ApplyRolePermissions(
            UserSession.RoleID,
            lblPosition
            );
        }

        private void AddEquipment_Load(object sender, EventArgs e)
        {
            LoadCategories();
            LoadAvailability();
            LoadCondition();
        }

        private void LoadCategories()
        {
            cmbCategory.DataSource = context.Categories.ToList();
            cmbCategory.DisplayMember = "Name";
            cmbCategory.ValueMember = "Id";
            cmbCategory.SelectedItem = null;
        }

        private void LoadCondition()
        {
            cmbCondition.DataSource = context.ConditionStatuses.ToList();
            cmbCondition.DisplayMember = "Status";
            cmbCondition.ValueMember = "Id";
            cmbCondition.SelectedItem = null;
        }

        private void LoadAvailability()
        {
            cmbAvailability.DataSource = context.AvailableStatuses.ToList();
            cmbAvailability.DisplayMember = "Status";
            cmbAvailability.ValueMember = "Id";
            cmbAvailability.SelectedItem = null;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            try
            {
                // Validating Required Fields
                if (string.IsNullOrWhiteSpace(txtName.Text) ||
                    string.IsNullOrWhiteSpace(txtDescription.Text) ||
                    string.IsNullOrWhiteSpace(txtPrice.Text) ||
                    cmbCategory.SelectedItem == null ||
                    cmbAvailability.SelectedItem == null ||
                    cmbCondition.SelectedItem == null)
                {
                    MessageBox.Show("Please fill all fields!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validate Price
                if (!decimal.TryParse(txtPrice.Text, out decimal price))
                {
                    MessageBox.Show("Invalid Price entered!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Create Equipment Object
                Equipment newEquipment = new Equipment
                {
                    Name = txtName.Text.Trim(),
                    Description = txtDescription.Text.Trim(),
                    Price = price,
                    CategoryId = Convert.ToInt32(cmbCategory.SelectedValue),
                    AvailableId = Convert.ToInt32(cmbAvailability.SelectedValue),
                    ConditionId = Convert.ToInt32(cmbCondition.SelectedValue),
                    Image = new byte[0] // Optional
                };

                // Add to Database
                context.Equipment.Add(newEquipment);
                context.SaveChanges();

                // logging equipment addition
                Log log = new Log
                {
                    UserId = UserSession.UserID,
                    Action = "Add Equipment",
                    TimeStamp = DateTime.Now,
                    AffectedData = $"Equipment Added: {newEquipment.Name}, ID: {newEquipment.Id}",
                    Source = "AddEquipment Form"
                };

                context.Logs.Add(log);
                context.SaveChanges(); // save log entry

                MessageBox.Show("Equipment Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearControls(); // reset fields
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearControls()
        {
            txtName.Text = "";
            txtDescription.Text = "";
            txtPrice.Text = "";
            cmbCategory.SelectedIndex = -1;
            cmbAvailability.SelectedIndex = -1;
            cmbCondition.SelectedIndex = -1;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormHelper.NavigateTo<EquipmentManagement>(this);
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
