using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /** 数组认知*/
            int[] intArray;

            intArray = new int[5];

            intArray[0] = 1;

            //声明、初始化、赋值
            double[] doubleArray = new double[] {12,13,14,15,16};

            /** 循环遍历数组*/
            int[] forArr = new int[5] { 1,2,3,4,5};
            for (int i = 0; i < forArr.Length; i++)
            {
                Console.WriteLine(forArr[i]);
            }


            foreach (var item in doubleArray)
            {
                
            }



            /** 数组内存结构*/
            int[] intA = new int[] { 11, 22, 33, 44, 55 };
            int[] intB = intA;
            intB[0] = 1;


            /** 二维数组*/
            int[,] intArr2 = new int[2,4] {{11,12,13,14},{21,22,23,24 } };
            int leng = intArr2.Length;//总长度
            int len1 = intArr2.GetLength(0);//第一个长度
            int len2 = intArr2.GetLength(1);//第二个长度

            Console.WriteLine("leng==={0}",leng);

            Console.ReadKey();

        }
    }
}
