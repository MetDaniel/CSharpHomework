using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;


namespace program1
{
    public class OrderService:OrderDetails
    {
        //添加订单
        public void AddOrder(List<OrderDetails> list, OrderDetails A)
        {
            list.Add(A);
        }
        //删除订单
        public bool DeleteOrder(List<OrderDetails> list, OrderDetails A)
        {
            int i = 0;
            while (i < list.Count && list[i] != A)
                i++;
            if (i >= list.Count)
                return false;
            else
            {
                list.Remove(list[i]);
                return true;
            }
        }
        //修改订单
        public bool ChangeOrder(List<OrderDetails> list, OrderDetails A, OrderDetails B)
        {
            int i = 0;
            while (i < list.Count && list[i] != A)
                i++;
            if (i >= list.Count)
                return false;
            else
            {
                list[i].num = B.num;
                list[i].goodName = B.goodName;
                list[i].cusName = B.cusName;
                list[i].price = B.price;
                return true;
            }
        }
        //按订单号查询订单
        public bool SearchOrder1(List<OrderDetails> list, string num1)
        {
            foreach (OrderDetails B in list)
            {
                if (B.num == num1)
                    return true;
            }
            return false;
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
        //将所有订单序列化为XML文件
        public void Export(string fileName,object obj)
        {
            XmlSerializer ser = new XmlSerializer(typeof(List<OrderDetails>));
            FileStream fs = new FileStream(fileName, FileMode.Create);
            ser.Serialize(fs, obj);
            fs.Close();
        }
        //从XML文件中载入订单
        public object Import(string fileName)
        {
            string xml = File.ReadAllText(fileName);
            try
            {
                using (StringReader sr = new StringReader(xml))
                {
                    XmlSerializer xmldes = new XmlSerializer(typeof(List<OrderDetails>));
                    return xmldes.Deserialize(sr);
                }
            }
            catch (Exception e)
            {

                return null;
            }
        }
    }
}
