using Domain.Interfaces;
using Domain.Models;
using Infra.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infra.Repository
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(ProductContext context) : base(context)
        {
        }

        public async Task<Product> GetProductSuppliersById(Guid id)
        {
            return await _context.Products.AsNoTracking().Include(p => p.supplier).FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<IEnumerable<Product>> ToList()
        {
            return await _context.Products.AsNoTracking().Include(p => p.supplier)
               .OrderBy(p => p.Name).ToListAsync();
        }
        public async Task<IEnumerable<Product>> GetProductsSuppliers(Guid supplierId)
        {
            return await Find(p => p.supplierID == supplierId);
        }
    }
}
