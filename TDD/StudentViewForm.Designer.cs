using System;

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
            this.StudentGridView = new System.Windows.Forms.DataGridView();
            this.AddStudentButton = new System.Windows.Forms.Button();
            this.BubbleSortButton = new System.Windows.Forms.Button();
            this.BubbleSortLabel = new System.Windows.Forms.Label();
            this.QuickSortLabel = new System.Windows.Forms.Label();
            this.QuickSortButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StudentGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentGridView
            // 
            this.StudentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentGridView.Location = new System.Drawing.Point(12, 12);
            this.StudentGridView.Name = "StudentGridView";
            this.StudentGridView.RowHeadersVisible = false;
            this.StudentGridView.RowHeadersWidth = 62;
            this.StudentGridView.RowTemplate.Height = 28;
            this.StudentGridView.Size = new System.Drawing.Size(1339, 566);
            this.StudentGridView.TabIndex = 0;
            // 
            // AddStudentButton
            // 
            this.AddStudentButton.Location = new System.Drawing.Point(1260, 601);
            this.AddStudentButton.Name = "AddStudentButton";
            this.AddStudentButton.Size = new System.Drawing.Size(91, 54);
            this.AddStudentButton.TabIndex = 1;
            this.AddStudentButton.Text = "Add Student";
            this.AddStudentButton.UseVisualStyleBackColor = true;
            this.AddStudentButton.Click += new System.EventHandler(this.AddStudentButton_Click);
            // 
            // BubbleSortButton
            // 
            this.BubbleSortButton.Location = new System.Drawing.Point(12, 584);
            this.BubbleSortButton.Name = "BubbleSortButton";
            this.BubbleSortButton.Size = new System.Drawing.Size(91, 71);
            this.BubbleSortButton.TabIndex = 2;
            this.BubbleSortButton.Text = "Bubble Sort O(n^2)";
            this.BubbleSortButton.UseVisualStyleBackColor = true;
            this.BubbleSortButton.Click += new System.EventHandler(this.BubbleSortButton_Click);
            // 
            // BubbleSortLabel
            // 
            this.BubbleSortLabel.AutoSize = true;
            this.BubbleSortLabel.Location = new System.Drawing.Point(122, 618);
            this.BubbleSortLabel.Name = "BubbleSortLabel";
            this.BubbleSortLabel.Size = new System.Drawing.Size(0, 20);
            this.BubbleSortLabel.TabIndex = 3;
            this.BubbleSortLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // QuickSortLabel
            // 
            this.QuickSortLabel.AutoSize = true;
            this.QuickSortLabel.Location = new System.Drawing.Point(365, 618);
            this.QuickSortLabel.Name = "QuickSortLabel";
            this.QuickSortLabel.Size = new System.Drawing.Size(0, 20);
            this.QuickSortLabel.TabIndex = 5;
            this.QuickSortLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // QuickSortButton
            // 
            this.QuickSortButton.Location = new System.Drawing.Point(255, 584);
            this.QuickSortButton.Name = "QuickSortButton";
            this.QuickSortButton.Size = new System.Drawing.Size(91, 71);
            this.QuickSortButton.TabIndex = 4;
            this.QuickSortButton.Text = "QuickSort O(n log n)";
            this.QuickSortButton.UseVisualStyleBackColor = true;
            this.QuickSortButton.Click += new System.EventHandler(this.QuickSortButton_Click);
            // 
            // StudentViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1817, 944);
            this.Controls.Add(this.QuickSortLabel);
            this.Controls.Add(this.QuickSortButton);
            this.Controls.Add(this.BubbleSortLabel);
            this.Controls.Add(this.BubbleSortButton);
            this.Controls.Add(this.AddStudentButton);
            this.Controls.Add(this.StudentGridView);
            this.Name = "StudentViewForm";
            this.Text = "Student View";
            this.Load += new System.EventHandler(this.StudentViewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView StudentGridView;
        private System.Windows.Forms.Button AddStudentButton;
        private System.Windows.Forms.Button BubbleSortButton;
        private System.Windows.Forms.Label BubbleSortLabel;
        private System.Windows.Forms.Label QuickSortLabel;
        private System.Windows.Forms.Button QuickSortButton;
    }
}

