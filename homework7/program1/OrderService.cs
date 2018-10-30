using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    public class OrderService
    {
        //添加订单
        public void AddOrder(List<OrderDetails> list, string num1,string cusName1,string goodName1,double price1)
        {
            OrderDetails A = new OrderDetails(num1,cusName1,goodName1,price1);
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
        public void ChangeOrder(List<OrderDetails> list, string num2, string cusName2, string goodName2, double price2, string num1, string cusName1, string goodName1, double price1)
        {
            int i = 0;
            OrderDetails B = new OrderDetails(num1, cusName1, goodName1, price1);
            while (i < list.Count && list[i].num != num2 || list[i].cusName != cusName2 || list[i].goodName != goodName2 || list[i].price != price2)
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
        public OrderDetails SearchOrder1(List<OrderDetails> list, string num1)
        {
            foreach (OrderDetails B in list)
            {
                if (B.num == num1)
                    return B;
            }
            return null;
        }
        //按商品名称查询订单
        public OrderDetails SearchOrder2(List<OrderDetails> list, string goodName1)
        {
            foreach (OrderDetails B in list)
            {
                if (B.goodName == goodName1)
                    return B;
            }
            return null;
        }
        //按客户查询订单
        public OrderDetails SearchOrder3(List<OrderDetails> list, string cusName1)
        {
            foreach (OrderDetails B in list)
            {
                if (B.cusName == cusName1)
                    return B;
            }
            return null;
        }
        //查询订单金额大于1万元的订单
        public OrderDetails SearchOrder4(List<OrderDetails> list,double price1)
        {
            foreach (OrderDetails B in list)
            {
                if (B.price >= price1)
                    return B;
            }
            return null;
        }
    }
}
