using Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.ViewModels
{
    public class ProductViewModel
    {
        public string Name { get; set; }
        public string BarCode { get; set; }
        public int QuantityStock { get; set; }
        public bool Active { get; set; }
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,4)")]
        public decimal PriceSales { get; set; }
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,4)")]
        public decimal PricePurchase { get; set; }
        public Category category { get; set; }
        public Guid categoryID { get; set; }

        public List<Imagem> imagems = new List<Imagem>();

        public Supplier supplier { get; set; }
        public Guid supplierID { get; set; }
    }
}
