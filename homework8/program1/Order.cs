﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    public class Order
    {
        public string num { get; set; }
        public string cusName { get; set; }
        public string phoneNum { get; set; }
        public Order(string num, string cusName,string phoneNum)
        {
            this.num = num;
            this.cusName = cusName;
            this.phoneNum = phoneNum;
        }
    }
}
