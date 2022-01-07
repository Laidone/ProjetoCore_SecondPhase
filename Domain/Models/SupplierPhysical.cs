using Domain.Tools;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class SupplierPhysical : Supplier
    {
        public string FantasyName { get; set; }
        public string Name { get; set; }
        public string cpf { get; set; }
        public DateTime BirthDate { get; set; }

        public void SetCpf(string value)
        {
            if (!value.IsCpf())
            {
                throw new DomainException("Cpf invalido");
            }
            cpf = value;
        }

        public class SupplierPhysicalValidator : AbstractValidator<SupplierPhysical>
        {
            public SupplierPhysicalValidator()
            {
                RuleFor(x => x.Name)
                    .NotNull()
                    .NotEmpty()
                    .WithMessage("Nome completo invalido")
                    .Length(3, 300)
                    .WithMessage("O campo nome completo deve conter entre 3 e 300 caracteres");

                RuleFor(x => x.cpf.IsCpf())
                    .Equal(true)
                    .WithMessage("");
            }
        }
    }
}
