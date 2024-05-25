using System;
using System.Windows.Forms;

namespace transport_business_project.Transport_Business.Forms.Add
{
    partial class AddRoute
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblRouteID;
        private TextBox txtRouteID;
        private Label lblStartLocation;
        private TextBox txtStartLocation;
        private Label lblEndLocation;
        private TextBox txtEndLocation;
        private Label lblDistance;
        private TextBox txtDistance;
        private Label lblEstimatedTime;
        private TextBox txtEstimatedTime;
        private Button btnSave;
        private ErrorProvider errorProvider;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblRouteID = new Label();
            this.txtRouteID = new TextBox();
            this.lblStartLocation = new Label();
            this.txtStartLocation = new TextBox();
            this.lblEndLocation = new Label();
            this.txtEndLocation = new TextBox();
            this.lblDistance = new Label();
            this.txtDistance = new TextBox();
            this.lblEstimatedTime = new Label();
            this.txtEstimatedTime = new TextBox();
            this.btnSave = new Button();
            this.errorProvider = new ErrorProvider(this.components);

            this.SuspendLayout();

            // 
            // lblRouteID
            // 
            this.lblRouteID.AutoSize = true;
            this.lblRouteID.Location = new System.Drawing.Point(13, 13);
            this.lblRouteID.Name = "lblRouteID";
            this.lblRouteID.Size = new System.Drawing.Size(52, 13);
            this.lblRouteID.TabIndex = 0;
            this.lblRouteID.Text = "Route ID:";

            // 
            // txtRouteID
            // 
            this.txtRouteID.Location = new System.Drawing.Point(150, 10);
            this.txtRouteID.Name = "txtRouteID";
            this.txtRouteID.Size = new System.Drawing.Size(200, 20);
            this.txtRouteID.TabIndex = 1;
            this.txtRouteID.Validating += new System.ComponentModel.CancelEventHandler(this.txtRouteID_Validating);

            // 
            // lblStartLocation
            // 
            this.lblStartLocation.AutoSize = true;
            this.lblStartLocation.Location = new System.Drawing.Point(13, 39);
            this.lblStartLocation.Name = "lblStartLocation";
            this.lblStartLocation.Size = new System.Drawing.Size(76, 13);
            this.lblStartLocation.TabIndex = 2;
            this.lblStartLocation.Text = "Start Location:";

            // 
            // txtStartLocation
            // 
            this.txtStartLocation.Location = new System.Drawing.Point(150, 36);
            this.txtStartLocation.Name = "txtStartLocation";
            this.txtStartLocation.Size = new System.Drawing.Size(200, 20);
            this.txtStartLocation.TabIndex = 3;
            this.txtStartLocation.Validating += new System.ComponentModel.CancelEventHandler(this.txtStartLocation_Validating);

            // 
            // lblEndLocation
            // 
            this.lblEndLocation.AutoSize = true;
            this.lblEndLocation.Location = new System.Drawing.Point(13, 65);
            this.lblEndLocation.Name = "lblEndLocation";
            this.lblEndLocation.Size = new System.Drawing.Size(73, 13);
            this.lblEndLocation.TabIndex = 4;
            this.lblEndLocation.Text = "End Location:";

            // 
            // txtEndLocation
            // 
            this.txtEndLocation.Location = new System.Drawing.Point(150, 62);
            this.txtEndLocation.Name = "txtEndLocation";
            this.txtEndLocation.Size = new System.Drawing.Size(200, 20);
            this.txtEndLocation.TabIndex = 5;
            this.txtEndLocation.Validating += new System.ComponentModel.CancelEventHandler(this.txtEndLocation_Validating);

            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.Location = new System.Drawing.Point(13, 91);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(52, 13);
            this.lblDistance.TabIndex = 6;
            this.lblDistance.Text = "Distance:";

            // 
            // txtDistance
            // 
            this.txtDistance.Location = new System.Drawing.Point(150, 88);
            this.txtDistance.Name = "txtDistance";
            this.txtDistance.Size = new System.Drawing.Size(100, 20);
            this.txtDistance.TabIndex = 7;
            this.txtDistance.Validating += new System.ComponentModel.CancelEventHandler(this.txtDistance_Validating);

            // 
            // lblEstimatedTime
            // 
            this.lblEstimatedTime.AutoSize = true;
            this.lblEstimatedTime.Location = new System.Drawing.Point(13, 117);
            this.lblEstimatedTime.Name = "lblEstimatedTime";
            this.lblEstimatedTime.Size = new System.Drawing.Size(82, 13);
            this.lblEstimatedTime.TabIndex = 8;
            this.lblEstimatedTime.Text = "Estimated Time:";

            // 
            // txtEstimatedTime
            // 
            this.txtEstimatedTime.Location = new System.Drawing.Point(150, 114);
            this.txtEstimatedTime.Name = "txtEstimatedTime";
            this.txtEstimatedTime.Size = new System.Drawing.Size(100, 20);
            this.txtEstimatedTime.TabIndex = 9;
            this.txtEstimatedTime.Validating += new System.ComponentModel.CancelEventHandler(this.txtEstimatedTime_Validating);

            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(150, 140);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;

            // 
            // AddRoute
            // 
            this.ClientSize = new System.Drawing.Size(370, 180);
            this.Controls.Add(this.lblRouteID);
            this.Controls.Add(this.txtRouteID);
            this.Controls.Add(this.lblStartLocation);
            this.Controls.Add(this.txtStartLocation);
            this.Controls.Add(this.lblEndLocation);
            this.Controls.Add(this.txtEndLocation);
            this.Controls.Add(this.lblDistance);
            this.Controls.Add(this.txtDistance);
            this.Controls.Add(this.lblEstimatedTime);
            this.Controls.Add(this.txtEstimatedTime);
            this.Controls.Add(this.btnSave);
            this.Name = "AddRoute";
            this.Text = "Add Route";
            this.Load += new System.EventHandler(this.AddRoute_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
