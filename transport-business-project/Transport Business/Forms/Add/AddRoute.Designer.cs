namespace transport_business_project.Transport_Business.Forms.Add
{
    partial class AddRoute
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblStartLocation;
        private System.Windows.Forms.TextBox txtStartLocation;
        private System.Windows.Forms.Label lblEndLocation;
        private System.Windows.Forms.TextBox txtEndLocation;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.TextBox txtDistance;
        private System.Windows.Forms.Label lblEstimatedTime;
        private System.Windows.Forms.TextBox txtEstimatedTime;
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
            this.lblStartLocation = new System.Windows.Forms.Label();
            this.txtStartLocation = new System.Windows.Forms.TextBox();
            this.lblEndLocation = new System.Windows.Forms.Label();
            this.txtEndLocation = new System.Windows.Forms.TextBox();
            this.lblDistance = new System.Windows.Forms.Label();
            this.txtDistance = new System.Windows.Forms.TextBox();
            this.lblEstimatedTime = new System.Windows.Forms.Label();
            this.txtEstimatedTime = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStartLocation
            // 
            this.lblStartLocation.AutoSize = true;
            this.lblStartLocation.Location = new System.Drawing.Point(12, 15);
            this.lblStartLocation.Name = "lblStartLocation";
            this.lblStartLocation.Size = new System.Drawing.Size(76, 13);
            this.lblStartLocation.TabIndex = 0;
            this.lblStartLocation.Text = "Start Location:";
            // 
            // txtStartLocation
            // 
            this.txtStartLocation.Location = new System.Drawing.Point(15, 31);
            this.txtStartLocation.Name = "txtStartLocation";
            this.txtStartLocation.Size = new System.Drawing.Size(257, 20);
            this.txtStartLocation.TabIndex = 1;
            this.txtStartLocation.Validating += new System.ComponentModel.CancelEventHandler(this.txtStartLocation_Validating);
            // 
            // lblEndLocation
            // 
            this.lblEndLocation.AutoSize = true;
            this.lblEndLocation.Location = new System.Drawing.Point(12, 64);
            this.lblEndLocation.Name = "lblEndLocation";
            this.lblEndLocation.Size = new System.Drawing.Size(73, 13);
            this.lblEndLocation.TabIndex = 2;
            this.lblEndLocation.Text = "End Location:";
            // 
            // txtEndLocation
            // 
            this.txtEndLocation.Location = new System.Drawing.Point(15, 80);
            this.txtEndLocation.Name = "txtEndLocation";
            this.txtEndLocation.Size = new System.Drawing.Size(257, 20);
            this.txtEndLocation.TabIndex = 3;
            this.txtEndLocation.Validating += new System.ComponentModel.CancelEventHandler(this.txtEndLocation_Validating);
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.Location = new System.Drawing.Point(12, 113);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(52, 13);
            this.lblDistance.TabIndex = 4;
            this.lblDistance.Text = "Distance:";
            // 
            // txtDistance
            // 
            this.txtDistance.Location = new System.Drawing.Point(15, 129);
            this.txtDistance.Name = "txtDistance";
            this.txtDistance.Size = new System.Drawing.Size(257, 20);
            this.txtDistance.TabIndex = 5;
            this.txtDistance.Validating += new System.ComponentModel.CancelEventHandler(this.txtDistance_Validating);
            // 
            // lblEstimatedTime
            // 
            this.lblEstimatedTime.AutoSize = true;
            this.lblEstimatedTime.Location = new System.Drawing.Point(12, 162);
            this.lblEstimatedTime.Name = "lblEstimatedTime";
            this.lblEstimatedTime.Size = new System.Drawing.Size(80, 13);
            this.lblEstimatedTime.TabIndex = 6;
            this.lblEstimatedTime.Text = "Estimated Time:";
            // 
            // txtEstimatedTime
            // 
            this.txtEstimatedTime.Location = new System.Drawing.Point(15, 178);
            this.txtEstimatedTime.Name = "txtEstimatedTime";
            this.txtEstimatedTime.Size = new System.Drawing.Size(257, 20);
            this.txtEstimatedTime.TabIndex = 7;
            this.txtEstimatedTime.Validating += new System.ComponentModel.CancelEventHandler(this.txtEstimatedTime_Validating);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(197, 214);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 249);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtEstimatedTime);
            this.Controls.Add(this.lblEstimatedTime);
            this.Controls.Add(this.txtDistance);
            this.Controls.Add(this.lblDistance);
            this.Controls.Add(this.txtEndLocation);
            this.Controls.Add(this.lblEndLocation);
            this.Controls.Add(this.txtStartLocation);
            this.Controls.Add(this.lblStartLocation);
            this.Name = "AddRoute";
            this.Text = "Add Route";
      //      this.Load += new System.EventHandler(this.AddRoute_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
