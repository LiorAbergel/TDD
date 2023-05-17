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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.StudentGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StudentGridView
            // 
            this.StudentGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StudentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StudentGridView.Location = new System.Drawing.Point(3, 25);
            this.StudentGridView.Margin = new System.Windows.Forms.Padding(10);
            this.StudentGridView.Name = "StudentGridView";
            this.StudentGridView.ReadOnly = true;
            this.StudentGridView.RowHeadersVisible = false;
            this.StudentGridView.RowHeadersWidth = 62;
            this.StudentGridView.RowTemplate.Height = 28;
            this.StudentGridView.Size = new System.Drawing.Size(1268, 646);
            this.StudentGridView.TabIndex = 0;
            this.StudentGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentGridView_CellContentClick);
            // 
            // QuickSortButton
            // 
            this.QuickSortButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.QuickSortButton.Location = new System.Drawing.Point(15, 693);
            this.QuickSortButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.QuickSortButton.Name = "QuickSortButton";
            this.QuickSortButton.Size = new System.Drawing.Size(145, 63);
            this.QuickSortButton.TabIndex = 4;
            this.QuickSortButton.Text = "Sort by average";
            this.QuickSortButton.UseVisualStyleBackColor = true;
            this.QuickSortButton.Click += new System.EventHandler(this.QuickSortButton_Click);
            // 
            // QuickSortLabel
            // 
            this.QuickSortLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.QuickSortLabel.AutoSize = true;
            this.QuickSortLabel.Location = new System.Drawing.Point(168, 712);
            this.QuickSortLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.QuickSortLabel.Name = "QuickSortLabel";
            this.QuickSortLabel.Size = new System.Drawing.Size(0, 25);
            this.QuickSortLabel.TabIndex = 5;
            this.QuickSortLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.StudentGridView);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1274, 674);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // StudentViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 771);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.QuickSortLabel);
            this.Controls.Add(this.QuickSortButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "StudentViewForm";
            this.Text = "Student View";
            this.Load += new System.EventHandler(this.StudentViewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button QuickSortButton;
        private System.Windows.Forms.Label QuickSortLabel;
        public System.Windows.Forms.DataGridView StudentGridView;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

