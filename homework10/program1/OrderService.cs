using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Xml.Xsl;
using System.Xml.XPath;
using System.Xml;
using System.IO;
using System.Data.Entity;

namespace program1
{
    public class OrderService
    {
        //添加订单
        public void AddOrder(string num1, string cusName1, string phoneNum1, string goodName1, double price1)
        {
            OrderDetails A = new OrderDetails(num1, cusName1, phoneNum1, goodName1, price1);
            using (var db = new OrderDB())
            {
                db.OrderDetails.Add(A);
                db.SaveChanges();
            }
        }
        //删除订单
        public void DeleteOrder(string num1)
        {
            using (var db = new OrderDB())
            {
                var order = db.OrderDetails.SingleOrDefault(o => o.num == num1);
                if(order != null)
                {
                    db.OrderDetails.Remove(order);
                    db.SaveChanges();
                }
                else
                    Console.WriteLine("订单不存在不能删除");
            }
        }
        //修改订单
        public void ChangeOrder(string num2, string cusName2, string phoneNum2, string goodName2, double price2, string num1, string cusName1, string phoneNum1, string goodName1, double price1)
        {
            OrderDetails B = new OrderDetails(num1, cusName1, phoneNum1, goodName1, price1);
            using (var db = new OrderDB())
            {
                var A = db.OrderDetails.SingleOrDefault(o => o.num == num2 && o.goodName == goodName2 && o.cusName == cusName2 && o.price == price2 && o.phoneNum == phoneNum2);
                if (A != null)
                {
                    db.OrderDetails.Remove(A);
                    db.OrderDetails.Add(B);
                    db.SaveChanges();
                }
                else
                    Console.WriteLine("订单修改失败");
            }
        }
        //按订单号查询订单
        public OrderDetails SearchOrder1(string num1)
        {
            using (var db = new OrderDB())
            {
                return db.OrderDetails.SingleOrDefault(o => o.num == num1);
            }
        }
        //按商品名称查询订单
        public OrderDetails SearchOrder2(string goodName1)
        {
            using (var db = new OrderDB())
            {
                return db.OrderDetails.SingleOrDefault(o => o.goodName == goodName1);
            }
        }
        //按客户查询订单
        public OrderDetails SearchOrder3(string cusName1)
        {
            using (var db = new OrderDB())
            {
                return db.OrderDetails.SingleOrDefault(o => o.cusName == cusName1);
            }
        }
        //查询电话号码
        public OrderDetails SearchOrder4(string phoneNum1)
        {
            using (var db = new OrderDB())
            {
                return db.OrderDetails.SingleOrDefault(o => o.phoneNum == phoneNum1);
            }
        }
        //获得所有订单
        public List<OrderDetails> GetAllOrders()
        {
            using (var db = new OrderDB())
            {
                return db.OrderDetails.ToList<OrderDetails>();
            }
        }
        //将订单导出为html文件
        public void Xsltorder()
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(@"..\..\s.xml");

                XPathNavigator nav = doc.CreateNavigator();
                nav.MoveToRoot();

                XslCompiledTransform xt = new XslCompiledTransform();
                xt.Load(@"..\..\s.xslt");
                FileStream outFileStream = File.OpenWrite(@"..\..\s.html");
                XmlTextWriter writer =
                    new XmlTextWriter(outFileStream, System.Text.Encoding.UTF8);
                xt.Transform(nav, null, writer);
            }
            catch (XmlException e)
            {
                Console.WriteLine("XML Exception:" + e.ToString());
            }
            catch (XsltException e)
            {
                Console.WriteLine("XSLT Exception:" + e.ToString());
            }

        }
    }
}
