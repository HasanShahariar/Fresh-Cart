using Fresh_Cart.DatabaseOps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fresh_Cart.Models
{
    public class Order
    {
        public long Id { get; set; }
        public string Product { get; set; }
        public double Price { get; set; }
        public long Quantity { get; set; }
        
    }
}
