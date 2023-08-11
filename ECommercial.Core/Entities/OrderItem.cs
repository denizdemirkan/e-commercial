using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommercial.Core.Entities
{
    // This class will be stored in db atleast 8 years.
    public class OrderItem
    {
        public int Id { get; set; }
        public Variant Variant { get; set; }
        public Order Order { get; set; }
        public int Quantity { get; set; }
    }
}
