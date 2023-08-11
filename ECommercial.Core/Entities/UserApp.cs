using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommercial.Core.Entities
{
    public class UserApp
    {
        public List<Variant> FavoriteProducts { get; set; }
        public ShoppingCart ShoppingCart { get; set; }
        public List<Address>? Addresses { get; set; }
        public List<Order> Orders { get; set; }
    }
}
