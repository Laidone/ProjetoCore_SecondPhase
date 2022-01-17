using Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IProductRepository : IRepositoryBase<Product>
    {
        Task<IEnumerable<Product>> ToList();
        Task<IEnumerable<Product>> GetProductsSuppliers(Guid supplierId);
        Task<Product> GetProductSuppliersById(Guid id);
    }
}
