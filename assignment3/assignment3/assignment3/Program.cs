using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace project1
{
    public static class Factory {
       public  static int index = 0;//0表示正方形，1表示长方形，2表示三角形
        public static Shape Creator()
        {
            //随机生成1个形状，如果不合法，定义其面积为0
            int num=new Random().Next(3);
                switch (num) { 
                    case 0:
                    index = 0;
                    return new Square(new Random().NextDouble() * 100, new Random().NextDouble() * 100);
                    case 1:
                    index = 1;
                    double r1 = new Random().NextDouble() * 100;
                    Thread.Sleep(100);
                    double r2 = new Random().NextDouble() * 100;
                    return new Rectangle(r1,r2);
                    case 2:
                    index = 2;
                    double t1 = new Random().NextDouble() * 100;
                    Thread.Sleep(100);
                    double t2 = new Random().NextDouble() * 100;
                    Thread.Sleep(100);
                    double t3 = new Random().NextDouble() * 100;
                    return new Triangle(t1,t2,t3);
                    default:
                        index = 0;
                        return new Square(new Random().NextDouble() * 100, new Random().NextDouble() * 100);
            }
        }
    }
    public class Test
    {
        static void Main(string[] args)
        {
            double Areasum = 0;//10个形状的和

            Shape[] shapes = new Shape[10];
            for (int i = 1; i < 11; i++)
            {
                shapes[i - 1] = Factory.Creator();
                Thread.Sleep(100);
                Areasum += shapes[i - 1].Area;
                if (Factory.index == 0 && shapes[i - 1].IsShape)
                {
                    Console.WriteLine($"第{i}个形状为正方形,,其面积为{shapes[i - 1].Area}");
                    Console.WriteLine();
                }
                if (Factory.index == 1 && shapes[i - 1].IsShape) { 
                    Console.WriteLine($"第{i}个形状为长方形,其面积为{shapes[i - 1].Area}");
                Console.WriteLine();
            }
                if (Factory.index == 2 && shapes[i - 1].IsShape) { 
                    Console.WriteLine($"第{i}个形状为三角形,其面积为{shapes[i - 1].Area}");
                Console.WriteLine();
            }
                if (!shapes[i-1].IsShape)
                {
                    Console.WriteLine($"这个形状不合法，其面积为{shapes[i-1].Area}");
                    Console.WriteLine();
                }
            }
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine($"面积之和为{Areasum}");
        }
    }
}
