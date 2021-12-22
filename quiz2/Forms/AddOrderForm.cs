using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using quiz2.EF;
using quiz2.EF.models;

namespace quiz2.Forms {
    public partial class AddOrderForm : Form {
        string action;

        public AddOrderForm() {
            InitializeComponent();
        }
        public AddOrderForm(string action) {
            InitializeComponent();
            this.action = action;
        }

        private void AddOrderForm_Load(object sender, EventArgs e) {
            WarehouseModelContext db = new WarehouseModelContext();
            cbProducts.DataSource = db.Products.ToList();
            cbProducts.DisplayMember = "ProductName";
            cbProducts.ValueMember = "Id";
        }

        private void btnSave_Click(object sender, EventArgs e) {
                WarehouseModelContext db = new WarehouseModelContext();
                if (this.action == "create") {
                    Product product = db.Products.Where(p => p.Id == (int)cbProducts.SelectedValue).First();
                    Customer customer = new Customer() {
                        FirstName = tbFirstName.Text,
                        LastName = tbLastName.Text,
                        City = tbCity.Text,
                        Country = tbCountry.Text,
                        Phone = tbPhone.Text
                    };
                    Order order = new Order() {
                        OrderDate = DateTime.Now,
                        OrderNumber = "sdftf23",
                        TotalAmount = 5,
                        Customer = customer
                    };
                    OrderItem orderItem = new OrderItem() {
                        Order = order,
                        Product = product,
                        Quantity = (int)numQuantity.Value
                    };
                    db.OrderItems.Add(orderItem);
                    db.SaveChanges();
                    MessageBox.Show("Order created successfully");
                    this.Close();
                } 
        }
    }
}
