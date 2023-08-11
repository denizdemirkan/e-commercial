using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommercial.Core.Entities
{
    public class Variant
    {
        public int Id { get; set; }
        // Primary Key --> Barcode
        public string Barcode { get; set; }

        public Image MainImage { get; set; }
        public List<Image> Images { get; set; }  // upload all first. Then select Main one.
        public int StockAmount { get; set; }
        public int TimesSold { get; set; }
        public decimal SalePrice { get; set; }  // actual value
        public decimal ListPrice { get; set; }  // actual sell price

        //public int ProductId { get; set; }
        public Product Product { get; set; }
        public Size Size { get; set; }
        public Color Color { get; set; }
    }
}
