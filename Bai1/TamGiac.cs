using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class TamGiac
    {
        double a;
        double b;
        double c;
        public double A { get { return a; } set { a = value; } }
        public double B { get { return b; } set { b = value; } }
        public double C { get { return c; } set { c = value; } }

        public void Nhap()
        {
            Console.Write("Nhap vao a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap vao b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap vao c: ");
            c = Convert.ToDouble(Console.ReadLine());
        }

        public void KiemTraTamGiac()
        {
            if (a + b > c && b + c > a && a + c > b && a > 0 && b > 0 && c > 0)
            {
                Console.WriteLine("\nDay la tam giac thuong");
                if (a == b && b == c)
                {
                    Console.WriteLine("\nDay la tam giac deu");
                }
                else if (a * a == b * b + c * c || b * b == a * a + c * c || c * c == a * a + b * b)
                {
                    Console.WriteLine("\nDay la tam giac vuong");
                }
                else if (a * a > b * b + c * c || b * b > a * a + c * c || c * c > a * a + b * b)
                {
                    Console.WriteLine("\nDay la tam giac can");
                }
            }
            else
            {
                Console.WriteLine("\nDay khong phai tam giac");
                Environment.Exit(0);
            }
        }

        public double ChuVi()
        {
            return a + b + c;
        }

        public double DienTich()
        {
            double p = ChuVi() / 2;
            return Math.Sqrt(p *(p-a)*(p-b)*(p-c));
        }

        public void Xuat()
        {
            KiemTraTamGiac();
            Console.WriteLine($"\nChu vi tam giac la: {ChuVi()}");
            Console.WriteLine($"\nDien tich tam giac la: {Math.Round(DienTich())}");
        }
    }
}