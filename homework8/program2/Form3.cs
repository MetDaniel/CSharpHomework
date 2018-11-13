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
    public partial class Form3 : Form
    {
        public List<OrderDetails> orders = new List<OrderDetails>();
        public OrderService os = new OrderService();
        public string KeyWord1 { get; set; }
        public string KeyWord2 { get; set; }
        public string KeyWord3 { get; set; }
        public string KeyWord4 { get; set; }
        public string KeyWord5 { get; set; }
        public string KeyWord6 { get; set; }
        public string KeyWord7 { get; set; }
        public string KeyWord8 { get; set; }
        public string KeyWord9 { get; set; }
        public string KeyWord0 { get; set; }
        public Form3()
        {
            InitializeComponent();
            textBox1.DataBindings.Add("Text", this, "KeyWord1");
            textBox2.DataBindings.Add("Text", this, "KeyWord2");
            textBox3.DataBindings.Add("Text", this, "KeyWord3");
            textBox4.DataBindings.Add("Text", this, "KeyWord4");
            textBox5.DataBindings.Add("Text", this, "KeyWord5");
            textBox6.DataBindings.Add("Text", this, "KeyWord6");
            textBox7.DataBindings.Add("Text", this, "KeyWord7");
            textBox8.DataBindings.Add("Text", this, "KeyWord8");
            textBox9.DataBindings.Add("Text", this, "KeyWord9");
            textBox10.DataBindings.Add("Text", this, "KeyWord0");
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
        public string text6()
        {
            return KeyWord6;
        }
        public string text7()
        {
            return KeyWord7;
        }
        public string text8()
        {
            return KeyWord8;
        }
        public string text9()
        {
            return KeyWord9;
        }
        public string text10()
        {
            return KeyWord0;
        }
        private void Form3_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
