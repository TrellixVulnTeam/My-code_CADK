using System;

namespace tongHieuTichThuong
{
    class Program
    {     
        static void Main(string[] args)
        {
            
                int a,b;
                Console.WriteLine("Nhap gia tri so thu 1: ");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhap gia tri so thu 2: ");
                b = int.Parse(Console.ReadLine());
                Console.WriteLine($"tong: {a+b}\n hieu: {a-b}\n tich: {a*b}\n thuong: {1.0*a/b}");
            
        }
    }
}
