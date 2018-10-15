using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    class OrderService:OrderDetails
    {
        //添加订单
        public void AddOrder(List<OrderDetails> list, OrderDetails A)
        {
            list.Add(A);
        }
        //删除订单
        public void DeleteOrder(List<OrderDetails> list, OrderDetails A)
        {
            int i = 0;
            while (i < list.Count && list[i] != A)
                i++;
            if (i >= list.Count)
                Console.WriteLine("这条订单不存在，未删除成功");
            else
                list.Remove(list[i]);
        }
        //修改订单
        public void ChangeOrder(List<OrderDetails> list, OrderDetails A, OrderDetails B)
        {
            int i = 0;
            while (i < list.Count && list[i] != A)
                i++;
            if (i >= list.Count)
                Console.WriteLine("这条订单不存在，未修改成功");
            else
            {
                list[i].num = B.num;
                list[i].goodName = B.goodName;
                list[i].cusName = B.cusName;
                list[i].price = B.price;
            }
        }
        //按订单号查询订单
        public void SearchOrder1(List<OrderDetails> list, string num1)
        {
            foreach (OrderDetails B in list)
            {
                if (B.num == num1)
                    Console.WriteLine(B.num + "\t" + B.goodName + "\t" + B.cusName);
            }
        }
        //按商品名称查询订单
        public void SearchOrder2(List<OrderDetails> list, string goodName1)
        {
            var m = from n in list
                    where n.goodName.Equals(goodName1)
                    select n;
            foreach(var n in m)
            {
                Console.WriteLine(n.num + "\t" + n.goodName + "\t" + n.cusName + "\t" + n.price);
            }
        }
        //按客户查询订单
        public void SearchOrder3(List<OrderDetails> list, string cusName1)
        {
            var m = from n in list
                    where n.cusName.Equals(cusName1)
                    select n;
            foreach (var n in m)
            {
                Console.WriteLine(n.num + "\t" + n.goodName + "\t" + n.cusName + "\t" + n.price);
            }
        }
        //查询订单金额大于1万元的订单
        public void SearchOrder4(List<OrderDetails> list)
        {
            var m = from n in list
                    where n.price > 10000
                    select n;
            foreach (var n in m)
            {
                Console.WriteLine(n.num + "\t" + n.goodName + "\t" + n.cusName + "\t" + n.price);
            }
        }
    }
}
