using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        OrderDetails A = new OrderDetails("301", "李雷", "香皂", 10001);
        public Form1()
        {
            InitializeComponent();
            orders.Add(new OrderDetails("201", "韩梅梅", "肥皂", 200));
            orders.Add(new OrderDetails("301", "李雷", "香皂", 10001));
            orderDetailsBindingSource.DataSource = orders;
            //绑定查询条件
            textBox1.DataBindings.Add("Text", this, "KeyWord1");
            textBox2.DataBindings.Add("Text", this, "KeyWord2");
            textBox3.DataBindings.Add("Text", this, "KeyWord3");
            textBox4.DataBindings.Add("Text", this, "KeyWord4");

        }
        //查询订单号
        private void button1_Click(object sender, EventArgs e)
        {
            orderDetailsBindingSource.DataSource = os.SearchOrder1(orders, KeyWord1);
        }
        //删除订单
        private void button3_Click(object sender, EventArgs e)
        {
            OrderDetails A = os.SearchOrder1(orders, KeyWord1);
            os.DeleteOrder(orders, A);
            orderDetailsBindingSource.DataSource = orders.Where(s => s.num != "\0");
        }
        //添加订单
        private void button2_Click(object sender, EventArgs e) 
        {
            Form2 obj2 = new Form2();
            obj2.ShowDialog();
            os.AddOrder(orders, obj2.text1(), obj2.text2(), obj2.text3(), double.Parse(obj2.text4()));
            orderDetailsBindingSource.DataSource = orders.Where(s => s.price >= 0);
        }
        //修改订单
        private void button4_Click(object sender, EventArgs e)
        {
            Form3 obj3 = new Form3();
            obj3.ShowDialog();
            os.ChangeOrder(orders,obj3.text1(), obj3.text2(), obj3.text3(), double.Parse(obj3.text4()), obj3.text5(), obj3.text6(), obj3.text7(), double.Parse(obj3.text8()));
            orderDetailsBindingSource.DataSource = orders.Where(s => s.num != "\0");
        }
        //商品名查询
        private void button5_Click(object sender, EventArgs e)
        {
            orderDetailsBindingSource.DataSource = os.SearchOrder2(orders, KeyWord3);
        }
        //客户名查询
        private void button6_Click(object sender, EventArgs e)
        {
            orderDetailsBindingSource.DataSource = os.SearchOrder3(orders, KeyWord2);
        }
        //价格查询
        private void button7_Click(object sender, EventArgs e)
        {
            orderDetailsBindingSource.DataSource = os.SearchOrder4(orders, double.Parse(KeyWord4));
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
    }
}
