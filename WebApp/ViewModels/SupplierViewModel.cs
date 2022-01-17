using Domain.Models;
using System;
using System.Collections.Generic;

namespace WebApp.ViewModels
{
    public class SupplierViewModel
    {
        public bool Active { get; set; }
        public Email email { get; set; }
        public Guid emailID { get; set; }
        public Address address { get; set; }
        public Guid addressID { get; set; }

        public List<Phone> phones = new List<Phone>();

        //public IEnumerable<Product> products { get; set; }
        public List<Product> products = new List<Product>();
    }
}
