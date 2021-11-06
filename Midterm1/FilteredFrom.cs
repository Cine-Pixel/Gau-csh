using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Midterm1 {
    public partial class FilteredFrom : Form {
        public FilteredFrom() {
            InitializeComponent();
        }
        public FilteredFrom(List<Product> filtered) {
            InitializeComponent();
            LoadGrid(filtered);
        }

        private void LoadGrid(List<Product> products) {
            dtgProducts.DataSource = null;
            dtgProducts.Rows.Clear();
            dtgProducts.Refresh();

            dtgProducts.AutoGenerateColumns = false;

            foreach(var product in products) {
                DataGridViewRow row = (DataGridViewRow)dtgProducts.Rows[0].Clone();

                if(product.GetType() == typeof(Book)) {
                    Book b = product as Book;
                    row.Cells[0].Value = b.PName;
                    row.Cells[1].Value = b.Authors;
                    row.Cells[2].Value = b.PublishDate;
                    row.Cells[3].Value = b.Publisher;
                    row.Cells[4].Value = b.PageNumber;
                    dtgProducts.Rows.Add(row);
                }
                else if (product.GetType() == typeof(Article)) {
                    Article a = product as Article;
                    row.Cells[0].Value = a.PName;
                    row.Cells[1].Value = a.Authors;
                    row.Cells[2].Value = a.PublishDate;
                    row.Cells[4].Value = a.PageNumber;
                    row.Cells[5].Value = a.JournalName;
                    row.Cells[6].Value = a.Number;
                    dtgProducts.Rows.Add(row);
                } else {
                    EResourse r = product as EResourse;
                    row.Cells[0].Value = r.PName;
                    row.Cells[1].Value = r.Authors;
                    row.Cells[7].Value = r.Link;
                    row.Cells[8].Value = r.Authors;
                    dtgProducts.Rows.Add(row);
                }
            }
        }
    }
}
