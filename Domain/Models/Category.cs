using Domain.Interfaces;
using System.Collections.Generic;

namespace Domain.Models
{
    public class Category : Entity, IAggregateRoot
    {
        public bool Active { get; set; }
        public string Name { get; set; }
        public List<Product> products = new List<Product>();
    }
}
