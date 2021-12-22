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
    public partial class OrdersForm : Form {
        public OrdersForm() {
            InitializeComponent();
        }

        private void OrdersForm_Load(object sender, EventArgs e) {
            LoadGrid();
        }
        
        private void LoadGrid() {
            dtgOrders.DataSource = null;

            WarehouseModelContext db = new WarehouseModelContext();
            var orders = (from o in db.Orders
                         join oi in db.OrderItems on o.Id equals oi.OrderId
                         join p in db.Products on oi.ProductId equals p.Id
                         join c in db.Customers on o.CustomerId equals c.Id
                         select new {
                             OrderId = o.Id,
                             OrderNumber = o.OrderDate,
                             ProductName = p.ProductName,
                             CustomerFirstName = c.FirstName,
                             CustomerLastName = c.FirstName
                         }).Distinct();
            dtgOrders.DataSource = orders.ToList();
        }

        private void btnRefresh_Click(object sender, EventArgs e) {
            LoadGrid();
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            AddOrderForm addOrder = new AddOrderForm("create");
            addOrder.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            if(dtgOrders.SelectedRows.Count != 1) {
                MessageBox.Show("Please select product first");
                return;
            }
            
            try {
                int id = (int)dtgOrders.SelectedRows[0].Cells[0].Value;
                WarehouseModelContext db = new WarehouseModelContext();
                OrderItem orderItem = db.OrderItems.Where(oi => oi.Id == id).First();
                db.OrderItems.Remove(orderItem);
                db.SaveChanges();
                LoadGrid();
            } catch(Exception ex) {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
