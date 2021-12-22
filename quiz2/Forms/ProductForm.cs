using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using quiz2.DTO;
using quiz2.EF;
using quiz2.EF.models;

namespace quiz2.Forms {
    public partial class ProductForm : Form {
        string action;
        ProductDTO product;
        public ProductForm() {
            InitializeComponent();
        }

        public ProductForm(string action) {
            InitializeComponent();
            this.action = action;
        }

        public ProductForm(string action, ProductDTO product) {
            InitializeComponent();
            this.action = action;
            this.product = product;
        }

        private void ProductForm_Load(object sender, EventArgs e) {
            WarehouseModelContext db = new WarehouseModelContext();
            cbSupplier.DataSource = db.Suppliers.ToList();
            cbSupplier.DisplayMember = "CompanyName";
            cbSupplier.ValueMember = "Id";

            if(this.action.Equals("create")) {
                lbTitle.Text = "Add Product";
            } else {
                lbTitle.Text = "Update Product";
                tbProductName.Text = product.ProductName;
                tbPackage.Text = product.Package;
                numUnitPrice.Value = product.UnitPrice;
                cbSupplier.SelectedValue = product.SupplierId;
            }
        }

        private void btnSave_Click(object sender, EventArgs e) {
            try {
                WarehouseModelContext db = new WarehouseModelContext();
                if(this.action == "create") {
                    Product product = new Product() {
                        ProductName = tbProductName.Text,
                        Package = tbPackage.Text,
                        SupplierId = (int)cbSupplier.SelectedValue,
                        UnitPrice = (decimal)numUnitPrice.Value 
                    };
                    db.Products.Add(product);
                    db.SaveChanges();

                    MessageBox.Show("Succesfully added product");
                    this.Close();
                } else {
                    Product product = db.Products.Where(p => p.Id == this.product.Id).First();
                    product.ProductName = tbProductName.Text;
                    product.SupplierId = (int)cbSupplier.SelectedValue;
                    product.Package = tbPackage.Text;
                    product.UnitPrice= (decimal)numUnitPrice.Value;
                    db.SaveChanges();

                    MessageBox.Show("Successfully updated product");
                }
            } catch(Exception ex) {
                MessageBox.Show($"Error - {ex.Message}");
            }
        }
    }
}
