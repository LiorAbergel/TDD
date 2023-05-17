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
            this.QuickSortButton = new System.Windows.Forms.Button();
            this.QuickSortLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.StudentGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentGridView
            // 
            this.StudentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentGridView.Location = new System.Drawing.Point(12, 12);
            this.StudentGridView.Name = "StudentGridView";
            this.StudentGridView.ReadOnly = true;
            this.StudentGridView.RowHeadersVisible = false;
            this.StudentGridView.RowHeadersWidth = 62;
            this.StudentGridView.RowTemplate.Height = 28;
            this.StudentGridView.Size = new System.Drawing.Size(1339, 566);
            this.StudentGridView.TabIndex = 0;
            this.StudentGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentGridView_CellContentClick);
            // 
            // QuickSortButton
            // 
            this.QuickSortButton.Location = new System.Drawing.Point(12, 591);
            this.QuickSortButton.Name = "QuickSortButton";
            this.QuickSortButton.Size = new System.Drawing.Size(91, 71);
            this.QuickSortButton.TabIndex = 4;
            this.QuickSortButton.Text = "Sort by average";
            this.QuickSortButton.UseVisualStyleBackColor = true;
            this.QuickSortButton.Click += new System.EventHandler(this.QuickSortButton_Click);
            // 
            // QuickSortLabel
            // 
            this.QuickSortLabel.AutoSize = true;
            this.QuickSortLabel.Location = new System.Drawing.Point(147, 616);
            this.QuickSortLabel.Name = "QuickSortLabel";
            this.QuickSortLabel.Size = new System.Drawing.Size(0, 20);
            this.QuickSortLabel.TabIndex = 5;
            this.QuickSortLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // StudentViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 674);
            this.Controls.Add(this.QuickSortLabel);
            this.Controls.Add(this.QuickSortButton);
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
        private System.Windows.Forms.Button QuickSortButton;
        private System.Windows.Forms.Label QuickSortLabel;
    }
}

