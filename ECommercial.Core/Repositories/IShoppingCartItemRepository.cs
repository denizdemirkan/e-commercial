using ECommercial.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ECommercial.Core.Repositories
{
    public interface IShoppingCartItemRepository
    {
        // Basic CRUD's
        public Task AddAsync(ShoppingCartItem shoppingCartItem);

        public Task<bool> AnyAsync(Expression<Func<ShoppingCartItem, bool>> expression);

        public IQueryable<ShoppingCartItem> GetAll();

        public Task<ShoppingCartItem> GetByIdAsync(int id);
        
        public IQueryable<ShoppingCartItem> GetShoppingCartItemsByShoppingCartId(string shoppingCartId);
        // Basic CRUD's

        public Task UpdateQuantityByIdAsync(int shoppingCartItemId, int newQuantity);
    }
}
