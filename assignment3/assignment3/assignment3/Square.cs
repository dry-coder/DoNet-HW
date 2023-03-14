using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    internal class Square:Shape
    {
        private double wide;//正方形的长
        private double length;//正方形的宽
        private double Wide { 
            set
            {
                wide = value;
            }
            get
            {
                return wide;
            }
        }
        private double Length
        {
            set
            {
                length = value;
            }
            get
            {
                  return length;
            }
        }
        public Square() { }
        public Square(double wide,double length)
        {
            this.wide = wide;   
            this.length = length;
            Console.WriteLine($"这个正方形的长为{length},宽为{wide}");
        }
        public override bool IsShape {
            get
            {
                return wide == length;
            }
        }
        public override double Area {
            get {
                if (wide != length)
                    return 0;
                
                return length * length;
            }
        }
    }
}
