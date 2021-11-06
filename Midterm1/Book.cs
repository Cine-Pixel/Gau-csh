using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm1 {
    public class Book : Product {
        #region Private Props
        private int id;
        private string name;
        private List<Author> authors;
        private DateTime publishDate;
        private string publisher;
        private int pageNumber;
        #endregion

        #region Public Props
        public int Id { get => id; }
        public string PName { get => name; }
        public string Authors { get {
                string allAuthorInfo = "";
                foreach(Author author in authors) {
                    allAuthorInfo += author.Info();
                }
                return allAuthorInfo;
            } 
        }
        public string PublishDate { get => publishDate.ToString(); }
        public DateTime PblishDate { get => publishDate; } 
        public string Publisher { get => publisher; }
        public int PageNumber { get => pageNumber; }
        #endregion

        public Book(int id, string name, List<Author> authors, DateTime publishdate, string publisher, int pagenum) {
            this.id = id;
            this.name = name;
            this.authors = authors;
            this.publishDate = publishdate;
            this.publisher = publisher;
            this.pageNumber = pagenum;
        }

        public override string Info() {
            string allAuthorInfo = "";
            foreach(Author author in authors) {
                allAuthorInfo += author.Info();
            }
            return $"Book name: {name}\nAuthors: {allAuthorInfo}\n"+
                $"Publish date: {publishDate}\nPublisher: {publisher}\nPages: {pageNumber}";
        }
    }
}
