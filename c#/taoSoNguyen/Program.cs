using System;
using System.Collections.Generic;

namespace taoSoNguyen
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Nhap so phan tu cua day so");
            n = int.Parse(Console.ReadLine());

            List<int> dso = new List<int>(n);
            Random a = new Random();

            for (int i = 0; i < dso.Capacity; i++)
            {
                int k = a.Next(100);
                dso.Add(k);

            }
            // use foreach

            foreach (int t in dso)
            {
                Console.Write(t + " ");
            }
            Console.ReadLine();
        }
    }
}
