using Domain.Tools;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class SupplierJuridical : Supplier
    {
        public string CompanyName { get; set; }
        public string FantasyName { get; set; }
        public string Cnpj { get; set; }
        public DateTime OpenDate { get; set; }

        public void SetCnpj(string value)
        {
            if (value.IsCnpj())
            {
                throw new DomainException("CNPJ invalido");
            }
            Cnpj = value;
        }
    }
}
