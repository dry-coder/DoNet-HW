using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, m;//n*m的矩阵
            n = Int32.Parse(Console.ReadLine());
            m = Int32.Parse(Console.ReadLine());
            int[,] metrix = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    metrix[i, j] = Int32.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("the metrix is :");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(metrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            bool flag = JudgeMetrix(metrix, n, m);
            if (flag)
            {
                Console.WriteLine("Yes,this is asked one");
            }
            else
                Console.WriteLine("No,this isn't asked one");
        }
        static bool JudgeMetrix(int[,] arr, int n, int m)//判断是否符合要求
        {
            bool flag = true;
            int start = 0;
            while (start < n)
            {
                for (int i = 0, j = start; i < n - 1 && j < m - 1; i++, j++)
                {
                    if (arr[i, j] != arr[i + 1, j + 1])
                    {
                        flag = false;
                    }

                }
                start++;
            }
            return flag;
        }
    }
}
