namespace TDD
{
    partial class StudentViewForm
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
            this.StudentViewTable = new System.Windows.Forms.DataGridView();
            this.AddStudentButton = new System.Windows.Forms.Button();
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Average = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grade1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grade2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grade3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grade4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grade5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.StudentViewTable)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentViewTable
            // 
            this.StudentViewTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentViewTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Index,
            this.ID,
            this.FirstName,
            this.LastName,
            this.Email,
            this.Phone,
            this.Average,
            this.Grade1,
            this.Grade2,
            this.Grade3,
            this.Grade4,
            this.Grade5});
            this.StudentViewTable.Location = new System.Drawing.Point(12, 12);
            this.StudentViewTable.Name = "StudentViewTable";
            this.StudentViewTable.RowHeadersVisible = false;
            this.StudentViewTable.RowHeadersWidth = 62;
            this.StudentViewTable.RowTemplate.Height = 28;
            this.StudentViewTable.Size = new System.Drawing.Size(1226, 566);
            this.StudentViewTable.TabIndex = 0;
            this.StudentViewTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // AddStudentButton
            // 
            this.AddStudentButton.Location = new System.Drawing.Point(1273, 514);
            this.AddStudentButton.Name = "AddStudentButton";
            this.AddStudentButton.Size = new System.Drawing.Size(91, 54);
            this.AddStudentButton.TabIndex = 1;
            this.AddStudentButton.Text = "Add Student";
            this.AddStudentButton.UseVisualStyleBackColor = true;
            this.AddStudentButton.Click += new System.EventHandler(this.AddStudentButton_Click);
            // 
            // Index
            // 
            this.Index.HeaderText = "Index";
            this.Index.MinimumWidth = 8;
            this.Index.Name = "Index";
            this.Index.Width = 150;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
            this.ID.Width = 150;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "First Name";
            this.FirstName.MinimumWidth = 8;
            this.FirstName.Name = "FirstName";
            this.FirstName.Width = 150;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Last Name";
            this.LastName.MinimumWidth = 8;
            this.LastName.Name = "LastName";
            this.LastName.Width = 150;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 8;
            this.Email.Name = "Email";
            this.Email.Width = 150;
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Phone";
            this.Phone.MinimumWidth = 8;
            this.Phone.Name = "Phone";
            this.Phone.Width = 150;
            // 
            // Average
            // 
            this.Average.HeaderText = "Average";
            this.Average.MinimumWidth = 8;
            this.Average.Name = "Average";
            this.Average.Width = 150;
            // 
            // Grade1
            // 
            this.Grade1.HeaderText = "Algorithms I";
            this.Grade1.MinimumWidth = 8;
            this.Grade1.Name = "Grade1";
            this.Grade1.Width = 150;
            // 
            // Grade2
            // 
            this.Grade2.HeaderText = "Statistics";
            this.Grade2.MinimumWidth = 8;
            this.Grade2.Name = "Grade2";
            this.Grade2.Width = 150;
            // 
            // Grade3
            // 
            this.Grade3.HeaderText = "Advanced OOP";
            this.Grade3.MinimumWidth = 8;
            this.Grade3.Name = "Grade3";
            this.Grade3.Width = 150;
            // 
            // Grade4
            // 
            this.Grade4.HeaderText = "Data Structures";
            this.Grade4.MinimumWidth = 8;
            this.Grade4.Name = "Grade4";
            this.Grade4.Width = 150;
            // 
            // Grade5
            // 
            this.Grade5.HeaderText = "Software Testing & Quality";
            this.Grade5.MinimumWidth = 8;
            this.Grade5.Name = "Grade5";
            this.Grade5.Width = 150;
            // 
            // StudentViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1379, 692);
            this.Controls.Add(this.AddStudentButton);
            this.Controls.Add(this.StudentViewTable);
            this.Name = "StudentViewForm";
            this.Text = "Student View";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentViewTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView StudentViewTable;
        private System.Windows.Forms.Button AddStudentButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Average;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grade1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grade2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grade3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grade4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grade5;
    }
}

