using System;
using System.Windows.Forms;

namespace transport_business_project.Transport_Business.Forms.Delete
{
    partial class DeleteTransport
    {
        private Label lblTransportID;
        private TextBox txtTransportID;
        private Button btnDelete;
        private ErrorProvider errorProvider;

        private void InitializeComponent()
        {
            this.lblTransportID = new Label();
            this.txtTransportID = new TextBox();
            this.btnDelete = new Button();
            this.errorProvider = new ErrorProvider();

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
            // DeleteTransport
            // 
            this.ClientSize = new System.Drawing.Size(370, 80);
            this.Controls.Add(this.lblTransportID);
            this.Controls.Add(this.txtTransportID);
            this.Controls.Add(this.btnDelete);
            this.Name = "DeleteTransport";
            this.Text = "Delete Transport";
        }
    }
}
