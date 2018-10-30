using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
     public class OrderDetails:Order
    {
        public string goodName { get; set; }
        public double price { get; set; }
        public OrderDetails(string num,string cusName,string goodName,double price):base(num,cusName)
        {
            this.num = num;
            this.cusName = cusName;
            this.goodName = goodName;
            this.price = price;
        }
    }
}
