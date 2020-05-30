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
            Program p = new Program();
            Console.WriteLine("请输入任意正整数：");
            int num = Convert.ToInt32(Console.ReadLine());
            p.One(num);
            int[] x = new int []{ 12, 21, 6, 2, 8, 3, 9 };
            Console.WriteLine();
            Console.WriteLine("整数数组如下：");
            for (int i = 0; i < x.Length; i++)
                Console.Write("{0}  ", x[i]);
            Console.WriteLine();
            Console.WriteLine("最大值为：{0}", p.zuidazhi(x));
            Console.WriteLine("最小值为：{0}", p.zuixiaozhi(x));
            Console.WriteLine("平均值为：{0}", p.pingjunzhi(x));
            Console.WriteLine("求和为：{0}", p.qiuhe(x));
            Console.WriteLine();
            p.aishi();
            Console.ReadLine();
        }
        private void One(int x)
        {
            Console.WriteLine("{0}的所有素数因子为：", x);
            for(int i=1;i<=x;i++)
                if(x%i==0&&Ifsushu(i)==true)
                    Console.Write("{0}  ",i);
            Console.WriteLine();
        }
        private bool Ifsushu(int x)
        {
            int a = (int)Math.Sqrt(x);
            for (int i = 2; i <= a; i++)
                if (x % i == 0)
                    return false;
            return true;
        }
        private int zuidazhi(int []x)
        {
            int a = x[0];
            for(int i=0;i<x.Length;i++)
                if (a < x[i])
                    a = x[i];
            return a;
        }
        private int zuixiaozhi(int[] x)
        {
            int a = x[0];
            for (int i = 0; i < x.Length; i++)
                if (a > x[i])
                    a = x[i];
            return a;
        }
        private double pingjunzhi(int[] x)
        {
            return Convert.ToDouble(qiuhe(x)) / x.Length;
        }
        private int qiuhe(int []x)
        {
            int sum = 0;
            for (int i = 0; i < x.Length; i++)
                sum += x[i];
            return sum;
        }
        private void aishi()
        {
            Console.WriteLine("2-100之间的素数如下：");
            bool[] x = new bool[99];
            for (int i = 0; i < 99; i++)
                x[i] = true;
            for (int i = 2; i <= 50; i++)
                for (int j = i + 1; j <= 100; j++)
                    if (j % i == 0)
                        x[j - 2] = false;
            for (int i = 0; i < 99; i++)
                if (x[i] == true)
                    Console.Write("{0} ", i + 2);

        }
    }
}
