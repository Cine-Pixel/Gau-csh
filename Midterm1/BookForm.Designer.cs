
namespace Midterm1 {
    partial class BookForm {
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
            this.tbPublisher = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbBookName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numPageNumber = new System.Windows.Forms.NumericUpDown();
            this.dtPublishDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbAuthorLn = new System.Windows.Forms.TextBox();
            this.tbAuthorFn = new System.Windows.Forms.TextBox();
            this.btnBookSave = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numPageNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // tbPublisher
            // 
            this.tbPublisher.Location = new System.Drawing.Point(146, 174);
            this.tbPublisher.Name = "tbPublisher";
            this.tbPublisher.Size = new System.Drawing.Size(200, 20);
            this.tbPublisher.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(190, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Book";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(540, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Author";
            // 
            // tbBookName
            // 
            this.tbBookName.Location = new System.Drawing.Point(146, 127);
            this.tbBookName.Name = "tbBookName";
            this.tbBookName.Size = new System.Drawing.Size(200, 20);
            this.tbBookName.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Publisher";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Publish Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Page Number";
            // 
            // numPageNumber
            // 
            this.numPageNumber.Location = new System.Drawing.Point(146, 265);
            this.numPageNumber.Name = "numPageNumber";
            this.numPageNumber.Size = new System.Drawing.Size(200, 20);
            this.numPageNumber.TabIndex = 3;
            // 
            // dtPublishDate
            // 
            this.dtPublishDate.Location = new System.Drawing.Point(146, 219);
            this.dtPublishDate.Name = "dtPublishDate";
            this.dtPublishDate.Size = new System.Drawing.Size(200, 20);
            this.dtPublishDate.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(439, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "First Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(439, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Last Name";
            // 
            // tbAuthorLn
            // 
            this.tbAuthorLn.Location = new System.Drawing.Point(505, 171);
            this.tbAuthorLn.Name = "tbAuthorLn";
            this.tbAuthorLn.Size = new System.Drawing.Size(200, 20);
            this.tbAuthorLn.TabIndex = 6;
            // 
            // tbAuthorFn
            // 
            this.tbAuthorFn.Location = new System.Drawing.Point(505, 127);
            this.tbAuthorFn.Name = "tbAuthorFn";
            this.tbAuthorFn.Size = new System.Drawing.Size(200, 20);
            this.tbAuthorFn.TabIndex = 6;
            // 
            // btnBookSave
            // 
            this.btnBookSave.Location = new System.Drawing.Point(354, 341);
            this.btnBookSave.Name = "btnBookSave";
            this.btnBookSave.Size = new System.Drawing.Size(86, 30);
            this.btnBookSave.TabIndex = 7;
            this.btnBookSave.Text = "Save";
            this.btnBookSave.UseVisualStyleBackColor = true;
            this.btnBookSave.Click += new System.EventHandler(this.btnBookSave_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(292, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(205, 31);
            this.label9.TabIndex = 8;
            this.label9.Text = "Add New Book";
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnBookSave);
            this.Controls.Add(this.tbAuthorFn);
            this.Controls.Add(this.tbAuthorLn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtPublishDate);
            this.Controls.Add(this.numPageNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbBookName);
            this.Controls.Add(this.tbPublisher);
            this.Name = "BookForm";
            this.Text = "BookForm";
            ((System.ComponentModel.ISupportInitialize)(this.numPageNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbPublisher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbBookName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numPageNumber;
        private System.Windows.Forms.DateTimePicker dtPublishDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbAuthorLn;
        private System.Windows.Forms.TextBox tbAuthorFn;
        private System.Windows.Forms.Button btnBookSave;
        private System.Windows.Forms.Label label9;
    }
}