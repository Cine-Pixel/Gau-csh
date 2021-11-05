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
    public partial class Main : Form {
        public Main() {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e) {
            //dashboard1.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e) {
            string username = tbUsername.Text;
            string password = tbPassword.Text;

            string query = "SELECT TOP(1) * FROM dbo.Users WHERE Username=@Username AND Password=@Password";
            try {
                DataTable dt = DB.Query(query, new Dictionary<string, string> { { "Username", username }, { "Password", password } }); ;
                if(dt.Rows.Count == 1) {
                    dashboard1.Show();
                    dashboard1.BringToFront();
                } else {
                    MessageBox.Show("Invalid Username or password");
                }
            } catch(Exception ex) {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
