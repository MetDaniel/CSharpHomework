using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace program1
{
    [Serializable]
    public class OrderDetails:Order
    {
        [Key]
        public string num { get; set; }
        public string cusName { get; set; }
        public string phoneNum { get; set; }
        public string goodName { get; set; }
        public double price { get; set; }
        public OrderDetails() { }
        public OrderDetails(string num,string cusName,string phoneNum,string goodName,double price)
        {
            this.num = num;
            this.cusName = cusName;
            this.phoneNum = phoneNum;
            this.goodName = goodName;
            this.price = price;
        }
    }
}
