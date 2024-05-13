namespace transport_business_project.Transport_Business.Forms
{
    partial class UpdateEmployee
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
            label1 = new Label();
            label4 = new Label();
            button2 = new Button();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            numericUpDown1 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(284, 163);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 16;
            label1.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(284, 89);
            label4.Name = "label4";
            label4.Size = new Size(238, 27);
            label4.TabIndex = 15;
            label4.Text = "Update an employee";
            label4.Click += label4_Click;
            // 
            // button2
            // 
            button2.Location = new Point(431, 337);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 14;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(284, 337);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 13;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(284, 198);
            label2.Name = "label2";
            label2.Size = new Size(110, 15);
            label2.TabIndex = 17;
            label2.Text = "Years Of Experience";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(284, 236);
            label3.Name = "label3";
            label3.Size = new Size(25, 15);
            label3.TabIndex = 18;
            label3.Text = "Car";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(284, 271);
            label5.Name = "label5";
            label5.Size = new Size(93, 15);
            label5.TabIndex = 19;
            label5.Text = "License Number";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(406, 160);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 20;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(406, 268);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 21;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(406, 233);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 22;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(406, 196);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(100, 23);
            numericUpDown1.TabIndex = 23;
            // 
            // UpdateEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(numericUpDown1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "UpdateEmployee";
            Text = "UpdateEmployee";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label4;
        private Button button2;
        private Button button1;
        private Label label2;
        private Label label3;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private NumericUpDown numericUpDown1;
    }
}