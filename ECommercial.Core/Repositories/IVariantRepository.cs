using ECommercial.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ECommercial.Core.Repositories
{
    public interface IVariantRepository
    {
        // Basic CRUD's
        public Task AddAsync(Variant variant);

        public Task AddRangeAsyn(IEnumerable<Variant> variants);

        public Task<bool> AnyAsync(Expression<Func<Variant, bool>> expression);

        public IQueryable<Variant> GetAll();

        public Task<Variant> GetByIdAsync(int id);

        public Task<Variant> GetByBarcodeNameAsync(string barcode);
        // Basic CRUD's

        public Task<Variant> GetVariantWithProductById(int id);
        public Task<Variant> GetVariantWithProductByBarcode(string barcode);
    }
}
