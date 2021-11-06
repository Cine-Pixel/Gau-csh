
namespace Midterm1 {
    partial class Dashboard {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
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
            this.btnLoadGrid = new System.Windows.Forms.Button();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnAddArticle = new System.Windows.Forms.Button();
            this.btnAddResourse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(337, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dashboard";
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
            this.dtgProducts.Location = new System.Drawing.Point(3, 162);
            this.dtgProducts.Name = "dtgProducts";
            this.dtgProducts.Size = new System.Drawing.Size(794, 285);
            this.dtgProducts.TabIndex = 1;
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
            // btnLoadGrid
            // 
            this.btnLoadGrid.Location = new System.Drawing.Point(722, 133);
            this.btnLoadGrid.Name = "btnLoadGrid";
            this.btnLoadGrid.Size = new System.Drawing.Size(75, 23);
            this.btnLoadGrid.TabIndex = 2;
            this.btnLoadGrid.Text = "Load";
            this.btnLoadGrid.UseVisualStyleBackColor = true;
            this.btnLoadGrid.Click += new System.EventHandler(this.btnLoadGrid_Click);
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(3, 77);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(75, 23);
            this.btnAddBook.TabIndex = 3;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnAddArticle
            // 
            this.btnAddArticle.Location = new System.Drawing.Point(84, 77);
            this.btnAddArticle.Name = "btnAddArticle";
            this.btnAddArticle.Size = new System.Drawing.Size(75, 23);
            this.btnAddArticle.TabIndex = 3;
            this.btnAddArticle.Text = "Add Article";
            this.btnAddArticle.UseVisualStyleBackColor = true;
            this.btnAddArticle.Click += new System.EventHandler(this.btnAddArticle_Click);
            // 
            // btnAddResourse
            // 
            this.btnAddResourse.Location = new System.Drawing.Point(165, 77);
            this.btnAddResourse.Name = "btnAddResourse";
            this.btnAddResourse.Size = new System.Drawing.Size(83, 23);
            this.btnAddResourse.TabIndex = 3;
            this.btnAddResourse.Text = "Add Resourse";
            this.btnAddResourse.UseVisualStyleBackColor = true;
            this.btnAddResourse.Click += new System.EventHandler(this.btnAddResourse_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAddResourse);
            this.Controls.Add(this.btnAddArticle);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.btnLoadGrid);
            this.Controls.Add(this.dtgProducts);
            this.Controls.Add(this.label1);
            this.Name = "Dashboard";
            this.Size = new System.Drawing.Size(800, 450);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgProducts;
        private System.Windows.Forms.Button btnLoadGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn PName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Authors;
        private System.Windows.Forms.DataGridViewTextBoxColumn PublishDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Publisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn PageNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn JournalName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Link;
        private System.Windows.Forms.DataGridViewTextBoxColumn Annotation;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnAddArticle;
        private System.Windows.Forms.Button btnAddResourse;
    }
}
