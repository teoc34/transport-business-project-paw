using System;
using System.Linq;
using System.Windows.Forms;
using transport_business_project.Classes;
using transport_business_project.Data;

namespace transport_business_project.Transport_Business.Forms.Add
{
    public partial class AddRoute : Form
    {
        private TransportContext _context;

        public AddRoute()
        {
            InitializeComponent();
            _context = new TransportContext();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                var route = new Route
                {
                    StartLocation = txtStartLocation.Text,
                    EndLocation = txtEndLocation.Text,
                    Distance = float.Parse(txtDistance.Text),
                    EstimatedTime = float.Parse(txtEstimatedTime.Text)
                };

                _context.Routes.Add(route);
                _context.SaveChanges();
                MessageBox.Show("Route added successfully.");
                this.Close();
            }
        }

        private void txtStartLocation_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStartLocation.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtStartLocation, "Start Location is required.");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtStartLocation, "");
            }
        }

        private void txtEndLocation_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEndLocation.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtEndLocation, "End Location is required.");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtEndLocation, "");
            }
        }

        private void txtDistance_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!float.TryParse(txtDistance.Text, out _))
            {
                e.Cancel = true;
                errorProvider.SetError(txtDistance, "Invalid number.");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtDistance, "");
            }
        }

        private void txtEstimatedTime_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!float.TryParse(txtEstimatedTime.Text, out _))
            {
                e.Cancel = true;
                errorProvider.SetError(txtEstimatedTime, "Invalid number.");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtEstimatedTime, "");
            }
        }

        private void AddRoute_Load(object sender, EventArgs e)
        {

        }
    }
}
