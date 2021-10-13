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
    public partial class FrmUser : Form {
        public FrmUser() {
            InitializeComponent();
        }

        public FrmUser(string title, string lbTitle, User user) {
            InitializeComponent();

            this.Text = title;
            this.lbTitle.Text = lbTitle;

            this.tbFirstName.Text = user.FirstName;
            this.tbFirstName.Text = user.LastName;
            this.tbPersonalNumber.Text = user.PersonalNumber;
            this.tbEmail.Text = user.EMail;
            this.dtpBirthDate.Value = (DateTime)user.BirthDate;
            this.tbPhoneNumber.Text = user.PhoneNumber;

            // TODO: figure out easy way to set gender and role comboboxes
        }

        public FrmUser(string title, string lbTitle) {
            InitializeComponent();

            this.Text = title;
            this.lbTitle.Text = lbTitle;
        }

        private void frmUser_Load(object sender, EventArgs e) {
            try {
                DataTable dtGender = GetData("SELECT ID, NameGE AS 'NAME'  FROM [EduDB].[dbo].[Gender]");

                cbGender.DataSource = dtGender;
                cbGender.DisplayMember = "Name";
                cbGender.ValueMember = "ID";

                DataTable dtRoles = GetData("SELECT ID, NameGE AS 'NAME'  FROM [EduDB].[dbo].[Roles]");

                cbRole.DataSource = dtRoles;
                cbRole.DisplayMember = "Name";
                cbRole.ValueMember = "ID";
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "მოხდა შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DataTable GetData(string query) {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["edu"].ConnectionString)) {
                using (SqlCommand com = new SqlCommand(query, conn)) {
                    conn.Open();
                    SqlDataReader sdr = com.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(sdr);
                    return dt;
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e) {
            try {
                User user = new User {
                    FirstName = tbFirstName.Text,
                    LastName = tbLastName.Text,
                    PersonalNumber = tbPersonalNumber.Text,
                    BirthDate = dtpBirthDate.Value.Date,
                    GenderID = (int)cbGender.SelectedValue,
                    PhoneNumber = tbPhoneNumber.Text,
                    EMail = tbEmail.Text,
                    RoleID = (int)cbRole.SelectedValue
                };

                string insertQuery = $"INSERT INTO Users"+
                    $"(FirstName, LastName, PersonalNumber, BirthDate, GenderID, PhoneNumber, EMail, RoleID)"+
                    $"VALUES (N'{user.FirstName}',N'{user.LastName}','{user.PersonalNumber}','{user.BirthDate.Value.ToString("dd.MM.yyyy")}',{user.GenderID},'{user.PhoneNumber}','{user.EMail}',{user.RoleID})";

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
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "მოხდა შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally {
                this.Close();
            }
        }
    }
}
