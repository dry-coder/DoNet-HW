using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    internal class Triangle:Shape
    {
        //三角形的三边，从小到大
        private double length1;
        private double length2;
        private double length3;
        private double Length1
        {
            set { length1 = value; }
            get { return length1; }
        }
        private double Length2
        {
            set { length2 = value; }
            get { return length2; }
        }
        private double Length3
        {
            set { length3 = value; }
            get { return length3; }
        }
        public Triangle() { }
        public Triangle(double length1,double length2,double length3)
        {
            double[] length=new double[3];
            length[0]=length1;
            length[1]=length2;
            length[2]=length3;
            Array.Sort(length);
            this.length1 = length[0];
            this.length2 = length[1];
            this.length3 = length[2];
            Console.WriteLine($"这个三角形的边为{length1}，{length2}, {length3}");

        }
        public override bool IsShape
        {
            get
            {
                return length1 + length2 >length3;
            }
        }
        public override double Area
        {
            get
            {
                if (length1 + length2 <= length3)
                    return 0;
                double p = (length1 + length2 + length3) / 2;
                return Math.Sqrt(p * (p - length1) * (p - length2) * (p - length3));
            }
        }
    }
}
