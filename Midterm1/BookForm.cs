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
    public partial class BookForm : Form {
        public BookForm() {
            InitializeComponent();
        }

        private void btnBookSave_Click(object sender, EventArgs e) {
            Dictionary<string, string> parameters = new Dictionary<string, string>() {
                {"Name",  tbBookName.Text},
                {"PageNumber", numPageNumber.Value.ToString()},
                {"PublishDate", dtPublishDate.Value.ToString("yyyy-MM-dd")},
                {"Publisher", tbPublisher.Text },
                {"AuthorFirstName", tbAuthorFn.Text },
                {"AuthorLastName", tbAuthorLn.Text }
            };
            try {
                DB.Procedure("InsertBook", parameters);
                MessageBox.Show("Book succesfully added");
                this.Close();
            } catch(Exception ex) {
                MessageBox.Show("Book cannot be insesrted: "+ex.Message);
            }
        }
    }
}
