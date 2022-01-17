using Domain.Interfaces;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
    public class Product : Entity, IAggregateRoot
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
        public class ProductValidator : AbstractValidator<Product>
        {
            public ProductValidator()
            {
                RuleFor(x => x.Name)
                    .NotNull()
                    .NotEmpty()
                    .WithMessage("Nome completo invalido")
                    .Length(3, 300)
                    .WithMessage("O campo nome completo deve conter entre 3 e 300 caracteres");

                RuleFor(x => x.InsertDate)
                    .NotNull()
                    .NotEmpty()
                    .WithMessage("Nome completo invalido")
                    .LessThan(p => DateTime.Now).WithMessage("a data deve estar no passado");
                RuleFor(x => x.BarCode)
                    .NotNull()
                    .Length(3, 300)
                    .WithMessage("BarCode invalido");
                RuleFor(x => x.QuantityStock)
                    .GreaterThanOrEqualTo(0)
                    .WithMessage("Numero precisa ser maior ou igual a zero");
                //RuleFor(x => x.)
;            }
        }
    }
}
