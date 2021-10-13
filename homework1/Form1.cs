using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace homework1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            this.LoadForm();
        }

        private void LoadForm() {
            try {
                string connString = ConfigurationManager.ConnectionStrings["edu"].ConnectionString;

                dtgUsers.DataSource = null;
                dtgUsers.Rows.Clear();
                dtgUsers.Refresh();

                string query = @"SELECT * FROM Users JOIN Gender on Users.GenderID = Gender.ID JOIN Roles on Users.RoleID = Roles.ID";

                SqlConnection conn = new SqlConnection(connString);
                SqlCommand com = new SqlCommand(query, conn);
                SqlDataReader sdr = null;
                DataTable dt = new DataTable();

                try {
                    conn.Open();
                    sdr = com.ExecuteReader();

                    dt.Load(sdr);
                } catch (Exception ex) {
                    throw ex;
                } finally {
                    conn.Close();
                    conn.Dispose();

                    dtgUsers.DataSource = dt;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "მოხდა შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            FrmUser frm = new FrmUser("Add new User", "Add User");
            frm.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Are you sure you want to delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                int selectedRowCount = dtgUsers.SelectedRows.Count;
                if (selectedRowCount == 1) {
                    DataGridViewRow row = dtgUsers.SelectedRows[0];
                    DataGridViewCellCollection cells = row.Cells;

                    int id = (int)cells[0].Value;

                    string insertQuery = $"DELETE FROM Users WHERE Users.ID={id}";

                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["edu"].ConnectionString)) {
                        using (SqlCommand com = new SqlCommand(insertQuery, conn)) {
                            conn.Open();
                            try {
                                com.ExecuteNonQuery();
                            }
                            catch (Exception ex) {
                                throw new Exception($"შეცდომა მოხდა ბაზის მხარეს: {ex.Message}");
                            }
                        }
                    }

                }
            } else {
                MessageBox.Show("Please select only one row");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e) {

            int selectedRowCount = dtgUsers.SelectedRows.Count;
            if (selectedRowCount == 1) {
                DataGridViewRow row = dtgUsers.SelectedRows[0];
                DataGridViewCellCollection cells = row.Cells;

                User user = new User {
                    ID = (int)cells[0].Value,
                    FirstName = (string)cells[1].Value,
                    LastName = (string)cells[2].Value,
                    PersonalNumber = !(cells[3].Value is DBNull) ? (string)cells[3].Value : "",
                    //BirthDate = (DateTime?)cells[4].Value,
                    GenderID = (int)cells[5].Value,
                    PhoneNumber = (string)cells[6].Value,
                    EMail = (string)cells[7].Value,
                    RoleID = (int)cells[8].Value
                };
                user.BirthDate = (DateTime?)cells[4].Value;
                FrmUser frm = new FrmUser("Edit User", "Edit User", user);

            } else {
                MessageBox.Show("Please select only one row");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e) {
            this.LoadForm();
        }
    }
}
