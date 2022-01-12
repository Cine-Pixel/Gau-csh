using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework9 {
    public partial class Main : Form {
        string searchBy = "Name";
        public Main() {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e) {
            LoadGrid();
            searchBy = "Name";
            dateFrom.Visible = false;
            dateTo.Visible = false;
        }

        private void LoadGrid() {
            tbSearch.Text = "";

            try {
                dtgProducts.DataSource = null;

                EcommEntities db = new EcommEntities();
                var products = db.Products.Select(p => new {
                    Id = p.Id,
                    Name = p.ProductName,
                    UnitPrice = p.UnitPrice,
                    Supplier = p.Supplier.CompanyName,
                    Package = p.Package,
                    IsDiscontinued = p.IsDiscontinued
                }).ToList();

                dtgProducts.DataSource = products;
            } catch(Exception ex) {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnLoad_Click(object sender, EventArgs e) {
            LoadGrid();
        }

        private void btnCreate_Click(object sender, EventArgs e) {
            ProductForm productForm = new ProductForm();
            productForm.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e) {
            if(dtgProducts.SelectedRows.Count != 1) {
                MessageBox.Show("Please select 1 product");
                return;
            }

            try {
                EcommEntities db = new EcommEntities();
                int id = (int)dtgProducts.SelectedRows[0].Cells[0].Value;
                Product product = db.Products.Where(p => p.Id == id).First();

                ProductForm productForm = new ProductForm(product);
                productForm.Show();
            } catch (Exception ex) {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            if(dtgProducts.SelectedRows.Count != 1) {
                MessageBox.Show("Please select 1 product");
                return;
            }
            
            try {
                int id = (int)dtgProducts.SelectedRows[0].Cells[0].Value;
                EcommEntities db = new EcommEntities();
                Product product = db.Products.Where(p => p.Id == id).First();
                db.Products.Remove(product);
                db.SaveChanges();
                LoadGrid();
            } catch(Exception ex) {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e) {
            if(this.searchBy.Equals("Name"))
                this.SearchByName();
            else 
                this.SearchByDates();
        }

        private void SearchByName() {
            try {
                string keyword = tbSearch.Text;
                EcommEntities db = new EcommEntities();
                var query = db.Products.Select(p => new {
                    Id = p.Id,
                    Name = p.ProductName,
                    UnitPrice = p.UnitPrice,
                    Supplier = p.Supplier.CompanyName,
                    Package = p.Package,
                    IsDiscontinued = p.IsDiscontinued
                }).AsQueryable();

                var filtered = query.Where(p => p.Name.Contains(keyword));
                dtgProducts.DataSource = filtered.ToList();
            } catch(Exception ex) {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private void SearchByDates() {
            try {
                DateTime from = dateFrom.Value;
                DateTime to = dateTo.Value;

                EcommEntities db = new EcommEntities();
                var query = (from p in db.Products
                             join oi in db.OrderItems on p.Id equals oi.ProductId
                             join o in db.Orders on oi.OrderId equals o.Id
                             select new {
                                Id = p.Id,
                                Name = p.ProductName,
                                UnitPrice = p.UnitPrice,
                                Supplier = p.Supplier.CompanyName,
                                Package = p.Package,
                                IsDiscontinued = p.IsDiscontinued,
                                date = o.OrderDate
                             }).AsQueryable();

                var filtered = query.Where(p => p.date > from && p.date < to);
                dtgProducts.DataSource = filtered.ToList();
            } catch(Exception ex) {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void cbSearchBy_SelectedIndexChanged(object sender, EventArgs e) {
            if(cbSearchBy.Text.Equals("Name")) {
                this.searchBy = "Name";
                tbSearch.Visible = true;
                dateFrom.Visible = false;
                dateTo.Visible = false;
            } else {
                this.searchBy = "Dates";
                dateFrom.Visible = true;
                dateTo.Visible = true;
                tbSearch.Visible = false;
            }
        }
    }
}
