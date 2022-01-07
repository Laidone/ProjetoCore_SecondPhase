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
        private readonly IRepositoryBase<Product> _produto;
        /*private ModelStateDictionary _modelState;
        public ProductService(IRepositoryBase<Product> produto)
        {
            _produto = produto;
        }
        protected bool ValidateProduct(Product productToValidade)
        {
            if (productToValidade.Name.Trim() == 0)
            {

            }
        }*/

        Task IProductService.AddProduct(Product product)
        {
            //aqui... se exise no banco, todos campos est'ao preen... e etc...
            throw new NotImplementedException();
        }

        Task<IEnumerable<Product>> IProductService.ToList()
        {
            throw new NotImplementedException();
        }

    }
}
