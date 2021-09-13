using System;

namespace NhanVien2
{
    class NhanVien{
        private string mnv;
        private string hoTen;
        private int hsl;
        private int namVaoLam;
        public NhanVien(){
            MaNhanVien = "";
            hoTen = "";
            HeSoLuong = 0;
            namVaoLam = 0;
        }
        public string MaNhanVien{
            get{
                return mnv;
            }
            set{
                mnv = value;
            }
        }
        public string HoTen{
            get{
                return hoTen;
            }
            set{
                hoTen = value;
            }
        }
        public int HeSoLuong{
            get{
                return hsl;
            }
            set{
                hsl = value;
            }
        }
        public int NamVaoLam{
            get {
                return namVaoLam;
            }
            set{
                namVaoLam = value;
            }
        }
        public float Luong(float _hsl, float _nvl){
            float LCB = _hsl*150000;
            float HSPCTN = (DateTime.Now.Year - _nvl)/100;
            return LCB * HSPCTN;
        }
        public void nhap(){
            Console.Write("enter mnv: ");
            MaNhanVien = Console.ReadLine();
            Console.Write("enter hoTen: ");
            HoTen = Console.ReadLine();
            Console.Write("enter hsl: ");
            HeSoLuong = int.Parse(Console.ReadLine());
            Console.Write("Enter nam vao lam: ");
            NamVaoLam = int.Parse(Console.ReadLine());
        }
        public void xuat(){
            Console.WriteLine($"{MaNhanVien,-15}{HoTen,-15}{HeSoLuong,-15}{NamVaoLam,-15}{Luong(HeSoLuong,NamVaoLam)}");
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            int n;
            Console.Write("Nhap so luong nv: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            NhanVien[] arrNhanVien = new NhanVien[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap thong tin nhan vien thu : "+ (i+1).ToString());
                arrNhanVien[i] = new NhanVien();
                arrNhanVien[i].nhap();
            }

            Console.WriteLine("Luong theo tung nhan vien: ");
            Console.WriteLine("{0,-20} {1,-20} {2,-20} {3,-20} {4}", "MaNhanVien", "HoTen", "HeSoLuong", "NamVaoLam", "Luong");

                for (int i = 0; i < n; i++)
                {
                    arrNhanVien[i].xuat();
                }
        }
    }
}
