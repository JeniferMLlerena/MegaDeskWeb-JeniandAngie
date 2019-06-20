using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MegaDeskWeb.Models
{
    public class RushOrder
    {
        public int RushOrderId { get; set; }
        public string RushOrderType { get; set; }//name 3 day,5 days
        public decimal RushOrderPriceLessThan1000 { get; set; }
        public decimal RushOrderPrice1000To2000 { get; set; }
        public decimal RushOrderPriceOver2000 { get; set; }
    }
}
