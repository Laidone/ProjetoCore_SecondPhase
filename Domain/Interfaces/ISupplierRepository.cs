using Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface ISupplierRepository : IRepositoryBase<Supplier>
    {
        Task<IEnumerable<Supplier>> ToList();
        Task<Supplier> GetSupplierAddress(Guid supplierId);
        Task<Product> GetProductSuppliersById(Guid id);
        Task UpdateAddres(Address address);
    }
}
