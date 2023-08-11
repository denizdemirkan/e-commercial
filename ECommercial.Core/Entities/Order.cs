using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommercial.Core.Entities
{
    public class Order
    {
        public Order()
        {
            this.Products = new HashSet<OrderItem>();
            OrderDate = DateTime.Now;
        }

        public int Id { get; set; }
        public int InstallmentMonths { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalCost { get; set; }
        public decimal TotalDiscount { get; set; }
        public decimal TotalTaxFee { get; set; }
        public bool IsDone { get; set; }
        public ICollection<OrderItem> Products { get; set; }

        public bool IsDelivered { get; set; }
        public DateTime? DeliverDate { get; set; }

        public bool IsCanceled { get; set; }
        public DateTime? CancelDate { get; set; }
        public bool IsCalceledByCustomer { get; set; }
        public string? CalcelReason { get; set; }
    }
}
