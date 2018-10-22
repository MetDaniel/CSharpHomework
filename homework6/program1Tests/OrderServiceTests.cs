using Microsoft.VisualStudio.TestTools.UnitTesting;
using program1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {
        //添加订单测试
        [TestMethod()]
        public void AddOrderTest()
        {
            OrderDetails B = new OrderDetails();
            B.num = "301";
            B.goodName = "香皂";
            B.cusName = "韩梅梅";
            B.price = 200;
            List<OrderDetails> list1 = new List<OrderDetails>();
            OrderService os = new OrderService();
            os.AddOrder(list1, B);
            List<OrderDetails> list2 = new List<OrderDetails>() { B };
            Assert.IsTrue(list1.All(list2.Contains) && list1.Count == list2.Count);
        }
        //删除订单测试
        [TestMethod()]
        public void DeleteOrderTest1()
        {
            OrderDetails A = new OrderDetails();
            A.num = "201";
            A.goodName = "肥皂";
            A.cusName = "李雷";
            A.price = 10001;
            List<OrderDetails> list1 = new List<OrderDetails>() { A };
            OrderService os = new OrderService();
            bool result = os.DeleteOrder(list1, A);
            Assert.IsTrue(result);
        }
        //删除空订单测试
        [TestMethod()]
        public void DeleteOrderTest2()
        {
            OrderDetails A = new OrderDetails();
            A.num = "201";
            A.goodName = "肥皂";
            A.cusName = "李雷";
            A.price = 10001;
            List<OrderDetails> list1 = new List<OrderDetails>();
            OrderService os = new OrderService();
            bool result = os.DeleteOrder(list1, A);
            Assert.IsFalse(result);
        }
        [TestMethod()]
        //改变订单测试
        public void ChangeOrderTest()
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
            List<OrderDetails> list1 = new List<OrderDetails>() { A };
            OrderService os = new OrderService();
            bool result = os.ChangeOrder(list1, A, B);
            Assert.IsTrue(result);
        }
        //改变不存在订单测试
        [TestMethod()]
        public void ChangeOrderTest1()
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
            List<OrderDetails> list1 = new List<OrderDetails>() { A };
            OrderService os = new OrderService();
            bool result = os.ChangeOrder(list1, B, B);
            Assert.IsFalse(result);
        }
        //按订单号查询订单测试
        [TestMethod()]
        public void SearchOrderTest1()
        {
            OrderDetails B = new OrderDetails();
            B.num = "301";
            B.goodName = "香皂";
            B.cusName = "韩梅梅";
            B.price = 200;
            List<OrderDetails> list1 = new List<OrderDetails>() { B };
            OrderService os = new OrderService();
            bool result = os.SearchOrder1(list1, B.num);
            Assert.IsTrue(result);
        }
    }
}