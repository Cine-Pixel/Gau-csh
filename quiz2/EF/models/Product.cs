using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz2.EF.models {
    public class Product {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        [StringLength(30)]
        public string Package { get; set; }
        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
