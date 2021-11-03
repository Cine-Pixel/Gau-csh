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
        private string action;
        private User user;

        public FrmUser() {
            InitializeComponent();
        }

        public FrmUser(string title, string lbTitle, User user) {
            InitializeComponent();

            this.action = "edit";
            this.user = user;

            this.Text = title;
            this.lbTitle.Text = lbTitle;

            this.tbFirstName.Text = user.FirstName;
            this.tbLastName.Text = user.LastName;
            this.tbPersonalNumber.Text = user.PersonalNumber;
            this.tbEmail.Text = user.EMail;
            this.dtpBirthDate.Value = user.BirthDate ?? DateTime.Now; 
            this.tbPhoneNumber.Text = user.PhoneNumber;

            // TODO: figure out easy way to set gender and role comboboxes
        }

        public FrmUser(string title, string lbTitle) {
            InitializeComponent();

            this.user = new User();
            this.Text = title;
            this.lbTitle.Text = lbTitle;
            this.action = "add"; 
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
                this.user.FirstName = tbFirstName.Text;
                this.user.LastName = tbLastName.Text;
                this.user.PersonalNumber = tbPersonalNumber.Text;
                this.user.BirthDate = dtpBirthDate.Value.Date;
                this.user.GenderID = (int)cbGender.SelectedValue;
                this.user.PhoneNumber = tbPhoneNumber.Text;
                this.user.EMail = tbEmail.Text;
                this.user.RoleID = (int)cbRole.SelectedValue;

                string query;

                if (this.action.Equals("add")) {
                    query = $"INSERT INTO Users"+
                        $"(FirstName, LastName, PersonalNumber, BirthDate, GenderID, PhoneNumber, EMail, RoleID)"+
                        $"VALUES (N'{this.user.FirstName}',N'{this.user.LastName}','{this.user.PersonalNumber}','{this.user.BirthDate.Value.ToString("dd.MM.yyyy")}',{this.user.GenderID},'{this.user.PhoneNumber}','{this.user.EMail}',{this.user.RoleID})";
                } else {
                    query = $"UPDATE Users "+
                        $"SET FirstName = N'{this.user.FirstName}', LastName = N'{this.user.LastName}', PersonalNumber = '{this.user.PersonalNumber}', "+
                        $"BirthDate = '{this.user.BirthDate.Value.ToString("dd.MM.yyyy")}', GenderID = {this.user.GenderID}, " +
                        $"PhoneNumber = '{this.user.PhoneNumber}', EMail = '{this.user.EMail}', RoleID = {this.user.RoleID} "+
                        $"WHERE Users.ID = {this.user.ID};";
                }

                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["edu"].ConnectionString)) {
                    using (SqlCommand com = new SqlCommand(query, conn)) {
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
