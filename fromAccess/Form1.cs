using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace fromAccess {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        private void btnImport_Click(object sender, EventArgs e) {
            try {
                dataGridStudents.Rows.Clear();
                OpenFileDialog file = new();
                file.Title = "აირჩიეთ ექსელის ფაილი.";
                file.InitialDirectory = @"c:\projects";
                file.FileName = tBoxInput.Text;
                file.Filter = "Excel Sheet(*.xls)|*.xls|Excel Sheet(*.xlsx)|*.xlsx|All Files(*.*)|*.*";
                file.FilterIndex = 1;
                file.RestoreDirectory = true;

                if (file.ShowDialog() == DialogResult.OK) {

                    #region Connection sring creation
                    tBoxInput.Text = file.FileName;
                    string fileExtension = Path.GetExtension(tBoxInput.Text).ToLower().Trim();
                    string path = tBoxInput.Text;

                    string connString;
                    if (fileExtension.Equals(".xls")) {
                        connString = $"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={path};Extended Properties=\"Excel 8.0;HDR=YES;IMEX=2\"";
                    }
                    else {
                        connString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={path};Extended Properties=\"Excel 12.0;HDR=YES;IMEX=2\"";
                    }
                    #endregion

                    #region Query Creation
                    string query = "SELECT * FORM students";
                    OleDbConnection conn = new(connString);
                    if (conn.State == ConnectionState.Closed) {
                        conn.Open();
                    }
                    OleDbCommand command = new(query, conn);
                    OleDbDataAdapter adapter = new(command);
                    DataSet dataSet = new();
                    adapter.Fill(dataSet);
                    conn.Close();
                    conn.Dispose();
                    #endregion

                    // dataGridStudents.DataSource = dataSet.Tables[0];
                    int rowIndex = 0;
                    foreach(DataRow row in dataSet.Tables[0].Rows) {
                        dataGridStudents.Rows.Add();
                        dataGridStudents.Rows[rowIndex].Cells["N"].Value = row[0];
                        dataGridStudents.Rows[rowIndex].Cells["StudentFullName"].Value = row[2];
                        dataGridStudents.Rows[rowIndex].Cells["RegDate"].Value = row[2];
                        rowIndex++;
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
