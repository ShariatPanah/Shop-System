using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_System.BLL
{
    public class Sell
    {
        public string WareTitle { get; set; }
        public string ShopFrom { get; set; }
        public Int64 Price { get; set; }
        public int Count { get; set; }
        public Int64 Amount { get; set; }
        public Int64 Profit { get; set; }
        public string SellDate { get; set; }

    }
}
