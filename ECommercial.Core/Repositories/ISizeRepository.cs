using ECommercial.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ECommercial.Core.Repositories
{
    public interface ISizeRepository
    {
        // Basic CRUD's
        public Task AddAsync(Size size);

        public IQueryable<Size> GetAll();

        public Task<Size> GetByNameAsync(string sizeName);
        // Basic CRUD's
    }
}
