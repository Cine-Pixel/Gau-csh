using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm1 {
    public static class DB {
        public static void NonQuery(string query) {
			using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["company"].ConnectionString)) {
				using (SqlCommand com = new SqlCommand(query, conn)) {
					try {
						conn.Open();
						com.ExecuteNonQuery();
					}
					catch (Exception ex) {
						throw new Exception($"error {ex}");
					}
				}
			}
		}

		public static DataTable Procedure(string name) {
			using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["company"].ConnectionString)) {
				using (SqlCommand com = new SqlCommand(name, conn)) {
					try {
						com.CommandType = CommandType.StoredProcedure;
						conn.Open();
						SqlDataReader sdr = com.ExecuteReader();
						DataTable dt = new DataTable();
						dt.Load(sdr);
						return dt;
					}
					catch (Exception ex) {
						throw new Exception($"error {ex}");
					}
				}
			}
		}

		public static DataTable Procedure(string name, Dictionary<string, string> parameters) {
			using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["company"].ConnectionString)) {
				using (SqlCommand com = new SqlCommand(name, conn)) {
					try {
						com.CommandType = CommandType.StoredProcedure;
						conn.Open();
						foreach(KeyValuePair<string, string> pair in parameters) {
							com.Parameters.AddWithValue($"@{pair.Key}", pair.Value);
                        }
						SqlDataReader sdr = com.ExecuteReader();
						DataTable dt = new DataTable();
						dt.Load(sdr);
						return dt;
					}
					catch (Exception ex) {
						throw new Exception($"error {ex}");
					}
				}
			}
		}
		
		public static DataTable Query(string query) {
			using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["company"].ConnectionString)) {
				using (SqlCommand com = new SqlCommand(query, conn)) {
					try {
						conn.Open();
						SqlDataReader sdr = com.ExecuteReader();
						DataTable dt = new DataTable();
						dt.Load(sdr);
						return dt;
					}
					catch (Exception ex) {
						throw new Exception($"error {ex}");
					}
				}
			}
		}
		
		public static DataTable Query(string query, Dictionary<string, string> parameters) {
			using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["company"].ConnectionString)) {
				using (SqlCommand com = new SqlCommand(query, conn)) {
					try {
						conn.Open();
						foreach(KeyValuePair<string, string> pair in parameters) {
							com.Parameters.AddWithValue($"@{pair.Key}", pair.Value);
                        }

						SqlDataReader sdr = com.ExecuteReader();
						DataTable dt = new DataTable();
						dt.Load(sdr);
						return dt;
					}
					catch (Exception ex) {
						throw new Exception($"error {ex}");
					}
				}
			}
		}
    }
}
