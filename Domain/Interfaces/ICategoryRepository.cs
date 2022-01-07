﻿using Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface ICategoryRepository : IRepositoryBase<Category>
    {
        Task<IEnumerable<Category>> ToList();
    }
}
