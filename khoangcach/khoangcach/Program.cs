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
            Double a=0, b=0,c=0,d=0,kc=0;
Homan:
            try
            {
                Console.WriteLine("nhap toa do diem thu 1 ");
                Console.Write("Nhập vào tọa độ x1: ");
                a = Double.Parse(Console.ReadLine());
                Console.Write("Nhập vào tọa độ y1: ");
                b = Double.Parse(Console.ReadLine());
                Console.WriteLine("nhap toa do thu 2");
                Console.Write("Nhập vào tọa độ x2: ");
                c = double.Parse(Console.ReadLine());
                Console.Write("Nhập vào tọa độ y2: ");
                d = double.Parse(Console.ReadLine());
                kc = Math.Sqrt((a - c) * (a - c) + (b - d) * (b - d));
                Console.WriteLine("kc= " + kc);
            }
            catch (Exception e) {
                Console.WriteLine("Số Bạn nhập không hợp lệ xin nhập lại!");
                goto Homan;

            }
             Console.ReadKey();
        }
    }
}
