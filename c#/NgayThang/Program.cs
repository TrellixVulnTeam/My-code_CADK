using System;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace BT7_2{
    class Program{

        class NgayThang{
            private DateTime dt;

            public NgayThang(){
                dt = new DateTime(1,1,1);
            }

            public NgayThang(int year, int month, int day){
                dt = new DateTime(year,month,day);
            }

            public DateTime DMY{
                get { return dt;}
                set{dt = value;}
            }

            public NgayThang(NgayThang nt){
                this.dt = nt.dt;
            }

            public NgayThang hieu(NgayThang nt1, NgayThang nt2){
                NgayThang h = new NgayThang();

                DateTime dt1 = new DateTime(nt1.DMY.Year, nt1.DMY.Month, nt1.DMY.Day);
                DateTime dt2 = new DateTime(nt2.DMY.Year, nt2.DMY.Month, nt2.DMY.Day);
                DateTime hieuDt;

                if(dt1 > dt2){
                    hieuDt = dt1.AddYears(-dt2.Year).AddMonths(-dt2.Month).AddDays(-dt2.Day);

                }
                else{
                    hieuDt = new DateTime(1,1,1);
                }

                    h.dt = hieuDt;
                return h;
            }
            public NgayThang tong(NgayThang nt1, NgayThang nt2){
                NgayThang c = new NgayThang();

                DateTime dt1 = new DateTime(nt1.DMY.Year, nt1.DMY.Month, nt1.DMY.Day);
                DateTime dt2 = new DateTime(nt2.DMY.Year, nt2.DMY.Month, nt2.DMY.Day);
                DateTime tongDt;
                tongDt = dt1.AddYears(dt2.Year).AddMonths(dt2.Month).AddDays(dt2.Day);
                c.dt = tongDt;
                return c;
            }

            public bool soSanh(NgayThang nt1, NgayThang nt2){
                bool ss = false;
                DateTime dt1 = new DateTime(nt1.DMY.Year, nt1.DMY.Month, nt1.DMY.Year);
                DateTime dt2 = new DateTime(nt2.DMY.Year, nt2.DMY.Month, nt2.DMY.Year);

                if (dt1.Year == dt2.Year && dt1.Month == dt2.Month && dt1.Day == dt2.Day){
                    ss = true;
                }
                return ss;
            }

            public static NgayThang operator - (NgayThang nt1, NgayThang nt2)
            {
                DateTime dt1 = new DateTime(nt1.DMY.Year, nt1.DMY.Month, nt1.DMY.Day);
                DateTime dt2 = new DateTime(nt2.DMY.Year, nt2.DMY.Month, nt2.DMY.Day);
                DateTime dtTru;
                if (dt1 > dt2)
                    {
                        dtTru = dt1.AddYears(-dt2.Year).AddMonths(-dt2.Month).AddDays(-dt2.Day);
                    }
                    else
                    {
                        dtTru = new DateTime(1, 1, 1);
                    }
                return new NgayThang(dtTru.Year, dtTru.Month, dtTru.Day);
            }
            public static NgayThang operator + (NgayThang nt1, NgayThang nt2)
            {
                DateTime dt1 = new DateTime(nt1.DMY.Year, nt1.DMY.Month, nt1.DMY.Day);
                DateTime dt2 = new DateTime(nt2.DMY.Year, nt2.DMY.Month, nt2.DMY.Day);
                DateTime dtCong;
                dtCong = dt1.AddYears(dt2.Year).AddMonths(dt2.Month).AddDays(dt2.Day);
                return new NgayThang(dtCong.Year, dtCong.Month, dtCong.Day);
            }

            public static bool operator /(NgayThang nt1, NgayThang nt2){
                bool ss = false;
                DateTime dt1 = new DateTime(nt1.DMY.Year, nt1.DMY.Month, nt1.DMY.Day);
                DateTime dt2 = new DateTime(nt2.DMY.Year, nt2.DMY.Month, nt2.DMY.Day);

                if (dt1.Year == dt2.Year && dt1.Month == dt2.Month && dt1.Day == dt2.Day)
                {
                    ss = true;
                }
                return ss;
            }


            public int eDay(){
                Console.Write("enter day: ");
                int day = int.Parse(Console.ReadLine());

                if (day < 1 || day > 31)
                {
                    Console.WriteLine("ban da nhap sai, vui long nhap lai: ");
                    return eDay();
                }
                else
                {
                    return day;
                }
            }
            
            public int eMonth(){
                Console.Write("enter month: ");
                int month = int.Parse(Console.ReadLine());

                if (month < 1 || month > 12)
                {
                    Console.WriteLine("ban da nhap sai, vui long nhap lai: ");
                    return eMonth();
                }
                else
                {
                    return month;
                }
            }

            public int tinhSoNgayTrongNam(int month, int year){
                int nNumOfDays;

                switch (month){
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        nNumOfDays = 31;
                        break;
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        nNumOfDays = 30;
                        break;
                    default:
                        if (laNamNhuan(year))
                        {
                            nNumOfDays = 29;
                        }
                        else
                        {
                            nNumOfDays = 28;
                        }
                        break;
                }
                return nNumOfDays;
            }

            public bool laNamNhuan(int nYear){
                if ((nYear % 4 == 0 && nYear % 100 != 0) || nYear % 400 == 0)
                {
                    return true;
                }
                return false;
            }
            public void nhap(){
                int day = eDay();
                int month = eMonth();
                
                Console.Write("enter year: ");
                int year = int .Parse(Console.ReadLine());

                if(tinhSoNgayTrongNam(month,year)>= day){
                    DMY = new DateTime(year,month,day);

                }
                else{
                    Console.WriteLine("ban da nhap sai, vui long nhap lai: ");
                    nhap();
                }
            }
            public void xuat(){
                Console.WriteLine($"Day {dt.Day}, month{dt.Month},year{dt.Year}");
            }

        }

        
        static void Main(String[] agrs){
            NgayThang nt1 = new NgayThang();
            NgayThang nt2 = new NgayThang();

            Console.WriteLine("enter the first day: ");
            nt1.nhap();
            Console.WriteLine();
            Console.WriteLine("enter the second day: ");
            nt2.nhap();
            Console.WriteLine();

            nt1.xuat();
            nt2.xuat();
            Console.WriteLine();

            Console.WriteLine("hieu 2 ngay thang: ");
            NgayThang hieuOperator = nt1 - nt2;
            hieuOperator.xuat();
            Console.WriteLine();
            
            Console.WriteLine("tong 2 ngay thang: ");
            NgayThang tongOperator = nt1 + nt2;
            tongOperator.xuat();
            Console.WriteLine();

            Console.WriteLine("so sanh 2 ngay thang: "+nt1/nt2);
            Console.WriteLine();          
        }
    }
}