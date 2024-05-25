using System;
using System.Windows.Forms;

namespace transport_business_project.Transport_Business.Forms.Delete
{
    partial class DeleteRoute
    {
        private Label lblRouteID;
        private TextBox txtRouteID;
        private Button btnDelete;
        private ErrorProvider errorProvider;

        private void InitializeComponent()
        {
            this.lblRouteID = new Label();
            this.txtRouteID = new TextBox();
            this.btnDelete = new Button();
            this.errorProvider = new ErrorProvider();

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
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(150, 40);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;

            // 
            // DeleteRoute
            // 
            this.ClientSize = new System.Drawing.Size(370, 80);
            this.Controls.Add(this.lblRouteID);
            this.Controls.Add(this.txtRouteID);
            this.Controls.Add(this.btnDelete);
            this.Name = "DeleteRoute";
            this.Text = "Delete Route";
        }
    }
}
