using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> ToList();

        Task AddProduct(Product product);
    }
}
