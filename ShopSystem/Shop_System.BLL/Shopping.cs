using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_System.BLL
{
    public class Shopping
    {
        public string FactorNo { get; set; }
        public string Seller { get; set; }
        public string ShopDate { get; set; }
        public string WareTitle { get; set; }
        public Int64 Price { get; set; }
        public int Count { get; set; }
        public Int64 Amount { get; set; }
    }
}
