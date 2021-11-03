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

namespace Lecture6 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e) {
            try {
                #region Generate InputData
                Author author = new Author();
                author.FirstName = "Gvantsa";
                author.LastName = "Tsulaia";
                author.BirthDate = new DateTime(1965, 1, 31);

                List<Book> books = new List<Book>();
                books.Add(new Book() {
                    Name = "Linq",
                    Description = "Linq",
                    Publisher = "biblusi",
                    PageNumber = 500,
                    ISBN = "2356657"
                });
                books.Add(new Book() {
                    Name = "Python",
                    Description = "Python",
                    Publisher = "biblusi",
                    PageNumber = 500,
                    ISBN = "2"
                });
                //books.Add(new Book() {
                //    Name = "Javascript",
                //    Description = "Javascript",
                //    Publisher = "biblusi",
                //    PageNumber = 400,
                //    ISBN = "5"
                //});
                //books.Add(new Book() {
                //    Name = "PHP",
                //    Description = "PHP",
                //    Publisher = "biblusi",
                //    PageNumber = 500,
                //    ISBN = "123213"
                //});

                author.Books = books;
                #endregion

                string queryAuthor = "INSERT INTO [dbo].[Authors] ([FirstName] ,[LastName], [BirthDate]) OUTPUT INSERTED.Id VALUES(@FirstName, @LastName, @BirthDate);";
                string queryBook = "INSERT INTO [dbo].[Books] ([Name],[Description],[Publisher],[PageNumber],[ISBN]) OUTPUT INSERTED.Id VALUES(@Name, @Description, @Publisher, @PageNumber, @ISBN);";
                string queryAuthorToBook = "INSERT INTO [dbo].[AuthorsToBooks] ([AuthorId],[BookId]) VALUES(@AuthorId, @BookId);";

                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["library"].ConnectionString)) {
                    conn.Open();
                    using (SqlTransaction tran = conn.BeginTransaction()) {

                        try {
                            int authorId;

                            string checkQuery = $"IF EXISTS (SELECT a.id FROM dbo.Authors AS a WHERE a.FirstName='{author.FirstName}' AND a.LastName='{author.LastName}') SELECT 1 ELSE SELECT 0";
                            int exist = (int)(new SqlCommand(checkQuery, conn, tran).ExecuteScalar());

                            if (exist > 0) {
                                authorId = (int)(new SqlCommand($"SELECT TOP(1) a.id FROM dbo.Authors AS a WHERE a.FirstName='{author.FirstName}' AND a.LastName='{author.LastName}'", conn, tran).ExecuteScalar());
                            }
                            else {
                                SqlCommand com1 = new SqlCommand(queryAuthor, conn, tran);
                                com1.Parameters.AddWithValue("@FirstName", author.FirstName);
                                com1.Parameters.AddWithValue("@LastName", author.LastName);
                                com1.Parameters.AddWithValue("@BirthDate", author.BirthDate.ToString("yyyy-MM-dd"));

                                authorId = (int)com1.ExecuteScalar();
                                // throw new Exception("შეცდომის სიმულაცია");
                            }

                            author.Books.ForEach(book => {
                                SqlCommand com = new SqlCommand(queryBook, conn, tran);
                                com.Parameters.AddWithValue("@Name", book.Name);
                                com.Parameters.AddWithValue("@Description", book.Description);
                                com.Parameters.AddWithValue("@Publisher", book.Publisher);
                                com.Parameters.AddWithValue("@PageNumber", book.PageNumber);
                                com.Parameters.AddWithValue("@ISBN", book.ISBN);

                                int bookId = (int)com.ExecuteScalar();
                                SqlCommand c = new SqlCommand(queryAuthorToBook, conn, tran);
                                c.Parameters.AddWithValue("@AuthorId", authorId);
                                c.Parameters.AddWithValue("@BookId", bookId);
                                c.ExecuteNonQuery();
                            });

                            tran.Commit();
                            MessageBox.Show("ოპერაცია წარმატებულია");
                        }
                        //catch (SqlException se) {
                        //    tran.Rollback();
                        //}
                        catch (Exception ex) {
                            tran.Rollback();
                            throw new Exception($"შეცდომა მოხდა ბაზის მხარეს: {ex.Message}");
                        }
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
