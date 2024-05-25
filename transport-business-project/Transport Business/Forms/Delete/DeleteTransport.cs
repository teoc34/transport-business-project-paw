using System;
using System.ComponentModel;
using System.Windows.Forms;
using transport_business_project.Classes;

namespace transport_business_project.Transport_Business.Forms.Delete
{
    public partial class DeleteTransport : Form
    {
        public DeleteTransport()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                // Delete logic here
                int transportID = int.Parse(txtTransportID.Text);

                // Assuming you have a method to delete the transport by Id in your data access layer
                bool result = DeleteTransportById(transportID);
                if (result)
                {
                    MessageBox.Show("Transport deleted successfully!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Transport not found!");
                }
            }
        }

        private bool DeleteTransportById(int transportID)
        {
            // Implement the logic to delete the transport from the database or collection
            // Return true if successful, false otherwise
            return true; // Placeholder
        }

        private void txtTransportID_Validating(object sender, CancelEventArgs e)
        {
            if (!int.TryParse(txtTransportID.Text, out int transportID) || transportID <= 0)
            {
                e.Cancel = true;
                errorProvider.SetError(txtTransportID, "Please enter a valid Transport ID.");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtTransportID, null);
            }
        }
    }
}
