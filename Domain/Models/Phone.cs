using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class Phone : Entity
    {
        public string Ddd { get; set; }
        public string PhoneNumber { get; set; }
        public Guid supplierID { get; set; }
        public Supplier Supplier { get; set; }
    }
}
