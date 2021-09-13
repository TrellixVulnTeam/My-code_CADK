using System;
using System.Dynamic;

namespace Student
{
    class Student{
        private string hoTen;
        private int tuoi;
        private double diemToan;
        private double diemVan;
        private double diemTrungBinh;
    
        public Student(){
            HoTen = " ";
            Tuoi = 0;
            DiemToan = 0;
            DiemVan = 0;
            dtb = 0;
        }

        public string HoTen{
            get{
                return hoTen;
            }
            set{
                hoTen = value;
            }
        }
        public int Tuoi{
            get{
                return tuoi;
            }
            set{
                tuoi = value;
            }
            
        }
        public double DiemToan{
            get{
                return diemToan;
            }
            set{
                diemToan = value;
            }
        }
        public double DiemVan{
            get{
                return diemVan;
            }
            set{
                diemVan = value;
            }
        }
        public double dtb{
            get{
                return Math.Round(((diemToan+DiemVan)/2),2);
            }
            set{
                diemTrungBinh = value;
            }
        }
        public void nhap(){
            Console.Write("Nhap ho ten: ");
            hoTen = Console.ReadLine();
            Console.Write("Nhap tuoi: ");
            double temp;
            temp = double.Parse(Console.ReadLine());
            if(temp < 0){
                Console.WriteLine("Tuoi cua ban phai > 0");
                Console.Write("Nhap lai tuoi: ");
                temp = double.Parse(Console.ReadLine());
            }
            Tuoi = (int)temp;
            Console.Write("Nhap diem toan: ");
            temp = double.Parse(Console.ReadLine());
            if(temp > 10 || temp < 0){
                Console.WriteLine("Diem phai nam trong khoang 0 -> 10");
                Console.Write("Nhap laij diem van: ");
                temp = double.Parse(Console.ReadLine());
            }
            DiemVan = temp;
        }
        public void xuat(){
            Console.WriteLine($"{HoTen,-15}{Tuoi,-15}{DiemToan,-15}{DiemVan,-15}{dtb,-15}");
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Nhap so luong hoc sinh: ");
            n = int.Parse(Console.ReadLine());
            Student[] arrStudent = new Student[n];
            for(int i = 0; i < n; i++){
                Console.WriteLine("Nhap trong tin sinh vien: "+(i+1).ToString());
                arrStudent[i] = new Student();
                arrStudent[i].nhap();
            }
            Console.WriteLine("danh sach hoc sinh: ");
            Console.WriteLine("{0,-15}{1,-15}{2,-15}{3,-15}{4,-15}","Ho ten","Tuoi","Diem toan","Diem van","Diem trung binh");
			for (int i = 0; i < n; i++)
			{
				arrStudent[i].xuat();
			}
        }
    }
}
