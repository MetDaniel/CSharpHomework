using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program2
{
    class Program : OrderService
    {
        static void Main(string[] args)
        {
            OrderDetails B = new OrderDetails();
            B.num = "301";
            B.goodName = "香皂";
            B.cusName = "韩梅梅";
            OrderDetails A = new OrderDetails();
            A.num = "201";
            A.goodName = "肥皂";
            A.cusName = "李雷";
            List<OrderDetails> list = new List<OrderDetails>();
            OrderService os = new OrderService();
            os.AddOrder(list, B);
            os.AddOrder(list, A);
            os.DeleteOrder(list, B);
            os.DeleteOrder(list, B);
            os.ChangeOrder(list, B, A);
            os.ChangeOrder(list, A, B);
            os.SearchOrder1(list, B.num);
            os.SearchOrder2(list, B.goodName);
            os.SearchOrder3(list, B.cusName);
        }
    }
}
