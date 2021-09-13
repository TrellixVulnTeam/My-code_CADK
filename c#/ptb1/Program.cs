using System;

namespace ptb1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("enter a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("enter b: ");
            b = int.Parse(Console.ReadLine());
            if (a == 0)
            {
                if (b==0)
                {
                    Console.WriteLine("Phuong trinh co vo so nghiem");
                }
                else{
                    Console.WriteLine("Phuong trinh vo nghiem");
                }
            }
            else{
                Console.WriteLine($"Phuong trinh co nghiem: {1.0*-b/a}");
            }
        }
    }
}
