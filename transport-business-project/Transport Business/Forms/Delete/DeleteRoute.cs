using System;
using System.ComponentModel;
using System.Windows.Forms;
using transport_business_project.Classes;

namespace transport_business_project.Transport_Business.Forms.Delete
{
    public partial class DeleteRoute : Form
    {
        public DeleteRoute()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                // Delete logic here
                int routeID = int.Parse(txtRouteID.Text);

                // Assuming you have a method to delete the route by Id in your data access layer
                bool result = DeleteRouteById(routeID);
                if (result)
                {
                    MessageBox.Show("Route deleted successfully!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Route not found!");
                }
            }
        }

        private bool DeleteRouteById(int routeID)
        {
            // Implement the logic to delete the route from the database or collection
            // Return true if successful, false otherwise
            return true; // Placeholder
        }

        private void txtRouteID_Validating(object sender, CancelEventArgs e)
        {
            if (!int.TryParse(txtRouteID.Text, out int routeID) || routeID <= 0)
            {
                e.Cancel = true;
                errorProvider.SetError(txtRouteID, "Please enter a valid Route ID.");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtRouteID, null);
            }
        }
    }
}
