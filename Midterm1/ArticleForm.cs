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
    public partial class ArticleForm : Form {
        public ArticleForm() {
            InitializeComponent();
        }

        private void btnArticleSave_Click(object sender, EventArgs e) {
            Dictionary<string, string> parameters = new Dictionary<string, string>() {
                {"Name", tbArticleName.Text},
                {"Number", numNumber.Value.ToString()},
                {"PublishDate", dtPublishDate.Value.ToString("yyyy-MM-dd")},
                {"PageNumber", numPageNumber.Value.ToString()},
                {"JournalName", tbJournal.Text},
                {"AuthorFirstName", tbAuthorFn.Text},
                {"AuthorLastName",  tbAuthorLn.Text} 
            };
            try {
                DB.Procedure("InsertArticle", parameters);
                MessageBox.Show("Article inserted succesfully");
                this.Close();
            } catch(Exception ex) {
                MessageBox.Show("Article cannot be inserted: " + ex.Message);
            }
        }
    }
}
