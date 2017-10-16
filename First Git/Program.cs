using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace First_Git
{
    class Program
    {
        static void Main(string[] args)
        {

            Jisuanqi ji = new Jisuanqi();
            try
            {
                Console.WriteLine("请输入第一个数");
                string j = Console.ReadLine();
                ji.A = double.Parse(j);
            }
            catch (Exception e)
            {
                Console.WriteLine("输入错误！！！请输入数字");
            }
            try
            {
                Console.WriteLine("请输入第二个数");
                string k = Console.ReadLine();
                ji.C = double.Parse(k);
            }
            catch (Exception e)
            {
                Console.WriteLine("输入错误！！！请输入数字");
            }
            try
            {
                Console.WriteLine("请输入你的计算");
                string i = Console.ReadLine();
                ji.B = char.Parse(i);
            }
            catch (Exception e)
            {
                Console.WriteLine("输入错误！！！请输入加减乘除");
            }
            ji.Jisuan();
            Console.WriteLine("请输入字符串");
            string p1 = Console.ReadLine();
            Console.WriteLine("请输入计算");
            string pq = Console.ReadLine();
            ji.D = char.Parse(pq);
            Console.WriteLine("请输入字符串");
            string q1 = Console.ReadLine();
            ji.Jisuan(p1, q1);
        }
    }
    class Jisuanqi
    {
        private double a;

        public double A
        {
            get { return a; }
            set { a = value; }
        }
        private char b;

        public char B
        {
            get { return b; }
            set { b = value; }
        }
        private double c;

        public double C
        {
            get { return c; }
            set { c = value; }
        }
        private char d;

        public char D
        {
            get { return d; }
            set { d = value; }
        }
        public void Jisuan()
        {
            switch (b)
            {
                case '+': Console.WriteLine(a + c); break;
                case '-': Console.WriteLine(a - c); break;
                case '*': Console.WriteLine(a * c); break;
                case '/':
                    if (c != 0)
                        Console.WriteLine(a / c);
                    else
                        Console.WriteLine("除数不能为0");
                    break;
                default: Console.WriteLine("请不要输入加减乘除以外的计算"); break;

            }
        }

        public void Jisuan(string p, string q)
        {
            switch (d)
            {
                case '+':
                    p += q;
                    Console.WriteLine(p);
                    break;
                case '-':
                    char[] chars = p.ToCharArray();
                    char[] chars1 = q.ToCharArray();
                    int c = p.Length;
                    for (int i = p.Length - 1; i >= 0; i--)
                    {
                        int j = q.Length;
                        j--;
                        if (chars[i] == chars1[j])
                        {
                            c--;

                        }
                    }
                    for (int k = 0; k < c; k++)
                    {
                        Console.Write(chars[k]);
                    }

                    ; break;

                default: Console.WriteLine("请不要输入加减以外的计算"); break;

            }
        }


    }
}
