using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using homework9.enums;

namespace homework9 {
    public partial class ProductForm : Form {
        private ProductFormActionEnum action;
        private Product product;

        public ProductForm() {
            InitializeComponent();
            this.action = ProductFormActionEnum.create;
            lbDiscontinued.Visible = false;
            checkDiscontinued.Visible = false;
        }

        public ProductForm(Product product) {
            InitializeComponent();
            this.action = ProductFormActionEnum.update;
            this.product = product;
        }

        private void ProductForm_Load(object sender, EventArgs e) {
            try {
                EcommEntities db = new EcommEntities();
                cbSupplier.DataSource = db.Suppliers.ToList();
                cbSupplier.DisplayMember = "CompanyName";
                cbSupplier.ValueMember = "Id";

                if(this.action == ProductFormActionEnum.create) {
                    lbTitle.Text = "Create Product";
                } else {
                    lbTitle.Text = "Update Product";
                    tbProductName.Text = product.ProductName;
                    cbSupplier.SelectedValue = product.Supplier.Id;
                    tbUnitPrice.Text = product.UnitPrice.ToString();
                    tbPackage.Text = product.Package;
                    checkDiscontinued.Checked = product.IsDiscontinued;
                } 
            } catch(Exception ex) {
                MessageBox.Show($"error: {ex.Message}");
                this.Close();
            }
        }

        private void tbUnitPrice_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
        }

        private void btnSave_Click(object sender, EventArgs e) {
            try {
                EcommEntities db = new EcommEntities();
                decimal unitPrice;
                bool isValid = decimal.TryParse(tbUnitPrice.Text, out unitPrice);
                if(!isValid) {
                    MessageBox.Show("Invalid unit price");
                    return;
                }

                if(this.action == ProductFormActionEnum.create) {
                    db.Products.Add(new Product() {
                        ProductName = tbProductName.Text,
                        SupplierId = (int)cbSupplier.SelectedValue,
                        UnitPrice = unitPrice,
                        Package = tbPackage.Text,
                    });
                    db.SaveChanges();

                    MessageBox.Show("Successfully created product");
                } else {
                    Product product = db.Products.Where(p => p.Id == this.product.Id).First();
                    product.ProductName = tbProductName.Text;
                    product.SupplierId = (int)cbSupplier.SelectedValue;
                    product.UnitPrice = unitPrice;
                    product.Package = tbPackage.Text;
                    product.IsDiscontinued = checkDiscontinued.Checked;
                    db.SaveChanges();

                    MessageBox.Show("Successfully updated product");
                }

                this.Close();
            } catch(Exception ex) {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
