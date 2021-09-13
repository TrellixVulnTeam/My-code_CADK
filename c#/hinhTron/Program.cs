using System;

namespace hinhTron
{
    class Program
    {

        public class HinhTron{
            private double r;
            public double R {
                get{return r;}
                set{
                    if(value < 0){
                        Console.Write("Data error");
                        r = 0;
                    }
                    else{
                        r = value;
                    }
                }
                
            }
            public HinhTron(){
                this.r = 0;
            }
            public HinhTron(double r){
                this.r = r;
            }

            public void nhap(){
                Console.Write("Nhap ban kinh hinh tron: ");
                this.r = double.Parse(Console.ReadLine());
            }
            public double TinhChuVi(){
                return this.r * 2 * Math.PI;
            }
            public double TinhDienTich(){
                return Math.Pow(this.r, 2);
            }
            public void xuat(){
                Console.WriteLine($"Hinh tron co ban kinh: {r:0.00}, chu vi: {TinhChuVi():0.00}, dien tich: {TinhDienTich():0.00}");
            }
        }
        static void Main(string[] args)
        {
            HinhTron a = new HinhTron();
            a.nhap();
            a.xuat();
            HinhTron b = new HinhTron(5.0f);
            Console.WriteLine($"Chu vi hinh tron b: {b.TinhChuVi():0.00}");
            Console.WriteLine($"Dien tich hinh tron b: {b.TinhDienTich():0.00}");
        }
    }
}
