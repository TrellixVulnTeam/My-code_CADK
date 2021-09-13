using System;
using System.Collections.Generic;

namespace tinhNgayThangNam
{
    class Program
    {
        static void Main(string[] args)
        {
            int day, month, year;
            int namNhuan = 0;
            do
            {
                Console.Write("Moi ban nhap nam(year>0): "); year = int.Parse(Console.ReadLine());
            } while (year<=0);
            if(year%4==0 && year % 100 != 0){
                namNhuan = 1;
            }
            do
            {
                Console.Write("Moi ban nhap thang(0 < month < 13): "); month = int.Parse(Console.ReadLine());
            } while (month<=0||month>12);
            if(namNhuan == 1){
                
                if(month == 2){
                    do{
                        Console.Write("Moi ban nhap ngay(0 < day <= 29): "); day = int.Parse(Console.ReadLine());
                    }
                    while(day > 29||day<=0);
                }
                else{
                    if (month == 3|| month == 5|| month == 7|| month == 8|| month == 10|| month == 12) {
                        do{
                            Console.Write("Moi ban nhap ngay(0 < day <= 31): "); day = int.Parse(Console.ReadLine());
                        }
                        while(day > 31|| day <=0);
                    }
                    else{
                        do{
                            Console.Write("Moi ban nhap ngay(0 < ngay <= 30): "); day = int.Parse(Console.ReadLine());
                        }
                        while(day > 30||day<=0);
                    }
                }
            }
            else{
                if(month == 2){
                    do{
                        Console.Write("Moi ban nhap ngay(0 < Ngay <= 28): "); day = int.Parse(Console.ReadLine());
                    }
                    while(day > 28||day<=0);
                }
                else{
                    if (month == 3|| month == 5|| month == 7|| month == 8|| month == 10|| month == 12) {
                        do{
                            Console.Write("Moi ban nhap ngay(0 < day <= 31): "); day = int.Parse(Console.ReadLine());
                        }
                        while(day > 31|| day <=0);
                    }
                    else{
                        do{
                            Console.Write("Moi ban nhap ngay(0 < ngay <= 30): "); day = int.Parse(Console.ReadLine());
                        }
                        while(day > 30||day<=0);
                    }
                }
            }

            int n = (day + ((153 * (month + 12 * ((14 - month) / 12) - 3) + 2) / 5) +
                    (365 * (year + 4800 - ((14 - month) / 12))) +
                    ((year + 4800 - ((14 - month) / 12)) / 4) - 
                    ((year + 4800 - ((14 - month) / 12)) / 100) + 
                    ((year + 4800 - ((14 - month) / 12)) / 400)  - 32045) % 7;
           
            if((n+2)==8){
                Console.Write($"ngay {day} thang {month} nam {year} la CN");
            }else{
                Console.WriteLine($"ngay {day} thang {month} nam {year} la thu {n+2}");
            }
          
        }
    }
}
