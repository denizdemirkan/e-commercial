using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommercial.Core.Entities
{
    public class Comment
    {
        public int Id { get; set; }
        public UserApp User { get; set; }
        public Product Product { get; set; }
        public string Content { get; set; }
    }
}
