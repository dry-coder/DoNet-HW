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
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            int sum = 0;
            int maxx = Int32.MinValue;
            int minn = Int32.MaxValue;
            list.ForEach(data => Console.WriteLine(data));
            list.ForEach(s => sum += s);
            list.ForEach(m => maxx=(maxx > m) ? maxx : m);
            list.ForEach(m => minn=(minn < m) ? minn : m);
            Console.WriteLine(sum);
            Console.WriteLine(maxx);
            Console.WriteLine(minn);
            List<string> liststr = new List<string>();
            liststr.Add("12345");
            liststr.Add("2345");
            liststr.Add("345");
            liststr.Add("45");
            liststr.Add("5");
            string sumstr="";
            liststr.ForEach(str=>Console.WriteLine(str));
            liststr.ForEach(str=>sumstr += str);
            Console.WriteLine(sumstr);
        }
    }
}
