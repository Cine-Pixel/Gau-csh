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
    public partial class Dashboard : UserControl {
        private List<Product> products = new List<Product>();

        public Dashboard() {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e) {
            LoadGrid();
        }

        private void LoadGrid() {
            dtgProducts.DataSource = null;
            dtgProducts.Rows.Clear();
            dtgProducts.Refresh();
            products.Clear();

            try {
                products = Helper.GetAllProducts();
            } catch (Exception ex) {
                MessageBox.Show("Error getting products: "+ex.Message);
            }

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
                    row.Cells[9].Value = b.Id;
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
                    row.Cells[9].Value = a.Id;
                    dtgProducts.Rows.Add(row);
                } else {
                    EResourse r = product as EResourse;
                    row.Cells[0].Value = r.PName;
                    row.Cells[1].Value = r.Authors;
                    row.Cells[7].Value = r.Link;
                    row.Cells[8].Value = r.Authors;
                    row.Cells[9].Value = r.Id;
                    dtgProducts.Rows.Add(row);
                }
            }
        }

        private void btnLoadGrid_Click(object sender, EventArgs e) {
            LoadGrid();
        }

        private void btnAddBook_Click(object sender, EventArgs e) {
            BookForm bookForm = new BookForm();
            bookForm.Show();
        }

        private void btnAddArticle_Click(object sender, EventArgs e) {
            ArticleForm articleForm = new ArticleForm();
            articleForm.Show();
        }

        private void btnAddResourse_Click(object sender, EventArgs e) {
            EResourseForm eResourseForm = new EResourseForm();
            eResourseForm.Show();
        }

        private void btnSearchDate_Click(object sender, EventArgs e) {
            DateTime from = dtFrom.Value;
            DateTime to = dtTo.Value;
            List<Product> filtered = Product.Search(products, from, to);
            if(filtered.Count > 0) {
                FilteredFrom filteredFrom = new FilteredFrom(filtered);
                filteredFrom.Show();
            } else {
                MessageBox.Show("No items in this range");
            }
        }

        private void btnTopM_Click(object sender, EventArgs e) {
            int m = (int)numTopM.Value;
            List<Product> filtered = Product.TopM(products, m);
            if(filtered.Count > 0) {
                FilteredFrom filteredFrom = new FilteredFrom(filtered);
                filteredFrom.Show();
            } else {
                MessageBox.Show("No items in this range");
            }
        }

        private void btnTopAuthors_Click(object sender, EventArgs e) {
            DataTable topAuthors = DB.Procedure("TopAuthors");
            AuthorsForm authorsForm = new AuthorsForm(topAuthors);
            authorsForm.Show();
        }

        private void btnViewArchive_Click(object sender, EventArgs e) {
            ArchiveForm archive = new ArchiveForm();
            archive.Show();
        }
    }
}
