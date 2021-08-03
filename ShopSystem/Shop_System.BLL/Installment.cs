using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_System.BLL
{
    public class Installment
    {
        public string ShopDate { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public string Address { get; set; }
        public string Mobile { get; set; }
        public Int64 FactorAmount { get; set; }
        public Int64 PrePayment { get; set; }
        public Int64 Remainder { get; set; }
        public string ChequeNo { get; set; }
        public string BankName { get; set; }
        public string ChequeOwner { get; set; }
        public string RecieveDate { get; set; }
    }
}
