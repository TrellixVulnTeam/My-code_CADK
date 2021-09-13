using System;
namespace ptb2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b,c;

            Console.Write("enter a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("enter b: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("enter c: ");
            c = int.Parse(Console.ReadLine());

            if (a == 0)
            {
                if (b == 0)
                {
                    if (c==0)
                    {
                        Console.WriteLine("Phuong trinh vo so nghiem");
                    }
                    else{
                        Console.WriteLine("Phuong trinh vo nghiem");
                    }
                }
                else{
                    Console.WriteLine($"Phuong trinh co nghiem: {1.0*-c/b}");
                }
            }
            else{
                double delta = b*b-4*a*c;
                if(delta > 0){
                    Console.WriteLine($"Phuong trinh co 2 nghiem phan biet: \n x1 = {1.0*(-b+Math.Sqrt(delta))/2*a} \n x2 =  {1.0*(-b-Math.Sqrt(delta))/2*a}");
                }
                else if(delta < 0){
                    Console.WriteLine($"Phuong trinh vo nghiem");
                }
                else{
                    Console.WriteLine($"Phuong trinh co nghiem kep: x1 = x2 = {1.0*-b/2*a}");
                }
            }
        }
    }
}
