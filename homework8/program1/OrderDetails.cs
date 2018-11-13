using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    [Serializable]
    public class OrderDetails:Order
    {
        public string goodName { get; set; }
        public double price { get; set; }
        public OrderDetails(string num,string cusName,string phoneNum,string goodName,double price):base(num,cusName,phoneNum)
        {
            this.num = num;
            this.cusName = cusName;
            this.phoneNum = phoneNum;
            this.goodName = goodName;
            this.price = price;
        }
    }
}
