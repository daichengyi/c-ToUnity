using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07typeConvert
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 类型转换
            // 1.隐式（自动类型转换）
            // 转换条件： int（4字节） ---> float （4字节）---> double （8字节） 小转大
            int num1 = 10;
            float num2;
            double num3;

            num2 = num1;
            num3 = num1;

            //2.显式（强制类型转换）
            // 转换条件： 转大小
            int num11 = 10;
            float num22 = 10;
            double num33 = 15;

            num11 = (int)num22;

            //3.表达式中的类型转换

            int b = 10;
            float c = 10.1f;

            float a = b + c;

            //4.Convert 类型转换
            Convert.ToDouble(a).ToString();
        }
    }
}
