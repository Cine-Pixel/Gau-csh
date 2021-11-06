using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm1 {
    public class Article : Product {
        #region Private Props
        private string name;
        private List<Author> authors;
        private string journalName;
        private int number;
        private DateTime publishDate;
        private int pageNumber;
        #endregion

        #region Public Props
        public string PName { get => name; }
        public string Authors { get {
                string allAuthorInfo = "";
                foreach(Author author in authors) {
                    allAuthorInfo += author.Info();
                }
                return allAuthorInfo;
            } 
        }
        public string JournalName { get => journalName; }
        public int Number { get => number; }
        public string PublishDate { get => publishDate.ToString(); }
        public DateTime PblishDate { get => publishDate; }
        public int PageNumber { get => pageNumber; }
        #endregion

        public Article(string name, List<Author> authors, string journal, int number, DateTime publishDate, int pageNumber) {
            this.name = name;
            this.authors = authors;
            this.journalName = journal;
            this.number = number;
            this.publishDate = publishDate;
            this.pageNumber = pageNumber;
        }

        public override string Info() {
            string allAuthorInfo = "";
            foreach(Author author in authors) {
                allAuthorInfo += author.Info();
            }
            return $"Article name: {name}\nAuthors: {allAuthorInfo}\n"+
                $"Journal: {journalName}\nNumber: {number}"+
                $"Publish date: {publishDate}\nPages: {pageNumber}";
        }
    }
}
