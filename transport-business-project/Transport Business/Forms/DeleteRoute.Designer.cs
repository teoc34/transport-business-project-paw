namespace transport_business_project.Transport_Business.Forms
{
    partial class DeleteRoute
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cb_deleteEmployee = new ComboBox();
            label1 = new Label();
            label4 = new Label();
            button2 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // cb_deleteEmployee
            // 
            cb_deleteEmployee.FormattingEnabled = true;
            cb_deleteEmployee.Location = new Point(302, 206);
            cb_deleteEmployee.Name = "cb_deleteEmployee";
            cb_deleteEmployee.Size = new Size(164, 23);
            cb_deleteEmployee.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(292, 160);
            label1.Name = "label1";
            label1.Size = new Size(188, 15);
            label1.TabIndex = 16;
            label1.Text = "Choose a route you want to delete";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(302, 102);
            label4.Name = "label4";
            label4.Size = new Size(160, 27);
            label4.TabIndex = 15;
            label4.Text = "Delete route";
            // 
            // button2
            // 
            button2.Location = new Point(422, 279);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 14;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(275, 279);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 13;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = true;
            // 
            // DeleteRoute
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cb_deleteEmployee);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "DeleteRoute";
            Text = "DeleteRoute";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cb_deleteEmployee;
        private Label label1;
        private Label label4;
        private Button button2;
        private Button button1;
    }
}