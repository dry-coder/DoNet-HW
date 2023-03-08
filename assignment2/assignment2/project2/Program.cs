using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace project2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int max, min, avg, sum;
            int n = Int32.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Int32.Parse(Console.ReadLine());
            }
            GetNumFromArray(arr, out max, out min, out avg, out sum);
            Console.WriteLine($"max:{max}  min:{min}  avg:{avg}  sum:{sum}");
        }

        static void GetNumFromArray(int[] arr, out int max, out int min, out int avg, out int sum)//得到最大值，最小值，平均值
        {
            max = arr[0];
            min = arr[0];
            sum = 0;
            avg = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }

                if (arr[i] < min)
                {
                    min = arr[i];
                }
                sum += arr[i];
            }
            avg = sum / arr.Length;
        }
    }

}
