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
            OrderDetails B = new OrderDetails();
            B.num = "301";
            B.goodName = "香皂";
            B.cusName = "韩梅梅";
            B.price = 200;
            OrderDetails A = new OrderDetails();
            A.num = "201";
            A.goodName = "肥皂";
            A.cusName = "李雷";
            A.price = 10001;
            List<OrderDetails> list = new List<OrderDetails>();
            OrderService os = new OrderService();
            os.AddOrder(list, B);
            os.AddOrder(list, A);
            os.SearchOrder2(list, B.goodName);
            os.SearchOrder3(list, B.cusName);
            os.SearchOrder4(list);
        }
    }
}
