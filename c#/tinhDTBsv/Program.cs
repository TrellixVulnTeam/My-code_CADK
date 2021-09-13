using System;

namespace tinhDTBsv
{
    class Program
    {
        static void Main(string[] args)
        {
            float a,b,c;
            int msv;
            string ten;
            Console.Write("ma sinh vien"); msv = int.Parse(Console.ReadLine());
            Console.Write("Nhap ten: "); ten = Console.ReadLine();
            Console.Write("nhap diem toan: "); a = float.Parse(Console.ReadLine());
            Console.Write("nhap diem van: "); b = float.Parse(Console.ReadLine());
            Console.Write("nhap diem anh: "); c = float.Parse(Console.ReadLine());

            double dtb = (a+b+c)/3;
            Console.WriteLine($"Sinh vien {ten} - {msv}");

            if(dtb >= 8){
                Console.WriteLine("Loai gioi");
            }
            else if(dtb >= 6.5){
                Console.WriteLine("Loai kha");
            }
            else if(dtb >= 5){
                Console.WriteLine("Loai trung binh");
            }
            else{
                Console.WriteLine("Loai yeu");
            }

        }
    }
}
