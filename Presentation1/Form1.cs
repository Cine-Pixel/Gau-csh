using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation1 {
    public partial class Form1 : Form {
        public delegate void UpdateDataGridDelegate(SqlDataReader sdr);
        public delegate void HandleErrorDelegate(string text);
        public delegate void SetStatusDelegate(string text);
        public delegate void SetQueryingDelegate(bool status);

        private bool isFormLoaded;
        private bool isQuerying;

        private SqlConnection conn = null;

        public Form1() {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e) {
            try {
                dtgProducts.DataSource = null;
                dtgProducts.Rows.Clear();
                dtgProducts.Refresh();

                dtgProducts.DataSource = await LoadProducts();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "მოხდა შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task<DataTable> LoadProducts() {
            string connString = ConfigurationManager.ConnectionStrings["Store"].ConnectionString;
            string query = @"WAITFOR DELAY '00:00:05'; SELECT * FROM dbo.Products;";
            DataTable dt = new DataTable();

            try {
                SetStatus("Loading...");
                conn = new SqlConnection(connString); 
                SqlCommand com = new SqlCommand(query, conn);           
                conn.Open();
                SqlDataReader sdr = await com.ExecuteReaderAsync();
                dt.Load(sdr);
                SetStatus("Loaded");
            } catch(Exception ex) {
                throw ex;
            } finally {
                conn.Close();
                conn.Dispose();
                isFormLoaded = true;
            }
            return dt; 
        }

        private void btnMax_Click(object sender, EventArgs e) {
            if(!isFormLoaded) {
                MessageBox.Show("Wait for form to load");
                return;
            }

            DataGridViewRow maxRow = dtgProducts.Rows.Cast<DataGridViewRow>()
                .Aggregate((r1, r2) 
                    => Convert.ToInt32(r1.Cells["Quantity"].Value) > Convert.ToInt32(r2.Cells["Quantity"].Value) ? r1 : r2);
            MessageBox.Show($"Product with max quantity {maxRow.Cells["Name"].Value} - {maxRow.Cells["Quantity"].Value}");
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            if(!isFormLoaded) {
                MessageBox.Show("Wait for form to laod");
                return;
            }
            if(isQuerying) {
                MessageBox.Show("Already querying database");
                return;
            }

            Product product = new Product {
                Name = tbProductName.Text,
                Quantity = (int)numQuantity.Value,
            };

            string connString = ConfigurationManager.ConnectionStrings["Store"].ConnectionString;
            try {
                SetStatus("Querying database...");
                isQuerying = true;
                conn = new SqlConnection(connString);
                SqlCommand com = new SqlCommand("InsertProduct", conn) {
                    CommandType = CommandType.StoredProcedure
                };
                com.Parameters.AddWithValue("@Name", product.Name);
                com.Parameters.AddWithValue("@Quantity", product.Quantity);

                conn.Open();

                AsyncCallback callback = new AsyncCallback(HandleCallBack);
                com.BeginExecuteReader(callback, com);
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
                if(conn != null)
                    conn.Close();
            }
        }

        private void HandleCallBack(IAsyncResult result) {
            try {
                SqlCommand com = (SqlCommand)result.AsyncState;
                SqlDataReader reader = com.EndExecuteReader(result);

                UpdateDataGridDelegate del = new UpdateDataGridDelegate(UpdateDataGrid);
                this.Invoke(del, reader);
            } catch(Exception ex) {
                this.Invoke(new HandleErrorDelegate(HandleError), ex.Message);
            } finally {
                this.Invoke(new SetStatusDelegate(SetStatus), "Loaded");
                this.Invoke(new SetQueryingDelegate(SetQuerying), false);
            }
        }

        private void UpdateDataGrid(SqlDataReader sdr) {
            try {
                DataTable dt = new DataTable();
                dt.Load(sdr);
                DataTable oldSource = (DataTable)dtgProducts.DataSource;
                DataRow newRow = dt.Rows[0];
                oldSource.Rows.Add(newRow.ItemArray);
                oldSource.AcceptChanges();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
                throw ex;
            }
        }

        private void HandleError(string text) {
            MessageBox.Show(text);
        }

        private void SetStatus(string text) {
            lbStatus.Text = $"Status: {text}";
        }

        private void SetQuerying(bool status) {
            isQuerying = false;
        }
    }
}
