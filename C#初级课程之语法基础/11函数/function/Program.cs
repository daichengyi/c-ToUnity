using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //函数
            Hello();

            //ref
            int num = 10;
            AddRef(ref num);//引用传递
            Console.WriteLine("AddRef====={0}", num);

            //out
            int a = 10;
            int b = 15;
            int max;
            int min;
            int total;
            double avg;
            NumberOut(a, b,out max, out min, out total, out avg);


            //递归
            Console.WriteLine(NumberAdd(100));

            Console.ReadKey();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        static string Hello()
        {
            Console.WriteLine("函数被调用了！");

            return "返回值";
        }


        /** 函数重载*/
        static string Hello(string str)
        {
            return str;
        }

        static string Hello(int str)
        {
            return str.ToString();
        }


        /** 函数之高级参数*/
        static void Add(int num)
        {
            Console.WriteLine("start====={0}",num);
            num += 10;
            Console.WriteLine("end====={0}", num);
        }

        //ref 参数
        static void AddRef(ref int num)
        {
            num += 10;
            Console.WriteLine("void AddRef====={0}", num);
        }


        //out，返回 最大、最小、和、平均值
        static void NumberOut( int a,int b, out int max, out int min,out int total,out double avg)
        {
            if(a > b)
            {
                max = a; 
                min = b;
            }
            else
            {
                max = b; 
                min = a;
            }
            total = a + b;
            avg = total / 2;
        }

        /** 函数递归调用*/
        //实现1+2+3+.....+N之和
        static int NumberAdd(int n)
        {
            if(n == 1)  return 1;
            return n + NumberAdd(n-1);
        }
    }
}
