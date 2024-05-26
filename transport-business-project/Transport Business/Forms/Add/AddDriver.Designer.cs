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
            lblName.Location = new Point(14, 17);
            lblName.Margin = new Padding(4, 0, 4, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(42, 15);
            lblName.TabIndex = 0;
            lblName.Text = "Name:";
            // 
            // txtName
            // 
            txtName.Location = new Point(18, 36);
            txtName.Margin = new Padding(4, 3, 4, 3);
            txtName.Name = "txtName";
            txtName.Size = new Size(299, 23);
            txtName.TabIndex = 1;
            txtName.Validating += txtName_Validating;
            // 
            // lblLicenseNumber
            // 
            lblLicenseNumber.AutoSize = true;
            lblLicenseNumber.Location = new Point(14, 74);
            lblLicenseNumber.Margin = new Padding(4, 0, 4, 0);
            lblLicenseNumber.Name = "lblLicenseNumber";
            lblLicenseNumber.Size = new Size(96, 15);
            lblLicenseNumber.TabIndex = 2;
            lblLicenseNumber.Text = "License Number:";
            // 
            // txtLicenseNumber
            // 
            txtLicenseNumber.Location = new Point(18, 92);
            txtLicenseNumber.Margin = new Padding(4, 3, 4, 3);
            txtLicenseNumber.Name = "txtLicenseNumber";
            txtLicenseNumber.Size = new Size(299, 23);
            txtLicenseNumber.TabIndex = 3;
            txtLicenseNumber.Validating += txtLicenseNumber_Validating;
            // 
            // lblYearsOfExperience
            // 
            lblYearsOfExperience.AutoSize = true;
            lblYearsOfExperience.Location = new Point(14, 130);
            lblYearsOfExperience.Margin = new Padding(4, 0, 4, 0);
            lblYearsOfExperience.Name = "lblYearsOfExperience";
            lblYearsOfExperience.Size = new Size(111, 15);
            lblYearsOfExperience.TabIndex = 4;
            lblYearsOfExperience.Text = "Years of Experience:";
            // 
            // txtYearsOfExperience
            // 
            txtYearsOfExperience.Location = new Point(18, 149);
            txtYearsOfExperience.Margin = new Padding(4, 3, 4, 3);
            txtYearsOfExperience.Name = "txtYearsOfExperience";
            txtYearsOfExperience.Size = new Size(299, 23);
            txtYearsOfExperience.TabIndex = 5;
            txtYearsOfExperience.Validating += txtYearsOfExperience_Validating;
            // 
            // lblMake
            // 
            lblMake.AutoSize = true;
            lblMake.Location = new Point(14, 187);
            lblMake.Margin = new Padding(4, 0, 4, 0);
            lblMake.Name = "lblMake";
            lblMake.Size = new Size(39, 15);
            lblMake.TabIndex = 6;
            lblMake.Text = "Make:";
            // 
            // txtMake
            // 
            txtMake.Location = new Point(18, 205);
            txtMake.Margin = new Padding(4, 3, 4, 3);
            txtMake.Name = "txtMake";
            txtMake.Size = new Size(299, 23);
            txtMake.TabIndex = 7;
            txtMake.Validating += txtMake_Validating;
            // 
            // lblPlateNumber
            // 
            lblPlateNumber.AutoSize = true;
            lblPlateNumber.Location = new Point(14, 243);
            lblPlateNumber.Margin = new Padding(4, 0, 4, 0);
            lblPlateNumber.Name = "lblPlateNumber";
            lblPlateNumber.Size = new Size(83, 15);
            lblPlateNumber.TabIndex = 8;
            lblPlateNumber.Text = "Plate Number:";
            // 
            // txtPlateNumber
            // 
            txtPlateNumber.Location = new Point(18, 262);
            txtPlateNumber.Margin = new Padding(4, 3, 4, 3);
            txtPlateNumber.Name = "txtPlateNumber";
            txtPlateNumber.Size = new Size(299, 23);
            txtPlateNumber.TabIndex = 9;
            txtPlateNumber.Validating += txtPlateNumber_Validating;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(230, 303);
            btnSave.Margin = new Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(88, 27);
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
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 344);
            Controls.Add(btnSave);
            Controls.Add(txtPlateNumber);
            Controls.Add(lblPlateNumber);
            Controls.Add(txtMake);
            Controls.Add(lblMake);
            Controls.Add(txtYearsOfExperience);
            Controls.Add(lblYearsOfExperience);
            Controls.Add(txtLicenseNumber);
            Controls.Add(lblLicenseNumber);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Margin = new Padding(4, 3, 4, 3);
            Name = "AddDriver";
            Text = "Add Driver";
            Load += AddDriver_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
