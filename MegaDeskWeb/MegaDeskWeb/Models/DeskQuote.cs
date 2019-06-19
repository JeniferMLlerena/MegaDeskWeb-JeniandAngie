using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MegaDeskWeb.Models
{
    public class DeskQuote
    {
        public int DeskQuoteId { get; set; }
        public int DeskId { get; set; }
        public int RushOrderId { get; set; }
        public DateTime DateOrder { get; set; }
        public string CustomerName { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
