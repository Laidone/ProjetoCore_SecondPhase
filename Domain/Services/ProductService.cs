using Domain.Models;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class ProductService : IProductService
    {
        //private readonly IRepositoryBase<Product> _produto;
        private readonly IProductRepository _productRepository;
        //private ModelStateDictionary _modelState;
        public ProductService(IProductRepository produto)
        {
            _productRepository = produto;
        }

        public async Task AddProduct(Product product)
        {
            return;
        }

        public async Task<IEnumerable<Product>> ToList()
        {
            return await _productRepository.ToList();
        }
        /*protected bool ValidateProduct(Product productToValidade)
{
   if (productToValidade.Name.Trim() == 0)
   {

   }
}*/


    }
}
