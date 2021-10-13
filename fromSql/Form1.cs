using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace fromSql {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnImport_Click(object sender, EventArgs e) {
            try {
                dataGridStudents.Rows.Clear();

                #region Connection sring creation

                string connString = "Data Source=PSE51\\SQLEXPRESS; Initial Catalog = University; Trusted_Connection = True;";
                #endregion

                #region Command Generation 
                //string query = "SELECT id, CONCAT(first_name, ' ', last_name), reg_date FROM Student";
                string query = "SELECT * FROM Student";
                SqlConnection conn = new SqlConnection(connString);
                if (conn.State == ConnectionState.Closed) {
                    conn.Open();
                }
                SqlCommand command = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                conn.Close();
                conn.Dispose();
                #endregion

                dataGridStudents.DataSource = dataSet.Tables[0];
                //int rowIndex = 0;
                //foreach(DataRow row in dataSet.Tables[0].Rows) {
                //    dataGridStudents.Rows.Add();
                //    dataGridStudents.Rows[rowIndex].Cells["N"].Value = row[0];
                //    dataGridStudents.Rows[rowIndex].Cells["StudentFullName"].Value = row[1];
                //    dataGridStudents.Rows[rowIndex].Cells["RegDate"].Value = row[2];
                //    rowIndex++;
                //}
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
