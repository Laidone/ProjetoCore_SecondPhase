using System;
using System.Collections.Generic;
using Domain.Models;
using Domain.Interfaces;
using Infra.Data;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Infra.Repository
{
    public class SupplierRepository : RepositoryBase<Supplier>, ISupplierRepository
    {
        public SupplierRepository(ProductContext context) : base(context)
        {
        }

        public Task<Product> GetProductSuppliersById(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<Supplier> GetSupplierAddress(Guid supplierId)
        {
            return await _context.Suppliers.AsNoTracking().Include(s => s.address).FirstOrDefaultAsync(s => s.Id == supplierId);
        }

        public Task<IEnumerable<Supplier>> ToList()
        {
            throw new NotImplementedException();
        }

        public Task UpdateAddres(Address address)
        {
            throw new NotImplementedException();
        }
    }
}
