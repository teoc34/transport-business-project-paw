namespace transport_business_project.Transport_Business.Forms
{
    partial class AddRoute
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
            dateTimePicker1 = new DateTimePicker();
            numericUpDown2 = new NumericUpDown();
            label7 = new Label();
            label6 = new Label();
            numericUpDown1 = new NumericUpDown();
            textBox3 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            button2 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(361, 162);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 54;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(361, 128);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(200, 23);
            numericUpDown2.TabIndex = 53;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(239, 130);
            label7.Name = "label7";
            label7.Size = new Size(20, 15);
            label7.TabIndex = 52;
            label7.Text = "Id ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(239, 168);
            label6.Name = "label6";
            label6.Size = new Size(80, 15);
            label6.TabIndex = 51;
            label6.Text = "Start Location";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(361, 238);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(200, 23);
            numericUpDown1.TabIndex = 50;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(361, 275);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(200, 23);
            textBox3.TabIndex = 49;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(361, 202);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 23);
            textBox1.TabIndex = 47;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(239, 278);
            label3.Name = "label3";
            label3.Size = new Size(88, 15);
            label3.TabIndex = 45;
            label3.Text = "Estimated Time";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(239, 240);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 44;
            label2.Text = "Distance";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(239, 205);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 43;
            label1.Text = "End Location";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(335, 59);
            label4.Name = "label4";
            label4.Size = new Size(128, 27);
            label4.TabIndex = 42;
            label4.Text = "Add Route";
            // 
            // button2
            // 
            button2.Location = new Point(430, 340);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 41;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(283, 340);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 40;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            // 
            // AddRoute
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dateTimePicker1);
            Controls.Add(numericUpDown2);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(numericUpDown1);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "AddRoute";
            Text = "AddRoute";
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private NumericUpDown numericUpDown2;
        private Label label7;
        private Label label6;
        private NumericUpDown numericUpDown1;
        private TextBox textBox3;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private Button button2;
        private Button button1;
    }
}