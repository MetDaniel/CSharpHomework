using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "";
            double d1 = 0;
            double d2 = 0;
            Console.Write("Please input one double:");
            s = Console.ReadLine();
            d1 = double.Parse(s);
            Console.Write("Please input another double:");
            s = Console.ReadLine();
            d2 = double.Parse(s);
            Console.Write(d1 + " multiply " + d2 + " is " + d1 * d2);
        }
    }
}
