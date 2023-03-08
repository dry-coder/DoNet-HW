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
            int a, b;
            Console.WriteLine("Please enter two int number and a operator:");
            a = Int32.Parse(Console.ReadLine());
            b = Int32.Parse(Console.ReadLine()); ;
            string opreator;
            opreator = Console.ReadLine();
            int result = 0;
            switch (opreator)
            {
                case "+":
                    result = a + b;
                    break;
                case "-":
                    result = b - a;
                    break;
                case "/":
                    if (b != 0)
                        result = a / b;
                    else
                        Console.WriteLine("error!");
                    break;
                case "*":
                    result = a * b;
                    break;
                default:
                    Console.WriteLine("default");
                    break;

            }
            Console.WriteLine(result);
        }
    }
}
