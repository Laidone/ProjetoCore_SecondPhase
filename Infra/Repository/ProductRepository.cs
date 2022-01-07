using Domain.Interfaces;
using Domain.Models;
using Infra.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infra.Repository
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(ProductContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Product>> ToList()
        {
            return await _dbSet.ToListAsync();
        }
        
    }
}
