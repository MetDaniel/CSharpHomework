using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<OrderDetails> list = new List<OrderDetails>();
            OrderDetails A = new OrderDetails("1996-12-10-012", "韩梅梅", "12345678910", "肥皂", 200);
            OrderDetails B =(new OrderDetails("1999-11-02-021", "李雷", "10987654321", "香皂", 10001));
            OrderService os = new OrderService();
            os.AddOrder("1996-12-10-012", "韩梅梅", "12345678910", "肥皂", 200);
            //os.SearchOrder2(list, B.goodName);
            //os.SearchOrder3(list, B.cusName);
            //os.SearchOrder4(list);
        }
    }
}
