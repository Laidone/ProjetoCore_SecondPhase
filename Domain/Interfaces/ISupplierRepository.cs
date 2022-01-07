using Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface ISupplierRepository : IRepositoryBase<Supplier>
    {
        Task<IEnumerable<Supplier>> ToList();
    }
}
