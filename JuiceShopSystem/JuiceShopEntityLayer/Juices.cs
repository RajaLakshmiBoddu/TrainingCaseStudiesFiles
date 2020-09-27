using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuiceShopEntityLayer
{
    public class JuicePurchased
    {
        public int purchase_no { get; set; }
        public int juiceid { get; set; }
        public int quantity { get; set; }
        public int amount { get; set; }
    }
    public class Juice
    { 
        public int juiceid { get; set; }
        public string juice_flavour { get; set; }
        public int price { get; set; }
    }
}
