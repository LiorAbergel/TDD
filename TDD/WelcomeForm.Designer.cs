namespace TDD
{
    partial class WelcomeForm
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
            this.AddStudentButton = new System.Windows.Forms.Button();
            this.StudentViewButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddStudentButton
            // 
            this.AddStudentButton.Location = new System.Drawing.Point(127, 303);
            this.AddStudentButton.Name = "AddStudentButton";
            this.AddStudentButton.Size = new System.Drawing.Size(199, 60);
            this.AddStudentButton.TabIndex = 0;
            this.AddStudentButton.Text = "Add Student";
            this.AddStudentButton.UseVisualStyleBackColor = true;
            this.AddStudentButton.Click += new System.EventHandler(this.AddStudentButton_Click);
            // 
            // StudentViewButton
            // 
            this.StudentViewButton.Location = new System.Drawing.Point(455, 303);
            this.StudentViewButton.Name = "StudentViewButton";
            this.StudentViewButton.Size = new System.Drawing.Size(199, 60);
            this.StudentViewButton.TabIndex = 1;
            this.StudentViewButton.Text = "Student View";
            this.StudentViewButton.UseVisualStyleBackColor = true;
            this.StudentViewButton.Click += new System.EventHandler(this.StudentViewButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(373, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sce";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StudentViewButton);
            this.Controls.Add(this.AddStudentButton);
            this.Name = "WelcomeForm";
            this.Text = "WelcomeForm";
            this.Load += new System.EventHandler(this.WelcomeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddStudentButton;
        private System.Windows.Forms.Button StudentViewButton;
        private System.Windows.Forms.Label label1;
    }
}