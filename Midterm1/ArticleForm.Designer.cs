
namespace Midterm1 {
    partial class ArticleForm {
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
            this.label9 = new System.Windows.Forms.Label();
            this.btnArticleSave = new System.Windows.Forms.Button();
            this.tbAuthorFn = new System.Windows.Forms.TextBox();
            this.tbAuthorLn = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtPublishDate = new System.Windows.Forms.DateTimePicker();
            this.numPageNumber = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbArticleName = new System.Windows.Forms.TextBox();
            this.tbJournal = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.numNumber = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numPageNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(290, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(222, 31);
            this.label9.TabIndex = 24;
            this.label9.Text = "Add New Article";
            // 
            // btnArticleSave
            // 
            this.btnArticleSave.Location = new System.Drawing.Point(358, 364);
            this.btnArticleSave.Name = "btnArticleSave";
            this.btnArticleSave.Size = new System.Drawing.Size(86, 30);
            this.btnArticleSave.TabIndex = 23;
            this.btnArticleSave.Text = "Save";
            this.btnArticleSave.UseVisualStyleBackColor = true;
            this.btnArticleSave.Click += new System.EventHandler(this.btnArticleSave_Click);
            // 
            // tbAuthorFn
            // 
            this.tbAuthorFn.Location = new System.Drawing.Point(509, 137);
            this.tbAuthorFn.Name = "tbAuthorFn";
            this.tbAuthorFn.Size = new System.Drawing.Size(200, 20);
            this.tbAuthorFn.TabIndex = 21;
            // 
            // tbAuthorLn
            // 
            this.tbAuthorLn.Location = new System.Drawing.Point(509, 181);
            this.tbAuthorLn.Name = "tbAuthorLn";
            this.tbAuthorLn.Size = new System.Drawing.Size(200, 20);
            this.tbAuthorLn.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(443, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Last Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(443, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "First Name";
            // 
            // dtPublishDate
            // 
            this.dtPublishDate.Location = new System.Drawing.Point(150, 229);
            this.dtPublishDate.Name = "dtPublishDate";
            this.dtPublishDate.Size = new System.Drawing.Size(200, 20);
            this.dtPublishDate.TabIndex = 18;
            // 
            // numPageNumber
            // 
            this.numPageNumber.Location = new System.Drawing.Point(150, 275);
            this.numPageNumber.Name = "numPageNumber";
            this.numPageNumber.Size = new System.Drawing.Size(200, 20);
            this.numPageNumber.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(544, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Author";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(73, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Page Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Publish Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Journal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(194, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Article";
            // 
            // tbArticleName
            // 
            this.tbArticleName.Location = new System.Drawing.Point(150, 137);
            this.tbArticleName.Name = "tbArticleName";
            this.tbArticleName.Size = new System.Drawing.Size(200, 20);
            this.tbArticleName.TabIndex = 9;
            // 
            // tbJournal
            // 
            this.tbJournal.Location = new System.Drawing.Point(150, 184);
            this.tbJournal.Name = "tbJournal";
            this.tbJournal.Size = new System.Drawing.Size(200, 20);
            this.tbJournal.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(73, 322);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Number";
            // 
            // numNumber
            // 
            this.numNumber.Location = new System.Drawing.Point(150, 320);
            this.numNumber.Name = "numNumber";
            this.numNumber.Size = new System.Drawing.Size(200, 20);
            this.numNumber.TabIndex = 26;
            // 
            // ArticleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numNumber);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnArticleSave);
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
            this.Controls.Add(this.tbArticleName);
            this.Controls.Add(this.tbJournal);
            this.Name = "ArticleForm";
            this.Text = "ArticleForm";
            ((System.ComponentModel.ISupportInitialize)(this.numPageNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnArticleSave;
        private System.Windows.Forms.TextBox tbAuthorFn;
        private System.Windows.Forms.TextBox tbAuthorLn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtPublishDate;
        private System.Windows.Forms.NumericUpDown numPageNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbArticleName;
        private System.Windows.Forms.TextBox tbJournal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numNumber;
    }
}