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
            OrderDetails B = new OrderDetails("201","香皂","韩梅梅",200);
            OrderDetails A = new OrderDetails("301","肥皂","李雷",10001);
            List<OrderDetails> list = new List<OrderDetails>();
            OrderService os = new OrderService();
            //os.AddOrder(list, B);
            //os.AddOrder(list, A);
            //os.SearchOrder2(list, B.goodName);
            //os.SearchOrder3(list, B.cusName);
            //os.SearchOrder4(list);
        }
    }
}
