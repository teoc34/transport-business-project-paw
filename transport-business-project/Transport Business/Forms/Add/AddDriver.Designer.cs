using System;
using System.Windows.Forms;

namespace transport_business_project.Transport_Business.Forms.Add
{
    partial class AddDriver
    {
        private System.ComponentModel.IContainer components = null;
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
        private Button btnSave;
        private ErrorProvider errorProvider;

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblName = new Label();
            txtName = new TextBox();
            lblLicenseNumber = new Label();
            txtLicenseNumber = new TextBox();
            lblYearsOfExperience = new Label();
            txtYearsOfExperience = new TextBox();
            lblMake = new Label();
            txtMake = new TextBox();
            lblPlateNumber = new Label();
            txtPlateNumber = new TextBox();
            btnSave = new Button();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(13, 13);
            lblName.Name = "lblName";
            lblName.Size = new Size(42, 15);
            lblName.TabIndex = 0;
            lblName.Text = "Name:";
            // 
            // txtName
            // 
            txtName.Location = new Point(100, 10);
            txtName.Name = "txtName";
            txtName.Size = new Size(200, 23);
            txtName.TabIndex = 1;
            // 
            // lblLicenseNumber
            // 
            lblLicenseNumber.AutoSize = true;
            lblLicenseNumber.Location = new Point(13, 39);
            lblLicenseNumber.Name = "lblLicenseNumber";
            lblLicenseNumber.Size = new Size(96, 15);
            lblLicenseNumber.TabIndex = 2;
            lblLicenseNumber.Text = "License Number:";
            // 
            // txtLicenseNumber
            // 
            txtLicenseNumber.Location = new Point(100, 36);
            txtLicenseNumber.Name = "txtLicenseNumber";
            txtLicenseNumber.Size = new Size(200, 23);
            txtLicenseNumber.TabIndex = 3;
            // 
            // lblYearsOfExperience
            // 
            lblYearsOfExperience.AutoSize = true;
            lblYearsOfExperience.Location = new Point(13, 65);
            lblYearsOfExperience.Name = "lblYearsOfExperience";
            lblYearsOfExperience.Size = new Size(111, 15);
            lblYearsOfExperience.TabIndex = 4;
            lblYearsOfExperience.Text = "Years of Experience:";
            // 
            // txtYearsOfExperience
            // 
            txtYearsOfExperience.Location = new Point(100, 62);
            txtYearsOfExperience.Name = "txtYearsOfExperience";
            txtYearsOfExperience.Size = new Size(50, 23);
            txtYearsOfExperience.TabIndex = 5;
            // 
            // lblMake
            // 
            lblMake.AutoSize = true;
            lblMake.Location = new Point(13, 91);
            lblMake.Name = "lblMake";
            lblMake.Size = new Size(39, 15);
            lblMake.TabIndex = 6;
            lblMake.Text = "Make:";
            // 
            // txtMake
            // 
            txtMake.Location = new Point(100, 88);
            txtMake.Name = "txtMake";
            txtMake.Size = new Size(200, 23);
            txtMake.TabIndex = 7;
            // 
            // lblPlateNumber
            // 
            lblPlateNumber.AutoSize = true;
            lblPlateNumber.Location = new Point(13, 117);
            lblPlateNumber.Name = "lblPlateNumber";
            lblPlateNumber.Size = new Size(83, 15);
            lblPlateNumber.TabIndex = 8;
            lblPlateNumber.Text = "Plate Number:";
            // 
            // txtPlateNumber
            // 
            txtPlateNumber.Location = new Point(100, 114);
            txtPlateNumber.Name = "txtPlateNumber";
            txtPlateNumber.Size = new Size(200, 23);
            txtPlateNumber.TabIndex = 9;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(100, 140);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // AddDriver
            // 
            ClientSize = new Size(320, 180);
            Controls.Add(lblName);
            Controls.Add(txtName);
            Controls.Add(lblLicenseNumber);
            Controls.Add(txtLicenseNumber);
            Controls.Add(lblYearsOfExperience);
            Controls.Add(txtYearsOfExperience);
            Controls.Add(lblMake);
            Controls.Add(txtMake);
            Controls.Add(lblPlateNumber);
            Controls.Add(txtPlateNumber);
            Controls.Add(btnSave);
            Name = "AddDriver";
            Text = "Add Driver";
            Load += AddDriver_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
