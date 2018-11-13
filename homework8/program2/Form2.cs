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
    public partial class Form2 : Form
    {
        public List<OrderDetails> orders = new List<OrderDetails>();
        public OrderService os = new OrderService();
        public string KeyWord1 { get; set; }
        public string KeyWord2 { get; set; }
        public string KeyWord3 { get; set; }
        public string KeyWord4 { get; set; }
        public string KeyWord5 { get; set; }
        public Form2()
        {
            InitializeComponent();
            //绑定查询条件
            textBox1.DataBindings.Add("Text", this, "KeyWord1");
            textBox2.DataBindings.Add("Text", this, "KeyWord2");
            textBox3.DataBindings.Add("Text", this, "KeyWord3");
            textBox4.DataBindings.Add("Text", this, "KeyWord4");
            textBox5.DataBindings.Add("Text", this, "KeyWord5");
        }
        public string text1()
        {
            return KeyWord1;
        }
        public string text2()
        {
            return KeyWord2;
        }
        public string text3()
        {
            return KeyWord3;
        }
        public string text4()
        {
            return KeyWord4;
        }
        public string text5()
        {
            return KeyWord5;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
