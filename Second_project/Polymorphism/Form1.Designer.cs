namespace Polymorphism
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnparameter = new Button();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // btnparameter
            // 
            btnparameter.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnparameter.Location = new Point(442, 71);
            btnparameter.Name = "btnparameter";
            btnparameter.Size = new Size(209, 64);
            btnparameter.TabIndex = 0;
            btnparameter.Text = "1Parameter";
            btnparameter.UseVisualStyleBackColor = true;
            btnparameter.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            textBox1.Location = new Point(70, 65);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(319, 326);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.Location = new Point(442, 141);
            button1.Name = "button1";
            button1.Size = new Size(209, 64);
            button1.TabIndex = 0;
            button1.Text = "2Parameter";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button2_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button2.Location = new Point(442, 211);
            button2.Name = "button2";
            button2.Size = new Size(209, 64);
            button2.TabIndex = 0;
            button2.Text = "3Parameter";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button3_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button3.Location = new Point(442, 281);
            button3.Name = "button3";
            button3.Size = new Size(209, 64);
            button3.TabIndex = 0;
            button3.Text = "4Parameter";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button4_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button4.Location = new Point(680, 71);
            button4.Name = "button4";
            button4.Size = new Size(209, 64);
            button4.TabIndex = 0;
            button4.Text = "Virtual";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click_1;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button5.Location = new Point(680, 152);
            button5.Name = "button5";
            button5.Size = new Size(209, 64);
            button5.TabIndex = 0;
            button5.Text = "Override";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 458);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(btnparameter);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnparameter;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}
