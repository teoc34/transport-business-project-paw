using System;
using System.Windows.Forms;

namespace transport_business_project.Transport_Business.Forms.Update
{
    partial class UpdateDriver
    {
        private Label lblId;
        private TextBox txtId;
        private Label lblName;
        private TextBox txtName;
        private Label lblLicenseNumber;
        private TextBox txtLicenseNumber;
        private Label lblYearsOfExperience;
        private TextBox txtYearsOfExperience;
        private Label lblMake;
        private TextBox txtMake;
        private Label lblPlateNumber;
        private TextBox txtPlateNumber;
        private Button btnUpdate;
        private ErrorProvider errorProvider;

        private void InitializeComponent()
        {
            this.lblId = new Label();
            this.txtId = new TextBox();
            this.lblName = new Label();
            this.txtName = new TextBox();
            this.lblLicenseNumber = new Label();
            this.txtLicenseNumber = new TextBox();
            this.lblYearsOfExperience = new Label();
            this.txtYearsOfExperience = new TextBox();
            this.lblMake = new Label();
            this.txtMake = new TextBox();
            this.lblPlateNumber = new Label();
            this.txtPlateNumber = new TextBox();
            this.btnUpdate = new Button();
            this.errorProvider = new ErrorProvider();

            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(13, 13);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(19, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Id:";

            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(150, 10);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(200, 20);
            this.txtId.TabIndex = 1;
            this.txtId.Validating += new System.ComponentModel.CancelEventHandler(this.txtId_Validating);

            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(13, 39);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name:";

            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(150, 36);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 20);
            this.txtName.TabIndex = 3;
            this.txtName.Validating += new System.ComponentModel.CancelEventHandler(this.txtName_Validating);

            // 
            // lblLicenseNumber
            // 
            this.lblLicenseNumber.AutoSize = true;
            this.lblLicenseNumber.Location = new System.Drawing.Point(13, 65);
            this.lblLicenseNumber.Name = "lblLicenseNumber";
            this.lblLicenseNumber.Size = new System.Drawing.Size(85, 13);
            this.lblLicenseNumber.TabIndex = 4;
            this.lblLicenseNumber.Text = "License Number:";

            // 
            // txtLicenseNumber
            // 
            this.txtLicenseNumber.Location = new System.Drawing.Point(150, 62);
            this.txtLicenseNumber.Name = "txtLicenseNumber";
            this.txtLicenseNumber.Size = new System.Drawing.Size(200, 20);
            this.txtLicenseNumber.TabIndex = 5;
            this.txtLicenseNumber.Validating += new System.ComponentModel.CancelEventHandler(this.txtLicenseNumber_Validating);

            // 
            // lblYearsOfExperience
            // 
            this.lblYearsOfExperience.AutoSize = true;
            this.lblYearsOfExperience.Location = new System.Drawing.Point(13, 91);
            this.lblYearsOfExperience.Name = "lblYearsOfExperience";
            this.lblYearsOfExperience.Size = new System.Drawing.Size(108, 13);
            this.lblYearsOfExperience.TabIndex = 6;
            this.lblYearsOfExperience.Text = "Years of Experience:";

            // 
            // txtYearsOfExperience
            // 
            this.txtYearsOfExperience.Location = new System.Drawing.Point(150, 88);
            this.txtYearsOfExperience.Name = "txtYearsOfExperience";
            this.txtYearsOfExperience.Size = new System.Drawing.Size(50, 20);
            this.txtYearsOfExperience.TabIndex = 7;
            this.txtYearsOfExperience.Validating += new System.ComponentModel.CancelEventHandler(this.txtYearsOfExperience_Validating);

            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.Location = new System.Drawing.Point(13, 117);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(37, 13);
            this.lblMake.TabIndex = 8;
            this.lblMake.Text = "Make:";

            // 
            // txtMake
            // 
            this.txtMake.Location = new System.Drawing.Point(150, 114);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(200, 20);
            this.txtMake.TabIndex = 9;
            this.txtMake.Validating += new System.ComponentModel.CancelEventHandler(this.txtMake_Validating);

            // 
            // lblPlateNumber
            // 
            this.lblPlateNumber.AutoSize = true;
            this.lblPlateNumber.Location = new System.Drawing.Point(13, 143);
            this.lblPlateNumber.Name = "lblPlateNumber";
            this.lblPlateNumber.Size = new System.Drawing.Size(74, 13);
            this.lblPlateNumber.TabIndex = 10;
            this.lblPlateNumber.Text = "Plate Number:";

            // 
            // txtPlateNumber
            // 
            this.txtPlateNumber.Location = new System.Drawing.Point(150, 140);
            this.txtPlateNumber.Name = "txtPlateNumber";
            this.txtPlateNumber.Size = new System.Drawing.Size(200, 20);
            this.txtPlateNumber.TabIndex = 11;
            this.txtPlateNumber.Validating += new System.ComponentModel.CancelEventHandler(this.txtPlateNumber_Validating);

            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(150, 170);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;

            // 
            // UpdateDriver
            // 
            this.ClientSize = new System.Drawing.Size(370, 210);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblLicenseNumber);
            this.Controls.Add(this.txtLicenseNumber);
            this.Controls.Add(this.lblYearsOfExperience);
            this.Controls.Add(this.txtYearsOfExperience);
            this.Controls.Add(this.lblMake);
            this.Controls.Add(this.txtMake);
            this.Controls.Add(this.lblPlateNumber);
            this.Controls.Add(this.txtPlateNumber);
            this.Controls.Add(this.btnUpdate);
            this.Name = "UpdateDriver";
            this.Text = "Update Driver";
        }
    }
}
