using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program3
{
    class Program
    {
        static void Main(string[] args)
        {
            int ComNum = 0;//非素数
            for (int i = 2; i <= 100; i++)
            {
                for (int j = 2; j <= i; j++)
                {
                    if (i % j == 0 && i != j)//判断是否为非素数
                    {
                       ComNum = i;//记录非素数
                        break;
                    }
                    
                }
                if (i != ComNum)//判断是否为素数
                    Console.Write(i + "\t");
            }

        }
    }
}
