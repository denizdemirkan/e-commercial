using ECommercial.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommercial.Core.Repositories
{
    public interface IColorRepository
    {
        // Basic CRUD's
        public Task AddAsync(Color color);

        public IQueryable<Color> GetAll();

        public Task<Size> GetByNameAsync(string colorName);
        // Basic CRUD's
    }
}
