using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using program1;

namespace program2
{
    
    public partial class Form1 : Form
    {
        public List<OrderDetails> orders = new List<OrderDetails>();
        public OrderService os = new OrderService();
        public string KeyWord1 { get; set; }
        public string KeyWord2 { get; set; }
        public string KeyWord3 { get; set; }
        public string KeyWord4 { get; set; }
        public Form1()
        {
            InitializeComponent();
            orderDetailsBindingSource.DataSource = os.GetAllOrders();
            //绑定查询条件
            textBox1.DataBindings.Add("Text", this, "KeyWord1");
            textBox2.DataBindings.Add("Text", this, "KeyWord2");
            textBox3.DataBindings.Add("Text", this, "KeyWord3");
            textBox4.DataBindings.Add("Text", this, "KeyWord4");

        }
        //查询订单号
        private void button1_Click(object sender, EventArgs e)
        {
            orderDetailsBindingSource.DataSource = os.SearchOrder1(KeyWord1);
        }
        //删除订单
        private void button3_Click(object sender, EventArgs e)
        {
            os.DeleteOrder(KeyWord1);
            orderDetailsBindingSource.DataSource = os.GetAllOrders().Where(s => s.num != "\0");
        }
        //添加订单
        private void button2_Click(object sender, EventArgs e)
        {
            Form2 obj2 = new Form2();
            obj2.ShowDialog();
            os.AddOrder(obj2.text1(), obj2.text2(), obj2.text5(), obj2.text3(), double.Parse(obj2.text4()));
            orderDetailsBindingSource.DataSource = os.GetAllOrders().Where(s => s.num != "\0");
        }
        //修改订单
        private void button4_Click(object sender, EventArgs e)
        {
            Form3 obj3 = new Form3();
            obj3.ShowDialog();
            os.ChangeOrder(obj3.text1(), obj3.text2(), obj3.text9(), obj3.text3(), double.Parse(obj3.text4()), obj3.text5(), obj3.text6(), obj3.text10(), obj3.text7(), double.Parse(obj3.text8()));
            orderDetailsBindingSource.DataSource = os.GetAllOrders().Where(s => s.num != "\0");
        }
        //商品名查询
        private void button5_Click(object sender, EventArgs e)
        {
            orderDetailsBindingSource.DataSource = os.SearchOrder2(KeyWord3);
        }
        //客户名查询
        private void button6_Click(object sender, EventArgs e)
        {
            orderDetailsBindingSource.DataSource = os.SearchOrder3(KeyWord2);
        }
        //电话号码查询
        private void button7_Click(object sender, EventArgs e)
        {
            orderDetailsBindingSource.DataSource = os.SearchOrder4(KeyWord4);
        }
        //导出HTML
        private void button8_Click(object sender, EventArgs e)
        {
            os.Xsltorder();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        public void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        public void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        public void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void orderDetailsBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }


    }
}
