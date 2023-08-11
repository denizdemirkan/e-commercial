﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommercial.Core.Entities
{
    public class Coupon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public bool IsApplied { get; set; }
        public DateTime ExpireDate { get; set; }
        public decimal Value { get; set; }
    }
}
