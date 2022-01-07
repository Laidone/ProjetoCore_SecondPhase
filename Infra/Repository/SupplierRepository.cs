using System;
using System.Collections.Generic;
using Domain.Models;
using Domain.Interfaces;
using Infra.Data;
using System.Threading.Tasks;

namespace Infra.Repository
{
    public class SupplierRepository : RepositoryBase<Supplier>, ISupplierRepository
    {
        public SupplierRepository(ProductContext context) : base(context)
        {
        }

        public Task<IEnumerable<Supplier>> ToList()
        {
            throw new NotImplementedException();
        }
    }
}
