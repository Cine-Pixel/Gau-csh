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
    public partial class EResourseForm : Form {
        public EResourseForm() {
            InitializeComponent();
        }

        private void btnResSave_Click(object sender, EventArgs e) {
            Dictionary<string, string> parameters = new Dictionary<string, string>() {
                {"Name", tbResName.Text },
                {"Link", tbLink.Text },
                {"Annotation", tbAnnotation.Text },
                {"AuthorFirstName", tbAuthorFn.Text },
                {"AuthorLastName", tbAuthorLn.Text }
            };
            try {
                DB.Procedure("InsertEResourse", parameters);
                MessageBox.Show("Succesfully inserted EResourse");
                this.Close();
            }
            catch(Exception ex) {
                MessageBox.Show("Cannot insert EResourse: " + ex.Message);
            }
        }
    }
}
