using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class Imagem : Entity
    {
        public string ImagePath { get; set; }
        public List<Product> products = new List<Product>();
    }
}
