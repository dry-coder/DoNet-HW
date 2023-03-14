using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    internal class Rectangle:Shape
    {
        private double wide;//长方形的长
        private double length;//长方形的宽
        private double Wide
        {
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
        public Rectangle() { }
        public Rectangle(double wide, double length)
        {
            this.wide = wide;
            this.length = length;
            Console.WriteLine($"这个长方形的长为{length},宽为{wide}");

        }
        public override bool IsShape
        {
            get
            {
                return wide != length;
            }
        }
        public override double Area
        {
            get { 
                if(wide == length)
                    return 0;
                return wide * length; }
        }

    }
}
