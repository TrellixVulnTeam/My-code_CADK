using System;
using System.Security;

namespace NhanVien
{
    class NhanVien
    {
        string ms, ht;
        int nc;
        char xl;

        public string Ms
        {
            get { return ms; }
            set { ms = value; }
        }
        public string Ht
        {
            get { return ht; }
            set { ht = value; }
        }
        public int Nc
        {
            get { return nc; }
            set { if (value < 0) { Console.Write("data error"); } else { nc = value; } }
        }
        public char Xl
        {
            get { if (nc > 26) return 'A'; else if (nc >= 22) return 'B'; else return 'C'; }
        }

        public static int LuongNgay = 2000;

        public NhanVien()
        {
            Ms = Ht = "";
            Nc = 0;
        }
        public NhanVien(string ht, string ms, int nc)
        {
            this.ht = ht;
            this.ms = ms;
            this.nc = nc;
        }
        public NhanVien(NhanVien a)
        {
            this.ht = a.Ht;
            this.ms = a.Ms;
            this.nc = a.Nc;

        }

        ~NhanVien()
        {

        }
        public void nhapTTNV()
        {
            Console.Write("Nhap ma so: "); Ms = Console.ReadLine();
            Console.Write("Nhap ho ten: "); Ht = Console.ReadLine();
            Console.Write("Nhap ngay cong: "); Nc = int.Parse(Console.ReadLine());
        }

        public void XuatTTNV()
        {
            Console.WriteLine($"ma so: {ms} ,ho ten: {ht} ,ngay cong: {nc} ,so luong: {Xl} ,luong: {tinhLuong()}");
        }
        public int tinhLuong()
        {
            return nc * LuongNgay;
        }
        public float tinhThuong()
        {
            if (Xl == 'A')
                return tinhLuong() * 5 / 100;
            else
                if (Xl == 'B')
                return tinhLuong() * 2 / 100;
            else return 0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            NhanVien a = new NhanVien();
            a.nhapTTNV();
            a.XuatTTNV();
            Console.WriteLine($"Tinh luong: {a.tinhLuong()}");
            Console.WriteLine($"Tinh thuong: {a.tinhThuong()}");
            Console.WriteLine($"tong nhan: {a.tinhLuong() + a.tinhThuong()}");
        }
    }
}
