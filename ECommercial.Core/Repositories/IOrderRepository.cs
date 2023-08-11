using ECommercial.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ECommercial.Core.Repositories
{
    public interface IOrderRepository
    {
        // Basic CRUD's
        public Task AddAsync(Order order);

        public Task<bool> AnyAsync(Expression<Func<Order, bool>> expression);

        public IQueryable<Order> GetAll();

        public Task<Order> GetByIdAsync(int id);

        public IQueryable<Order> GetAllByUserIdAsync(string userId);
        // Basic CRUD's

        public Task<Order> GetOrderWithOrderItemsByIdAsync(int orderId);
        public Task AddOrderItemToOrderAsync(int orderId, int variantId, int quantity);
        public Task RemoveItemFromOrderAsync(int orderId, int orderItemId);

    }
}
