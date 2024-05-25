using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using transport_business_project.Classes;
using transport_business_project.Utilities;

namespace transport_business_project.Transport_Business.Forms.Add
{
    public partial class AddRoute : Form
    {
        private const string FilePath = "routes.xml";

        public AddRoute()
        {
            InitializeComponent();
        }

        private void AddRoute_Load(object sender, EventArgs e)
        {
            // Initialization code if needed
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                // Save logic here
                int routeID = new Random().Next(1000);
                string startLocation = txtStartLocation.Text;
                string endLocation = txtEndLocation.Text;
                float distance = float.Parse(txtDistance.Text);
                float estimatedTime = float.Parse(txtEstimatedTime.Text);

                Route newRoute = new Route(routeID, startLocation, endLocation, distance, estimatedTime);
                List<Route> routes;

                if (File.Exists(FilePath))
                {
                    routes = SerializationUtility.DeserializeFromFile<List<Route>>(FilePath);
                }
                else
                {
                    routes = new List<Route>();
                }

                routes.Add(newRoute);
                SerializationUtility.SerializeToFile(routes, FilePath);

                MessageBox.Show("Route added successfully!");
                this.Close();
            }
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

        private void txtStartLocation_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStartLocation.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtStartLocation, "Start Location cannot be empty.");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtStartLocation, null);
            }
        }

        private void txtEndLocation_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEndLocation.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtEndLocation, "End Location cannot be empty.");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtEndLocation, null);
            }
        }

        private void txtDistance_Validating(object sender, CancelEventArgs e)
        {
            if (!float.TryParse(txtDistance.Text, out float distance) || distance <= 0)
            {
                e.Cancel = true;
                errorProvider.SetError(txtDistance, "Please enter a valid Distance.");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtDistance, null);
            }
        }

        private void txtEstimatedTime_Validating(object sender, CancelEventArgs e)
        {
            if (!float.TryParse(txtEstimatedTime.Text, out float estimatedTime) || estimatedTime <= 0)
            {
                e.Cancel = true;
                errorProvider.SetError(txtEstimatedTime, "Please enter a valid Estimated Time.");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtEstimatedTime, null);
            }
        }
    }
}
