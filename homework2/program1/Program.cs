using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please input an int:");
            string s = Console.ReadLine();
            int n = int.Parse(s);
            Console.Write(n + "的所有素数因子:");
            for(int i = 2;i <= n;i++)
            {
                while(n % i == 0)
                {
                    Console.Write(i + "\t");
                    n /= i;
                }
            }
        }
    }
}
