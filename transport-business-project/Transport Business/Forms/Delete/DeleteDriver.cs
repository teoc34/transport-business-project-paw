using System;
using System.ComponentModel;
using System.Windows.Forms;
using transport_business_project.Classes;

namespace transport_business_project.Transport_Business.Forms.Delete
{
    public partial class DeleteDriver : Form
    {
        public DeleteDriver()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                // Delete logic here
                int id = int.Parse(txtId.Text);

                // Assuming you have a method to delete the driver by Id in your data access layer
                bool result = DeleteDriverById(id);
                if (result)
                {
                    MessageBox.Show("Driver deleted successfully!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Driver not found!");
                }
            }
        }

        private bool DeleteDriverById(int id)
        {
            // Implement the logic to delete the driver from the database or collection
            // Return true if successful, false otherwise
            return true; // Placeholder
        }

        private void txtId_Validating(object sender, CancelEventArgs e)
        {
            if (!int.TryParse(txtId.Text, out int id) || id <= 0)
            {
                e.Cancel = true;
                errorProvider.SetError(txtId, "Please enter a valid Id.");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtId, null);
            }
        }
    }
}
