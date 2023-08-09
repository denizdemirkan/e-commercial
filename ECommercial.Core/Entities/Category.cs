using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommercial.Core.Entities
{
    public class Category
    {
        public Category()
        {
            this.Products = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        // need category icon image
        public ICollection<Product> Products { get; set; }

        // add keyword stuff.
    }
}
