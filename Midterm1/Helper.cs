using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm1 {
    public static class Helper {
        private static List<Product> GetBooks() {
            List<Product> products = new List<Product>();
            DataTable books = DB.Procedure("BooksWithAuthors");

            List<DataRow> duplicates = new List<DataRow>();
            List<Author> authors = new List<Author>();
            int previous = 0;
            foreach (DataRow row in books.Rows) {
                int rowID = Convert.ToInt32(row["Id"]);

                if (previous == rowID) duplicates.Add(row);
                else {
                    // Call the function that handles the duplicates
                    if (duplicates.Count > 1) {
                        // handle duplicates
                        foreach(DataRow d in duplicates) {
                            authors.Add(new Author(d["FirstName"].ToString(), d["LastName"].ToString()));
                        }
                    }

                    authors.Add(new Author(row["FirstName"].ToString(), row["LastName"].ToString()));
                    products.Add(
                        new Book(
                            row["Name"].ToString(), 
                            new List<Author>(authors), DateTime.Parse(row["PublishDate"].ToString()), 
                            row["Publisher"].ToString(), (int)row["PageNumber"]
                        )
                    );

                    duplicates.Clear();
                    authors.Clear();
                }
                previous = rowID;
            }

            return products;
        }

        private static List<Product> GetArticles() {
            List<Product> products = new List<Product>();
            DataTable articles = DB.Procedure("ArticlesWithAuthors");

            List<DataRow> duplicates = new List<DataRow>();
            List<Author> authors = new List<Author>();
            int previous = 0;
            foreach (DataRow row in articles.Rows) {
                int rowID = Convert.ToInt32(row["Id"]);

                if (previous == rowID) duplicates.Add(row);
                else {
                    // Call the function that handles the duplicates
                    if (duplicates.Count > 1) {
                        // handle duplicates
                        foreach(DataRow d in duplicates) {
                            authors.Add(new Author(d["FirstName"].ToString(), d["LastName"].ToString()));
                        }
                    }

                    authors.Add(new Author(row["FirstName"].ToString(), row["LastName"].ToString()));
                    products.Add(
                        new Article(
                            row["Name"].ToString(),
                            new List<Author>(authors), row["JournalName"].ToString(),
                            (int)row["Number"],
                            DateTime.Parse(row["PublishDate"].ToString()),
                            (int)row["PageNumber"]
                        )
                    );

                    duplicates.Clear();
                    authors.Clear();
                }
                previous = rowID;
            }

            return products;
        }

        private static List<Product> GetEResourses() {
            List<Product> products = new List<Product>();
            DataTable ers = DB.Procedure("EResoursesWithAuthors");

            List<DataRow> duplicates = new List<DataRow>();
            List<Author> authors = new List<Author>();
            int previous = 0;
            foreach (DataRow row in ers.Rows) {
                int rowID = Convert.ToInt32(row["Id"]);

                if (previous == rowID) duplicates.Add(row);
                else {
                    // Call the function that handles the duplicates
                    if (duplicates.Count > 1) {
                        // handle duplicates
                        foreach(DataRow d in duplicates) {
                            authors.Add(new Author(d["FirstName"].ToString(), d["LastName"].ToString()));
                        }
                    }

                    authors.Add(new Author(row["FirstName"].ToString(), row["LastName"].ToString()));
                    products.Add(
                        new EResourse(
                            row["Name"].ToString(), new List<Author>(authors), 
                            row["Link"].ToString(), row["Annotation"].ToString()
                        )
                    );

                    duplicates.Clear();
                    authors.Clear();
                }
                previous = rowID;
            }

            return products;
        }

        public static List<Product> GetAllProducts() {
            List<Product> products = new List<Product>();
            products.AddRange(GetBooks());
            products.AddRange(GetArticles());
            products.AddRange(GetEResourses());
            return products;
        }
    }
}
