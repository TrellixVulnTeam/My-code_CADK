using System;

namespace dinhThucCap2
{
    class Program
    {
        static void Main(string[] args)
        {
            int del = 0;
            int[,] a = new int[10,10];
            Console.WriteLine("Nhap ma tran vuong cap 2: ");
            for(int i = 0; i < 2; i++){
                for(int j = 0; j < 2; j++){
                    Console.Write($"a[{i}][{j}] = ");
                    a[i,j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Xuat ma tran vuong cap 2: ");
            for(int i = 0; i < 2; i++){
                for (int j = 0; j < 2; j++){
                    Console.WriteLine($"a[{i},{j}] = {a[i,j]}");
                }
            }
            del = del+(a[0,0]*a[1,1]-a[0,1]*a[1,0]);
            Console.WriteLine($"Dinh thuc cap 2 mang a = {del}");
        }
    }
}
