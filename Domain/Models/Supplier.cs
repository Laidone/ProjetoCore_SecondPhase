using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public abstract class Supplier : Entity, IAggregateRoot
    {
        public bool Active { get; set; }
        public Email email { get; set; }
        public Guid emailID { get; set; }
        public Address address { get; set; }
        public Guid addressID { get; set; }

        public List<Phone> phones = new List<Phone>();

        public List<Product> products = new List<Product>();
    }
}