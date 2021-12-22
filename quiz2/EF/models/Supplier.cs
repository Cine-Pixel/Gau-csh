using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz2.EF.models {
    public class Supplier {
        [Key]
        public int Id { get; set; }
        [Index]
        [StringLength(40)]
        public string CompanyName { get; set; }
        [StringLength(50)]
        public string ContactName { get; set; }
        [StringLength(40)]
        public string ContactTitle { get; set; }
        [StringLength(40)]
        public string City { get; set; }
        [Index]
        [StringLength(40)]
        public string Country { get; set; }
        [StringLength(30)]
        public string Phone { get; set; }
        [StringLength(30)]
        public string Fax { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
