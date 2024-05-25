using System;
using System.Windows.Forms;

namespace transport_business_project.Transport_Business.Forms.Add
{
    partial class AddTransport
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTransportID;
        private TextBox txtTransportID;
        private Label lblMake;
        private TextBox txtMake;
        private Label lblMaintenanceDate;
        private DateTimePicker dtpMaintenanceDate;
        private Label lblLicensePlate;
        private TextBox txtLicensePlate;
        private Label lblTypes;
        private TextBox txtTypes;
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
            this.lblTransportID = new Label();
            this.txtTransportID = new TextBox();
            this.lblMake = new Label();
            this.txtMake = new TextBox();
            this.lblMaintenanceDate = new Label();
            this.dtpMaintenanceDate = new DateTimePicker();
            this.lblLicensePlate = new Label();
            this.txtLicensePlate = new TextBox();
            this.lblTypes = new Label();
            this.txtTypes = new TextBox();
            this.btnSave = new Button();
            this.errorProvider = new ErrorProvider(this.components);

            this.SuspendLayout();

            // 
            // lblTransportID
            // 
            this.lblTransportID.AutoSize = true;
            this.lblTransportID.Location = new System.Drawing.Point(13, 13);
            this.lblTransportID.Name = "lblTransportID";
            this.lblTransportID.Size = new System.Drawing.Size(70, 13);
            this.lblTransportID.TabIndex = 0;
            this.lblTransportID.Text = "Transport ID:";

            // 
            // txtTransportID
            // 
            this.txtTransportID.Location = new System.Drawing.Point(150, 10);
            this.txtTransportID.Name = "txtTransportID";
            this.txtTransportID.Size = new System.Drawing.Size(200, 20);
            this.txtTransportID.TabIndex = 1;
            this.txtTransportID.Validating += new System.ComponentModel.CancelEventHandler(this.txtTransportID_Validating);

            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.Location = new System.Drawing.Point(13, 39);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(37, 13);
            this.lblMake.TabIndex = 2;
            this.lblMake.Text = "Make:";

            // 
            // txtMake
            // 
            this.txtMake.Location = new System.Drawing.Point(150, 36);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(200, 20);
            this.txtMake.TabIndex = 3;
            this.txtMake.Validating += new System.ComponentModel.CancelEventHandler(this.txtMake_Validating);

            // 
            // lblMaintenanceDate
            // 
            this.lblMaintenanceDate.AutoSize = true;
            this.lblMaintenanceDate.Location = new System.Drawing.Point(13, 65);
            this.lblMaintenanceDate.Name = "lblMaintenanceDate";
            this.lblMaintenanceDate.Size = new System.Drawing.Size(97, 13);
            this.lblMaintenanceDate.TabIndex = 4;
            this.lblMaintenanceDate.Text = "Maintenance Date:";

            // 
            // dtpMaintenanceDate
            // 
            this.dtpMaintenanceDate.Location = new System.Drawing.Point(150, 62);
            this.dtpMaintenanceDate.Name = "dtpMaintenanceDate";
            this.dtpMaintenanceDate.Size = new System.Drawing.Size(200, 20);
            this.dtpMaintenanceDate.TabIndex = 5;

            // 
            // lblLicensePlate
            // 
            this.lblLicensePlate.AutoSize = true;
            this.lblLicensePlate.Location = new System.Drawing.Point(13, 91);
            this.lblLicensePlate.Name = "lblLicensePlate";
            this.lblLicensePlate.Size = new System.Drawing.Size(75, 13);
            this.lblLicensePlate.TabIndex = 6;
            this.lblLicensePlate.Text = "License Plate:";

            // 
            // txtLicensePlate
            // 
            this.txtLicensePlate.Location = new System.Drawing.Point(150, 88);
            this.txtLicensePlate.Name = "txtLicensePlate";
            this.txtLicensePlate.Size = new System.Drawing.Size(200, 20);
            this.txtLicensePlate.TabIndex = 7;
            this.txtLicensePlate.Validating += new System.ComponentModel.CancelEventHandler(this.txtLicensePlate_Validating);

            // 
            // lblTypes
            // 
            this.lblTypes.AutoSize = true;
            this.lblTypes.Location = new System.Drawing.Point(13, 117);
            this.lblTypes.Name = "lblTypes";
            this.lblTypes.Size = new System.Drawing.Size(39, 13);
            this.lblTypes.TabIndex = 8;
            this.lblTypes.Text = "Types:";

            // 
            // txtTypes
            // 
            this.txtTypes.Location = new System.Drawing.Point(150, 114);
            this.txtTypes.Name = "txtTypes";
            this.txtTypes.Size = new System.Drawing.Size(200, 20);
            this.txtTypes.TabIndex = 9;
            this.txtTypes.Validating += new System.ComponentModel.CancelEventHandler(this.txtTypes_Validating);

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
            // AddTransport
            // 
            this.ClientSize = new System.Drawing.Size(370, 180);
            this.Controls.Add(this.lblTransportID);
            this.Controls.Add(this.txtTransportID);
            this.Controls.Add(this.lblMake);
            this.Controls.Add(this.txtMake);
            this.Controls.Add(this.lblMaintenanceDate);
            this.Controls.Add(this.dtpMaintenanceDate);
            this.Controls.Add(this.lblLicensePlate);
            this.Controls.Add(this.txtLicensePlate);
            this.Controls.Add(this.lblTypes);
            this.Controls.Add(this.txtTypes);
            this.Controls.Add(this.btnSave);
            this.Name = "AddTransport";
            this.Text = "Add Transport";
            this.Load += new System.EventHandler(this.AddTransport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
