using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace khoangcach
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b,c,d,kc;
            Console.WriteLine("nhap toa do diem thu 1 ;");
            a=double.Parse(Console.ReadLine());
            b=double.Parse(Console.ReadLine());
            Console.WriteLine("nhap toa do thu 2:");
            c=double.Parse(Console.ReadLine());
             d=double.Parse(Console.ReadLine());
             kc = Math.Sqrt((a - b) * (a - b) - (c - d) * (c - d));
             Console.WriteLine("kc=" + kc);
        }
    }
}
