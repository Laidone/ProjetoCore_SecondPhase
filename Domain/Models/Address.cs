using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class Address : Entity
    {
        public string ZipCode { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string Complement { get; set; }
        public string Reference { get; set; }
        public string Neighborhood { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public Supplier Supplier { get; set; }
        public Guid SupplierGuid { get; set; }
    }
}
