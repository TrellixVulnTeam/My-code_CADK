using System;

namespace nGiaiThua
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tim so nguyen to su dung thuat toan sang Eratosthenes");
            int n;
            Console.Write("Nhap vao so can tim so nguyen to nho hon: ");
            n = int.Parse(Console.ReadLine());
            bool [] a = new bool[n+1];

            for (int i = 2; i <=n; i++){
                a[i] = true;
            }
            for(int i = 2; i <Math.Sqrt(n);i++){
                if(a[i]){
                    int j = (int)Math.Pow(i,2);
                    while(j<n){
                        a[j] = false;
                        j+=i;
                    }
                }
            }
            Console.WriteLine("Cac co nguyen to la: ");
            for(int i = 2; i <= n; i++){
                if(a[i])
                    Console.Write($"{i}, ");
            }
        }
    }
}
