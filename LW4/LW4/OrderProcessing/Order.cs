﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW4.OrderProcessing
{
    public class Order
    {
        public int OrderId { get; set; }
        public bool IsPaid { get; set; }
        public bool IsConfirmed { get; set; }
        public bool IsShipped { get; set; }
    }
}
