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
            this.StudentGridView.Location = new System.Drawing.Point(15, 14);
            this.StudentGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StudentGridView.Name = "StudentGridView";
            this.StudentGridView.RowHeadersVisible = false;
            this.StudentGridView.RowHeadersWidth = 62;
            this.StudentGridView.RowTemplate.Height = 28;
            this.StudentGridView.Size = new System.Drawing.Size(1637, 679);
            this.StudentGridView.TabIndex = 0;
            this.StudentGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentGridView_CellContentClick);
            // 
            // BubbleSortButton
            // 
            this.BubbleSortButton.Location = new System.Drawing.Point(15, 701);
            this.BubbleSortButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BubbleSortButton.Name = "BubbleSortButton";
            this.BubbleSortButton.Size = new System.Drawing.Size(111, 85);
            this.BubbleSortButton.TabIndex = 2;
            this.BubbleSortButton.Text = "Bubble Sort O(n^2)";
            this.BubbleSortButton.UseVisualStyleBackColor = true;
            this.BubbleSortButton.Click += new System.EventHandler(this.BubbleSortButton_Click);
            // 
            // BubbleSortLabel
            // 
            this.BubbleSortLabel.AutoSize = true;
            this.BubbleSortLabel.Location = new System.Drawing.Point(149, 742);
            this.BubbleSortLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BubbleSortLabel.Name = "BubbleSortLabel";
            this.BubbleSortLabel.Size = new System.Drawing.Size(0, 25);
            this.BubbleSortLabel.TabIndex = 3;
            this.BubbleSortLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // QuickSortLabel
            // 
            this.QuickSortLabel.AutoSize = true;
            this.QuickSortLabel.Location = new System.Drawing.Point(446, 742);
            this.QuickSortLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.QuickSortLabel.Name = "QuickSortLabel";
            this.QuickSortLabel.Size = new System.Drawing.Size(0, 25);
            this.QuickSortLabel.TabIndex = 5;
            this.QuickSortLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // QuickSortButton
            // 
            this.QuickSortButton.Location = new System.Drawing.Point(335, 701);
            this.QuickSortButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.QuickSortButton.Name = "QuickSortButton";
            this.QuickSortButton.Size = new System.Drawing.Size(111, 85);
            this.QuickSortButton.TabIndex = 4;
            this.QuickSortButton.Text = "QuickSort O(n log n)";
            this.QuickSortButton.UseVisualStyleBackColor = true;
            this.QuickSortButton.Click += new System.EventHandler(this.QuickSortButton_Click);
            // 
            // StudentViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1674, 809);
            this.Controls.Add(this.QuickSortLabel);
            this.Controls.Add(this.QuickSortButton);
            this.Controls.Add(this.BubbleSortLabel);
            this.Controls.Add(this.BubbleSortButton);
            this.Controls.Add(this.StudentGridView);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "StudentViewForm";
            this.Text = "Student View";
            this.Load += new System.EventHandler(this.StudentViewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView StudentGridView;
        private System.Windows.Forms.Button BubbleSortButton;
        private System.Windows.Forms.Label BubbleSortLabel;
        private System.Windows.Forms.Label QuickSortLabel;
        private System.Windows.Forms.Button QuickSortButton;
    }
}

