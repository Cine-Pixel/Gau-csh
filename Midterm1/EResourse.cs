using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm1 {
    public class EResourse : Product {
        #region Private Props
        private string name;
        private List<Author> authors;
        private string link;
        private string annotation;
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
        public string Link { get => link; }
        public string Annotation { get => annotation; }
        #endregion

        public EResourse(string name, List<Author> authors, string link, string annotation) {
            this.name = name;
            this.authors = authors;
            this.link = link;
            this.annotation = annotation;
        }

        public override string Info() {
            string allAuthorInfo = "";
            foreach(Author author in authors) {
                allAuthorInfo += author.Info();
            }
            return $"EResouse name: {name}\nAuthors: {allAuthorInfo}\n" +
                $"Link: {link}\nAnnotation: {annotation}";
        }
    }
}
