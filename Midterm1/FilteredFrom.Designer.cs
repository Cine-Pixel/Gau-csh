
namespace Midterm1 {
    partial class FilteredFrom {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.dtgProducts = new System.Windows.Forms.DataGridView();
            this.PName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Authors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PublishDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Publisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PageNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JournalName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Link = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Annotation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgProducts
            // 
            this.dtgProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PName,
            this.Authors,
            this.PublishDate,
            this.Publisher,
            this.PageNumber,
            this.JournalName,
            this.Number,
            this.Link,
            this.Annotation});
            this.dtgProducts.Location = new System.Drawing.Point(4, 93);
            this.dtgProducts.Name = "dtgProducts";
            this.dtgProducts.Size = new System.Drawing.Size(794, 353);
            this.dtgProducts.TabIndex = 2;
            // 
            // PName
            // 
            this.PName.HeaderText = "Name";
            this.PName.Name = "PName";
            // 
            // Authors
            // 
            this.Authors.HeaderText = "Authors";
            this.Authors.Name = "Authors";
            // 
            // PublishDate
            // 
            this.PublishDate.HeaderText = "PublishDate";
            this.PublishDate.Name = "PublishDate";
            // 
            // Publisher
            // 
            this.Publisher.HeaderText = "Publisher";
            this.Publisher.Name = "Publisher";
            // 
            // PageNumber
            // 
            this.PageNumber.HeaderText = "PageNumber";
            this.PageNumber.Name = "PageNumber";
            // 
            // JournalName
            // 
            this.JournalName.HeaderText = "JournalName";
            this.JournalName.Name = "JournalName";
            // 
            // Number
            // 
            this.Number.HeaderText = "Number";
            this.Number.Name = "Number";
            // 
            // Link
            // 
            this.Link.HeaderText = "Link";
            this.Link.Name = "Link";
            // 
            // Annotation
            // 
            this.Annotation.HeaderText = "Annotation";
            this.Annotation.Name = "Annotation";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(297, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Filtered Data";
            // 
            // FilteredFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgProducts);
            this.Name = "FilteredFrom";
            this.Text = "FilteredFrom";
            ((System.ComponentModel.ISupportInitialize)(this.dtgProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn PName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Authors;
        private System.Windows.Forms.DataGridViewTextBoxColumn PublishDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Publisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn PageNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn JournalName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Link;
        private System.Windows.Forms.DataGridViewTextBoxColumn Annotation;
        private System.Windows.Forms.Label label1;
    }
}