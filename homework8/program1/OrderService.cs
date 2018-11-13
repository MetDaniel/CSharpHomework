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

namespace program1
{
    public class OrderService
    {
        //检验数据
        string pattern1 = "^[0-9]{4}-0[1-9]|1[0-2]-0[1-9]|[1-2][0-9]|3[0-1]-[0-9]{3}$";
        string pattern2 = "^[0-9]{11}$";
        //添加订单
        public void AddOrder(List<OrderDetails> list, string num1,string cusName1,string phoneNum1,string goodName1,double price1)
        {
            bool uncover = false;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].num == num1)
                {
                    uncover = false;
                    break;
                }
                else
                    uncover = true;
            }
            if (uncover && num1 != null && Regex.IsMatch(num1, pattern1) && Regex.IsMatch(phoneNum1, pattern2))
            {
                OrderDetails A = new OrderDetails(num1, cusName1, phoneNum1, goodName1, price1);
                list.Add(A);
            }
            else
                Console.WriteLine("订单号或电话号码不符合要求");          
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
        public void ChangeOrder(List<OrderDetails> list, string num2, string cusName2, string phoneNum2,string goodName2, double price2, string num1, string cusName1,string phoneNum1, string goodName1, double price1)
        {
            int i = 0;
            OrderDetails B = new OrderDetails(num1, cusName1,phoneNum1, goodName1, price1);
            while (i < list.Count && list[i].num != num2 || list[i].cusName != cusName2 || list[i].phoneNum != phoneNum2 || list[i].goodName != goodName2 || list[i].price != price2)
                i++;
            if (i >= list.Count)
                Console.WriteLine("这条订单不存在，未修改成功");
            else
            {
                bool uncover = false;
                for (int j = 0; j < list.Count; j++)
                {
                    if (list[j].num == num1)
                    {
                        if (i == j)
                            uncover = true;
                        else
                        {
                            uncover = false;
                            break;
                        }                      
                    }
                    else
                        uncover = true;
                }
                if (num1 != null && Regex.IsMatch(num1, pattern1) && Regex.IsMatch(phoneNum1, pattern2))
                {
                    list[i].num = B.num;
                    list[i].goodName = B.goodName;
                    list[i].phoneNum = B.phoneNum;
                    list[i].cusName = B.cusName;
                    list[i].price = B.price;
                }
                else
                    Console.WriteLine("订单号或电话号码不符合要求");
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
