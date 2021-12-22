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
using quiz2.Forms;

namespace quiz2 {
    public partial class Main : Form {
        public Main() {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e) {
            LoadGrid(); 
        }
        private void LoadGrid() {
            dtgProducts.DataSource = null;

            WarehouseModelContext db = new WarehouseModelContext();
            dtgProducts.DataSource = db.Products.Select(p => new { 
                Id = p.Id,
                ProductName = p.ProductName,
                SupplierName = p.Supplier.CompanyName,
                UnitPrice = p.UnitPrice,
                Package = p.Package,
                SupplierId = p.Supplier.Id
            }).ToList();
        }

        private void btnRefresh_Click(object sender, EventArgs e) {
            LoadGrid();
        }

        private void btnCreate_Click(object sender, EventArgs e) {
            ProductForm productForm = new ProductForm("create");
            productForm.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            if(dtgProducts.SelectedRows.Count != 1) {
                MessageBox.Show("Please select product first");
                return;
            }
            
            try {
                int id = (int)dtgProducts.SelectedRows[0].Cells[0].Value;
                WarehouseModelContext db = new WarehouseModelContext();
                Product product = db.Products.Where(p => p.Id == id).First();
                db.Products.Remove(product);
                db.SaveChanges();
                LoadGrid();
            } catch(Exception ex) {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e) {
            if(dtgProducts.SelectedRows.Count != 1) {
                MessageBox.Show("Please select product first");
                return;
            }

            ProductDTO product = new ProductDTO {
                Id = (int)dtgProducts.SelectedRows[0].Cells[0].Value,
                ProductName = (string)dtgProducts.SelectedRows[0].Cells[1].Value,
                UnitPrice = (decimal)dtgProducts.SelectedRows[0].Cells[3].Value,
                Package = (string)dtgProducts.SelectedRows[0].Cells[4].Value,
                SupplierId = (int)dtgProducts.SelectedRows[0].Cells[5].Value,
            };

            ProductForm productForm = new ProductForm("update", product);
            productForm.Show();
        }

        private void btnOrders_Click(object sender, EventArgs e) {
            OrdersForm ordersForm = new OrdersForm();
            ordersForm.Show();
        }
    }
}
