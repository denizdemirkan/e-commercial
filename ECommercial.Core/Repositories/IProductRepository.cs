using ECommercial.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ECommercial.Core.Repositories
{
    public interface IProductRepository
    {
        // Basic CRUD's
        public Task AddAsync(Product product);

        public Task AddRangeAsyn(IEnumerable<Product> products);

        public Task<bool> AnyAsync(Expression<Func<Product, bool>> expression);

        public IQueryable<Product> GetAll();

        public Task<Product> GetByIdAsync(int id);

        public Task<Product> GetByNameAsync(string name);
        // Basic CRUD's

        public IQueryable<Product> GetProductsWithVariants();
        public Task<Product> GetOneProductWithVariantsById(int id);

    }
}
