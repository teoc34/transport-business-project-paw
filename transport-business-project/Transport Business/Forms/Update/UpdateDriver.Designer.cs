namespace transport_business_project.Transport_Business.Forms.Update
{
    partial class UpdateDriver
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox comboBoxDrivers;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblLicenseNumber;
        private System.Windows.Forms.TextBox txtLicenseNumber;
        private System.Windows.Forms.Label lblYearsOfExperience;
        private System.Windows.Forms.TextBox txtYearsOfExperience;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.Label lblPlateNumber;
        private System.Windows.Forms.TextBox txtPlateNumber;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ErrorProvider errorProvider;

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
            this.comboBoxDrivers = new System.Windows.Forms.ComboBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblLicenseNumber = new System.Windows.Forms.Label();
            this.txtLicenseNumber = new System.Windows.Forms.TextBox();
            this.lblYearsOfExperience = new System.Windows.Forms.Label();
            this.txtYearsOfExperience = new System.Windows.Forms.TextBox();
            this.lblMake = new System.Windows.Forms.Label();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.lblPlateNumber = new System.Windows.Forms.Label();
            this.txtPlateNumber = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxDrivers
            // 
            this.comboBoxDrivers.FormattingEnabled = true;
            this.comboBoxDrivers.Location = new System.Drawing.Point(12, 12);
            this.comboBoxDrivers.Name = "comboBoxDrivers";
            this.comboBoxDrivers.Size = new System.Drawing.Size(260, 21);
            this.comboBoxDrivers.TabIndex = 0;
            this.comboBoxDrivers.SelectedIndexChanged += new System.EventHandler(this.comboBoxDrivers_SelectedIndexChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 46);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 62);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(260, 20);
            this.txtName.TabIndex = 2;
            this.txtName.Validating += new System.ComponentModel.CancelEventHandler(this.txtName_Validating);
            // 
            // lblLicenseNumber
            // 
            this.lblLicenseNumber.AutoSize = true;
            this.lblLicenseNumber.Location = new System.Drawing.Point(12, 95);
            this.lblLicenseNumber.Name = "lblLicenseNumber";
            this.lblLicenseNumber.Size = new System.Drawing.Size(87, 13);
            this.lblLicenseNumber.TabIndex = 3;
            this.lblLicenseNumber.Text = "License Number:";
            // 
            // txtLicenseNumber
            // 
            this.txtLicenseNumber.Location = new System.Drawing.Point(12, 111);
            this.txtLicenseNumber.Name = "txtLicenseNumber";
            this.txtLicenseNumber.Size = new System.Drawing.Size(260, 20);
            this.txtLicenseNumber.TabIndex = 4;
            this.txtLicenseNumber.Validating += new System.ComponentModel.CancelEventHandler(this.txtLicenseNumber_Validating);
            // 
            // lblYearsOfExperience
            // 
            this.lblYearsOfExperience.AutoSize = true;
            this.lblYearsOfExperience.Location = new System.Drawing.Point(12, 144);
            this.lblYearsOfExperience.Name = "lblYearsOfExperience";
            this.lblYearsOfExperience.Size = new System.Drawing.Size(106, 13);
            this.lblYearsOfExperience.TabIndex = 5;
            this.lblYearsOfExperience.Text = "Years of Experience:";
            // 
            // txtYearsOfExperience
            // 
            this.txtYearsOfExperience.Location = new System.Drawing.Point(12, 160);
            this.txtYearsOfExperience.Name = "txtYearsOfExperience";
            this.txtYearsOfExperience.Size = new System.Drawing.Size(260, 20);
            this.txtYearsOfExperience.TabIndex = 6;
            this.txtYearsOfExperience.Validating += new System.ComponentModel.CancelEventHandler(this.txtYearsOfExperience_Validating);
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.Location = new System.Drawing.Point(12, 193);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(37, 13);
            this.lblMake.TabIndex = 7;
            this.lblMake.Text = "Make:";
            // 
            // txtMake
            // 
            this.txtMake.Location = new System.Drawing.Point(12, 209);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(260, 20);
            this.txtMake.TabIndex = 8;
            this.txtMake.Validating += new System.ComponentModel.CancelEventHandler(this.txtMake_Validating);
            // 
            // lblPlateNumber
            // 
            this.lblPlateNumber.AutoSize = true;
            this.lblPlateNumber.Location = new System.Drawing.Point(12, 242);
            this.lblPlateNumber.Name = "lblPlateNumber";
            this.lblPlateNumber.Size = new System.Drawing.Size(73, 13);
            this.lblPlateNumber.TabIndex = 9;
            this.lblPlateNumber.Text = "Plate Number:";
            // 
            // txtPlateNumber
            // 
            this.txtPlateNumber.Location = new System.Drawing.Point(12, 258);
            this.txtPlateNumber.Name = "txtPlateNumber";
            this.txtPlateNumber.Size = new System.Drawing.Size(260, 20);
            this.txtPlateNumber.TabIndex = 10;
            this.txtPlateNumber.Validating += new System.ComponentModel.CancelEventHandler(this.txtPlateNumber_Validating);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(197, 284);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
       //     this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // UpdateDriver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 319);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtPlateNumber);
            this.Controls.Add(this.lblPlateNumber);
            this.Controls.Add(this.txtMake);
            this.Controls.Add(this.lblMake);
            this.Controls.Add(this.txtYearsOfExperience);
            this.Controls.Add(this.lblYearsOfExperience);
            this.Controls.Add(this.txtLicenseNumber);
            this.Controls.Add(this.lblLicenseNumber);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.comboBoxDrivers);
            this.Name = "UpdateDriver";
            this.Text = "Update Driver";
         //   this.Load += new System.EventHandler(this.UpdateDriver_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
