using ECommercial.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ECommercial.Core.Repositories
{
    public interface IShoppingCartRepository
    {
        // Basic CRUD's
        public Task AddAsync(ShoppingCart shoppingCart);

        public Task<bool> AnyAsync(Expression<Func<ShoppingCart, bool>> expression);

        public IQueryable<ShoppingCart> GetAll();

        public Task<ShoppingCart> GetByIdAsync(int id);

        public Task<ShoppingCart> GetByShoppingCartByUserIdAsync(string userId);
        // Basic CRUD's

        public Task<ShoppingCart> GetShoppingCartWithShoppingCartItemsByIdAsync(int shoppingCartId);
        public Task AddItemToShoppingCartAsync(int shoppingCartId, int variantId, int quantity);
        public Task RemoveItemFromShoppingCartAsync(int shoppingCartId, int shoppingCartItemId);

        // update item quantity will be handled in ShoppingCartItemRepository

    }
}
