using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[11] { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5 };
            int Amax = A[0], Amin = A[0], Aaver = 0, Asum = 0;
            for(int i = 0;i <11;i++)
            {
                if(Amax < A[i])//求最大值
                {
                    Amax = A[i];
                }
                if(Amin > A[i])//求最小值
                {
                    Amin = A[i];
                }
                Asum += A[i];//求数组元素的和
            }
            Aaver = Asum / 11;//求数组元素的平均值
            Console.WriteLine("数组的最大值是" + Amax);
            Console.WriteLine("数组的最小值是" + Amin);
            Console.WriteLine("数组的平均值是" + Aaver);
            Console.WriteLine("数组元素的和是" + Asum);
        }
    }
}
