using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz2.EF.models {
    public class Order {
        [Key]
        public int Id { get; set; }
        [Index]
        public DateTime OrderDate { get; set; }
        [StringLength(10)]
        public string OrderNumber { get; set; }
        [Index]
        public decimal TotalAmount { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
