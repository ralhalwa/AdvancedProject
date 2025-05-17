using ClassLibrary.Models;
using ClassLibrary.Persistence;
using FormApp.Classes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;

namespace FormApp.Forms
{
    public partial class EditEquipment : Form
    {
        DBContext context;
        private Equipment selectedEquipment;

        // Constructor receives the selected Equipment object
        public EditEquipment(Equipment equipment)
        {
            InitializeComponent();
            context = new DBContext();
            selectedEquipment = equipment;

            // Display the logged-in user's name
            lblUserName.Text = UserSession.FullName;

            // Apply permissions based on user role
            RoleHelper.ApplyRolePermissions(
                UserSession.RoleID,
                lblPosition
            );
        }

        // Back button: navigate to Equipment Management form
        private void btnBack_Click(object sender, EventArgs e)
        {
            FormHelper.NavigateTo<EquipmentManagement>(this);
        }

        // Save Changes button: update equipment details in the database
        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                // Validation for empty fields
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

                // Validate price format
                if (!decimal.TryParse(txtPrice.Text, out decimal price))
                {
                    MessageBox.Show("Invalid Price entered!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Assign new values to the selected equipment object
                selectedEquipment.Name = txtName.Text.Trim();
                selectedEquipment.Description = txtDescription.Text.Trim();
                selectedEquipment.Price = price;
                selectedEquipment.CategoryId = Convert.ToInt32(cmbCategory.SelectedValue);
                selectedEquipment.AvailableId = Convert.ToInt32(cmbAvailability.SelectedValue);
                selectedEquipment.ConditionId = Convert.ToInt32(cmbCondition.SelectedValue);

                // Mark entity as modified and save changes
                context.Entry(selectedEquipment).State = EntityState.Modified;
                context.SaveChanges();

                // Log the edit action
                Log log = new Log
                {
                    UserId = UserSession.UserID,
                    Action = "Edit Equipment",
                    TimeStamp = DateTime.Now,
                    AffectedData = $"Edited Equipment: {selectedEquipment.Name}, ID: {selectedEquipment.Id}, New Price: {selectedEquipment.Price}",
                    Source = "EditEquipment Form"
                };

                context.Logs.Add(log);
                context.SaveChanges(); // Save log to database

                // Notify user of success
                MessageBox.Show("Equipment Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Close the edit form
            }
            catch (Exception ex)
            {
                // Show error message if something goes wrong
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // On form load: populate dropdowns and fill in existing equipment data
        private void EditEquipment_Load(object sender, EventArgs e)
        {
            LoadCategories();
            LoadAvailability();
            LoadCondition();
            LoadEquipmentData(); // Fill form fields with selected equipment data
        }

        // Load all categories from DB into ComboBox
        private void LoadCategories()
        {
            cmbCategory.DataSource = context.Categories.ToList();
            cmbCategory.DisplayMember = "Name";
            cmbCategory.ValueMember = "Id";
        }

        // Load availability statuses from DB
        private void LoadAvailability()
        {
            cmbAvailability.DataSource = context.AvailableStatuses.ToList();
            cmbAvailability.DisplayMember = "Status";
            cmbAvailability.ValueMember = "Id";
        }

        // Load condition statuses from DB
        private void LoadCondition()
        {
            cmbCondition.DataSource = context.ConditionStatuses.ToList();
            cmbCondition.DisplayMember = "Status";
            cmbCondition.ValueMember = "Id";
        }

        // Load existing equipment data into fields for editing
        private void LoadEquipmentData()
        {
            txtEquipmentID.Text = selectedEquipment.Id.ToString();
            txtName.Text = selectedEquipment.Name;
            txtDescription.Text = selectedEquipment.Description;
            txtPrice.Text = selectedEquipment.Price.ToString();
            cmbCategory.SelectedValue = selectedEquipment.CategoryId;
            cmbAvailability.SelectedValue = selectedEquipment.AvailableId;
            cmbCondition.SelectedValue = selectedEquipment.ConditionId;
        }
    }
}
