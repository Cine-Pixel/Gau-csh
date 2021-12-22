﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz2.EF.models {
    public class Customer {
        [Key]
        public int Id { get; set; }
        [StringLength(40)]
        public string FirstName { get; set; }
        [StringLength(40)]
        public string LastName { get; set; }
        [StringLength(40)]
        public string City { get; set; }
        [StringLength(40)]
        public string Country { get; set; }
        [StringLength(20)]
        public string Phone { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
