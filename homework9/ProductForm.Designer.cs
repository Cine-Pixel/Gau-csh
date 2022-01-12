
namespace homework9 {
    partial class ProductForm {
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbProductName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSupplier = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbUnitPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPackage = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbDiscontinued = new System.Windows.Forms.Label();
            this.checkDiscontinued = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Location = new System.Drawing.Point(156, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Name";
            // 
            // tbProductName
            // 
            this.tbProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProductName.Location = new System.Drawing.Point(290, 91);
            this.tbProductName.Name = "tbProductName";
            this.tbProductName.Size = new System.Drawing.Size(290, 26);
            this.tbProductName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label2.Location = new System.Drawing.Point(156, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Supplier";
            // 
            // cbSupplier
            // 
            this.cbSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSupplier.FormattingEnabled = true;
            this.cbSupplier.Location = new System.Drawing.Point(290, 127);
            this.cbSupplier.Name = "cbSupplier";
            this.cbSupplier.Size = new System.Drawing.Size(290, 28);
            this.cbSupplier.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label3.Location = new System.Drawing.Point(156, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Unit Price";
            // 
            // tbUnitPrice
            // 
            this.tbUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUnitPrice.Location = new System.Drawing.Point(290, 163);
            this.tbUnitPrice.Name = "tbUnitPrice";
            this.tbUnitPrice.Size = new System.Drawing.Size(290, 26);
            this.tbUnitPrice.TabIndex = 5;
            this.tbUnitPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbUnitPrice_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label4.Location = new System.Drawing.Point(156, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Package";
            // 
            // tbPackage
            // 
            this.tbPackage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPackage.Location = new System.Drawing.Point(290, 199);
            this.tbPackage.Name = "tbPackage";
            this.tbPackage.Size = new System.Drawing.Size(290, 26);
            this.tbPackage.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave.Location = new System.Drawing.Point(335, 289);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(103, 36);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Ubuntu", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(323, 32);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(93, 34);
            this.lbTitle.TabIndex = 9;
            this.lbTitle.Text = "label5";
            // 
            // lbDiscontinued
            // 
            this.lbDiscontinued.AutoSize = true;
            this.lbDiscontinued.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiscontinued.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lbDiscontinued.Location = new System.Drawing.Point(156, 239);
            this.lbDiscontinued.Name = "lbDiscontinued";
            this.lbDiscontinued.Size = new System.Drawing.Size(108, 21);
            this.lbDiscontinued.TabIndex = 6;
            this.lbDiscontinued.Text = "Discontinued";
            // 
            // checkDiscontinued
            // 
            this.checkDiscontinued.AutoSize = true;
            this.checkDiscontinued.Location = new System.Drawing.Point(290, 244);
            this.checkDiscontinued.Name = "checkDiscontinued";
            this.checkDiscontinued.Size = new System.Drawing.Size(142, 17);
            this.checkDiscontinued.TabIndex = 10;
            this.checkDiscontinued.Text = "Check if yes, leave if not";
            this.checkDiscontinued.UseVisualStyleBackColor = true;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(780, 411);
            this.Controls.Add(this.checkDiscontinued);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbPackage);
            this.Controls.Add(this.lbDiscontinued);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbUnitPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbSupplier);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbProductName);
            this.Controls.Add(this.label1);
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbProductName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbSupplier;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbUnitPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPackage;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbDiscontinued;
        private System.Windows.Forms.CheckBox checkDiscontinued;
    }
}