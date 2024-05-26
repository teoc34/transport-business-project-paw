namespace transport_business_project.Transport_Business.Forms.Delete
{
    partial class DeleteDriver
    {
        private System.ComponentModel.IContainer components = null;
        private ComboBox comboBoxDrivers;
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
        private Button btnDelete;

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
            comboBoxDrivers = new ComboBox();
            lblId = new Label();
            txtId = new TextBox();
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
            btnDelete = new Button();
            SuspendLayout();
            // 
            // comboBoxDrivers
            // 
            comboBoxDrivers.FormattingEnabled = true;
            comboBoxDrivers.Location = new Point(14, 14);
            comboBoxDrivers.Margin = new Padding(4, 3, 4, 3);
            comboBoxDrivers.Name = "comboBoxDrivers";
            comboBoxDrivers.Size = new Size(303, 23);
            comboBoxDrivers.TabIndex = 0;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(14, 53);
            lblId.Margin = new Padding(4, 0, 4, 0);
            lblId.Name = "lblId";
            lblId.Size = new Size(20, 15);
            lblId.TabIndex = 1;
            lblId.Text = "Id:";
            // 
            // txtId
            // 
            txtId.Location = new Point(14, 72);
            txtId.Margin = new Padding(4, 3, 4, 3);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(303, 23);
            txtId.TabIndex = 2;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(14, 110);
            lblName.Margin = new Padding(4, 0, 4, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(42, 15);
            lblName.TabIndex = 3;
            lblName.Text = "Name:";
            // 
            // txtName
            // 
            txtName.Location = new Point(14, 128);
            txtName.Margin = new Padding(4, 3, 4, 3);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(303, 23);
            txtName.TabIndex = 4;
            // 
            // lblLicenseNumber
            // 
            lblLicenseNumber.AutoSize = true;
            lblLicenseNumber.Location = new Point(14, 166);
            lblLicenseNumber.Margin = new Padding(4, 0, 4, 0);
            lblLicenseNumber.Name = "lblLicenseNumber";
            lblLicenseNumber.Size = new Size(96, 15);
            lblLicenseNumber.TabIndex = 5;
            lblLicenseNumber.Text = "License Number:";
            // 
            // txtLicenseNumber
            // 
            txtLicenseNumber.Location = new Point(14, 185);
            txtLicenseNumber.Margin = new Padding(4, 3, 4, 3);
            txtLicenseNumber.Name = "txtLicenseNumber";
            txtLicenseNumber.ReadOnly = true;
            txtLicenseNumber.Size = new Size(303, 23);
            txtLicenseNumber.TabIndex = 6;
            // 
            // lblYearsOfExperience
            // 
            lblYearsOfExperience.AutoSize = true;
            lblYearsOfExperience.Location = new Point(14, 223);
            lblYearsOfExperience.Margin = new Padding(4, 0, 4, 0);
            lblYearsOfExperience.Name = "lblYearsOfExperience";
            lblYearsOfExperience.Size = new Size(111, 15);
            lblYearsOfExperience.TabIndex = 7;
            lblYearsOfExperience.Text = "Years of Experience:";
            // 
            // txtYearsOfExperience
            // 
            txtYearsOfExperience.Location = new Point(14, 241);
            txtYearsOfExperience.Margin = new Padding(4, 3, 4, 3);
            txtYearsOfExperience.Name = "txtYearsOfExperience";
            txtYearsOfExperience.ReadOnly = true;
            txtYearsOfExperience.Size = new Size(303, 23);
            txtYearsOfExperience.TabIndex = 8;
            // 
            // lblMake
            // 
            lblMake.AutoSize = true;
            lblMake.Location = new Point(14, 279);
            lblMake.Margin = new Padding(4, 0, 4, 0);
            lblMake.Name = "lblMake";
            lblMake.Size = new Size(39, 15);
            lblMake.TabIndex = 9;
            lblMake.Text = "Make:";
            // 
            // txtMake
            // 
            txtMake.Location = new Point(14, 298);
            txtMake.Margin = new Padding(4, 3, 4, 3);
            txtMake.Name = "txtMake";
            txtMake.ReadOnly = true;
            txtMake.Size = new Size(303, 23);
            txtMake.TabIndex = 10;
            // 
            // lblPlateNumber
            // 
            lblPlateNumber.AutoSize = true;
            lblPlateNumber.Location = new Point(14, 336);
            lblPlateNumber.Margin = new Padding(4, 0, 4, 0);
            lblPlateNumber.Name = "lblPlateNumber";
            lblPlateNumber.Size = new Size(83, 15);
            lblPlateNumber.TabIndex = 11;
            lblPlateNumber.Text = "Plate Number:";
            // 
            // txtPlateNumber
            // 
            txtPlateNumber.Location = new Point(14, 354);
            txtPlateNumber.Margin = new Padding(4, 3, 4, 3);
            txtPlateNumber.Name = "txtPlateNumber";
            txtPlateNumber.ReadOnly = true;
            txtPlateNumber.Size = new Size(303, 23);
            txtPlateNumber.TabIndex = 12;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(230, 384);
            btnDelete.Margin = new Padding(4, 3, 4, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(88, 27);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // DeleteDriver
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 425);
            Controls.Add(btnDelete);
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
            Controls.Add(txtId);
            Controls.Add(lblId);
            Controls.Add(comboBoxDrivers);
            Margin = new Padding(4, 3, 4, 3);
            Name = "DeleteDriver";
            Text = "Delete Driver";
            Load += DeleteDriver_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
