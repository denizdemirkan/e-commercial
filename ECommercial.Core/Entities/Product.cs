using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommercial.Core.Entities
{
    public class Product
    {
        public Product()
        {
            this.Comments = new HashSet<Comment>();
            this.Categories = new HashSet<Category>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal SalePrice { get; set; }  // actual value
        public decimal ListPrice { get; set; }  // actual sell price

        // need single image

        // bunu binary olarak tutabilirim? TinyMCE ile çevirmece..
        public string Description { get; set; }

        public ICollection<Comment> Comments { get; set; }

        public ICollection<Category> Categories { get; set; }

    }
}
