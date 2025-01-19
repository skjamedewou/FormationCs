namespace Encaps
{
    partial class FormEmployeeDetails
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
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnEnvoyer = new Button();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(103, 175);
            label4.Name = "label4";
            label4.Size = new Size(186, 28);
            label4.TabIndex = 3;
            label4.Text = "Employee Position";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(103, 101);
            label3.Name = "label3";
            label3.Size = new Size(147, 28);
            label3.TabIndex = 4;
            label3.Text = "Employee Age";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(103, 38);
            label2.Name = "label2";
            label2.Size = new Size(166, 28);
            label2.TabIndex = 5;
            label2.Text = "Employee Name";
            // 
            // btnEnvoyer
            // 
            btnEnvoyer.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnEnvoyer.Location = new Point(128, 245);
            btnEnvoyer.Name = "btnEnvoyer";
            btnEnvoyer.Size = new Size(161, 52);
            btnEnvoyer.TabIndex = 6;
            btnEnvoyer.Text = "Fermer";
            btnEnvoyer.UseVisualStyleBackColor = true;
            btnEnvoyer.Click += btnEnvoyer_Click;
            // 
            // FormEmployeeDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(387, 330);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnEnvoyer);
            Name = "FormEmployeeDetails";
            Text = "FormEmployeeDetails";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label label4;
        public Label label3;
        public Label label2;
        private Button btnEnvoyer;
    }
}