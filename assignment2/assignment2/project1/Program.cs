using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Please enter a number:");
            a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("the prime factors of this number are following:");
            for (int i = 2; i <= a; i++)
            {
                if (IsPrime(i) && a % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        //判断一个数是否是素数
        static bool IsPrime(int num)
        {
            bool result = true;
            for (int j = 2; j * j <= num; j++)
            {
                if (num % j == 0)
                {
                    result = false;
                    break;
                }
            }
            return result;
        }
    }
}
