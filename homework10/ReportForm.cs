using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework10 {
    public partial class ReportForm : Form {
        public ReportForm() {
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e) {
            try {
                using(EcommEntities db = new EcommEntities()) {
                    ProductBindingSource.DataSource = db.Products
                        .Select(p => new { 
                            Id = p.Id,
                            ProductName = p.ProductName,
                            UnitPrice = p.UnitPrice,
                            Package = p.Package,
                            Supplier = p.Supplier.CompanyName
                        }).ToList();
                    this.reportViewer1.RefreshReport();
                } 
            } catch(Exception ex) {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
