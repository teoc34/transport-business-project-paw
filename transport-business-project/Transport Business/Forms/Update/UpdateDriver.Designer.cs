namespace transport_business_project.Transport_Business.Forms.Update
{
    partial class UpdateDriver
    {
        private System.ComponentModel.IContainer components = null;

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
            comboBoxDrivers = new ComboBox();
            txtName = new TextBox();
            txtLicenseNumber = new TextBox();
            txtYearsOfExperience = new TextBox();
            txtMake = new TextBox();
            txtPlateNumber = new TextBox();
            btnSave = new Button();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // comboBoxDrivers
            // 
            comboBoxDrivers.FormattingEnabled = true;
            comboBoxDrivers.Location = new Point(12, 12);
            comboBoxDrivers.Name = "comboBoxDrivers";
            comboBoxDrivers.Size = new Size(260, 23);
            comboBoxDrivers.TabIndex = 0;
            comboBoxDrivers.SelectedIndexChanged += comboBoxDrivers_SelectedIndexChanged;
            // 
            // txtName
            // 
            txtName.Location = new Point(12, 39);
            txtName.Name = "txtName";
            txtName.Size = new Size(260, 23);
            txtName.TabIndex = 1;
            // 
            // txtLicenseNumber
            // 
            txtLicenseNumber.Location = new Point(12, 65);
            txtLicenseNumber.Name = "txtLicenseNumber";
            txtLicenseNumber.Size = new Size(260, 23);
            txtLicenseNumber.TabIndex = 2;
            // 
            // txtYearsOfExperience
            // 
            txtYearsOfExperience.Location = new Point(12, 91);
            txtYearsOfExperience.Name = "txtYearsOfExperience";
            txtYearsOfExperience.Size = new Size(260, 23);
            txtYearsOfExperience.TabIndex = 3;
            // 
            // txtMake
            // 
            txtMake.Location = new Point(12, 117);
            txtMake.Name = "txtMake";
            txtMake.Size = new Size(260, 23);
            txtMake.TabIndex = 4;
            // 
            // txtPlateNumber
            // 
            txtPlateNumber.Location = new Point(12, 143);
            txtPlateNumber.Name = "txtPlateNumber";
            txtPlateNumber.Size = new Size(260, 23);
            txtPlateNumber.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(12, 169);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // UpdateDriver
            // 
            ClientSize = new Size(284, 204);
            Controls.Add(btnSave);
            Controls.Add(txtPlateNumber);
            Controls.Add(txtMake);
            Controls.Add(txtYearsOfExperience);
            Controls.Add(txtLicenseNumber);
            Controls.Add(txtName);
            Controls.Add(comboBoxDrivers);
            Name = "UpdateDriver";
            Text = "Update Driver";
            Load += UpdateDriver_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private ComboBox comboBoxDrivers;
        private TextBox txtName;
        private TextBox txtLicenseNumber;
        private TextBox txtYearsOfExperience;
        private TextBox txtMake;
        private TextBox txtPlateNumber;
        private Button btnSave;
        private ErrorProvider errorProvider;
    }
}
