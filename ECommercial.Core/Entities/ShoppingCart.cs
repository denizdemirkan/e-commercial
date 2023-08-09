using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommercial.Core.Entities
{
    public class ShoppingCart
    {
        public ShoppingCart()
        {
            this.Products = new HashSet<ShoppingCartItem>();
        }

        public int Id { get; set; }
        public bool isUser { get; set; }
        public ICollection<ShoppingCartItem> Products { get; set; }
    }
}
