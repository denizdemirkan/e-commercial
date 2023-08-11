﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommercial.Core.Entities
{
    // After clearing or succesfull check-out, this items will be removed.
    public class ShoppingCartItem
    {
        public int Id { get; set; }
        public Variant Variant { get; set; }
        public ShoppingCart ShoppingCart { get; set; }
        public int Quantity { get; set; }
    }
}
