
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
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSearchDate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.numTopM = new System.Windows.Forms.NumericUpDown();
            this.btnTopM = new System.Windows.Forms.Button();
            this.btnTopAuthors = new System.Windows.Forms.Button();
            this.btnArchive = new System.Windows.Forms.Button();
            this.btnViewArchive = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTopM)).BeginInit();
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
            this.btnLoadGrid.Location = new System.Drawing.Point(3, 133);
            this.btnLoadGrid.Name = "btnLoadGrid";
            this.btnLoadGrid.Size = new System.Drawing.Size(75, 23);
            this.btnLoadGrid.TabIndex = 2;
            this.btnLoadGrid.Text = "Load";
            this.btnLoadGrid.UseVisualStyleBackColor = true;
            this.btnLoadGrid.Click += new System.EventHandler(this.btnLoadGrid_Click);
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(3, 46);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(75, 23);
            this.btnAddBook.TabIndex = 3;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnAddArticle
            // 
            this.btnAddArticle.Location = new System.Drawing.Point(84, 46);
            this.btnAddArticle.Name = "btnAddArticle";
            this.btnAddArticle.Size = new System.Drawing.Size(75, 23);
            this.btnAddArticle.TabIndex = 3;
            this.btnAddArticle.Text = "Add Article";
            this.btnAddArticle.UseVisualStyleBackColor = true;
            this.btnAddArticle.Click += new System.EventHandler(this.btnAddArticle_Click);
            // 
            // btnAddResourse
            // 
            this.btnAddResourse.Location = new System.Drawing.Point(165, 46);
            this.btnAddResourse.Name = "btnAddResourse";
            this.btnAddResourse.Size = new System.Drawing.Size(83, 23);
            this.btnAddResourse.TabIndex = 3;
            this.btnAddResourse.Text = "Add Resourse";
            this.btnAddResourse.UseVisualStyleBackColor = true;
            this.btnAddResourse.Click += new System.EventHandler(this.btnAddResourse_Click);
            // 
            // dtFrom
            // 
            this.dtFrom.Location = new System.Drawing.Point(505, 48);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(79, 20);
            this.dtFrom.TabIndex = 4;
            // 
            // dtTo
            // 
            this.dtTo.Location = new System.Drawing.Point(622, 48);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(80, 20);
            this.dtTo.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(469, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "From";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(596, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "To";
            // 
            // btnSearchDate
            // 
            this.btnSearchDate.Location = new System.Drawing.Point(722, 46);
            this.btnSearchDate.Name = "btnSearchDate";
            this.btnSearchDate.Size = new System.Drawing.Size(75, 23);
            this.btnSearchDate.TabIndex = 6;
            this.btnSearchDate.Text = "Search";
            this.btnSearchDate.UseVisualStyleBackColor = true;
            this.btnSearchDate.Click += new System.EventHandler(this.btnSearchDate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(462, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Top m";
            // 
            // numTopM
            // 
            this.numTopM.Location = new System.Drawing.Point(505, 88);
            this.numTopM.Name = "numTopM";
            this.numTopM.Size = new System.Drawing.Size(197, 20);
            this.numTopM.TabIndex = 8;
            // 
            // btnTopM
            // 
            this.btnTopM.Location = new System.Drawing.Point(722, 85);
            this.btnTopM.Name = "btnTopM";
            this.btnTopM.Size = new System.Drawing.Size(75, 23);
            this.btnTopM.TabIndex = 9;
            this.btnTopM.Text = "Top M";
            this.btnTopM.UseVisualStyleBackColor = true;
            this.btnTopM.Click += new System.EventHandler(this.btnTopM_Click);
            // 
            // btnTopAuthors
            // 
            this.btnTopAuthors.Location = new System.Drawing.Point(722, 124);
            this.btnTopAuthors.Name = "btnTopAuthors";
            this.btnTopAuthors.Size = new System.Drawing.Size(75, 23);
            this.btnTopAuthors.TabIndex = 10;
            this.btnTopAuthors.Text = "Top Authors";
            this.btnTopAuthors.UseVisualStyleBackColor = true;
            this.btnTopAuthors.Click += new System.EventHandler(this.btnTopAuthors_Click);
            // 
            // btnArchive
            // 
            this.btnArchive.Location = new System.Drawing.Point(84, 133);
            this.btnArchive.Name = "btnArchive";
            this.btnArchive.Size = new System.Drawing.Size(75, 23);
            this.btnArchive.TabIndex = 11;
            this.btnArchive.Text = "Archive";
            this.btnArchive.UseVisualStyleBackColor = true;
            // 
            // btnViewArchive
            // 
            this.btnViewArchive.Location = new System.Drawing.Point(165, 133);
            this.btnViewArchive.Name = "btnViewArchive";
            this.btnViewArchive.Size = new System.Drawing.Size(83, 23);
            this.btnViewArchive.TabIndex = 11;
            this.btnViewArchive.Text = "View Archive";
            this.btnViewArchive.UseVisualStyleBackColor = true;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnViewArchive);
            this.Controls.Add(this.btnArchive);
            this.Controls.Add(this.btnTopAuthors);
            this.Controls.Add(this.btnTopM);
            this.Controls.Add(this.numTopM);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSearchDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtTo);
            this.Controls.Add(this.dtFrom);
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
            ((System.ComponentModel.ISupportInitialize)(this.numTopM)).EndInit();
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
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSearchDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numTopM;
        private System.Windows.Forms.Button btnTopM;
        private System.Windows.Forms.Button btnTopAuthors;
        private System.Windows.Forms.Button btnArchive;
        private System.Windows.Forms.Button btnViewArchive;
    }
}
