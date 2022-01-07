using System;
using System.Collections.Generic;
using System.Text;
using Domain.Models;
using Domain.Interfaces;
using Infra.Data;
using System.Threading.Tasks;

namespace Infra.Repository
{
    public class CategoryRepository : RepositoryBase<Category>, ICategoryRepository
    {
        public CategoryRepository(ProductContext context) : base(context)
        {
        }

        public Task<IEnumerable<Category>> ToList()
        {
            throw new NotImplementedException();
        }
    }
}
