using System;

namespace btTrenLop1
{
    class Program
    {
        struct SinhVien
        {
            public int msv;
            public string hoTen;
            public int ns;
            public double diemToan;
            public double diemVan;
            public double diemAnh;
        }

        static void nhapThongTinSV(out SinhVien SV)
        {
            Console.Write(" Ma so: ");
            SV.msv = int.Parse(Console.ReadLine());
            Console.Write(" Ho ten: ");
            SV.hoTen = Console.ReadLine();
            Console.Write("Nam sinh: ");
            SV.ns = int.Parse(Console.ReadLine());
            Console.Write(" Diem toan: ");
            SV.diemToan = Double.Parse(Console.ReadLine());
            Console.Write(" Diem ly: ");
            SV.diemVan = Double.Parse(Console.ReadLine());
            Console.Write(" Diem van: ");
            SV.diemAnh = Double.Parse(Console.ReadLine());
        }
        static void XuatThongTinSinhVien(SinhVien SV)
        {
            Console.WriteLine(" Ma so: " + SV.msv);
            Console.WriteLine(" Ho ten: " + SV.hoTen);
            Console.WriteLine(" Nam sinh: " + SV.ns);
            Console.WriteLine(" Diem toan: " + SV.diemToan);
            Console.WriteLine(" Diem ly: " + SV.diemVan);
            Console.WriteLine(" Diem van: " + SV.diemAnh);
        }

        static double DiemTBSinhVien(SinhVien SV)
        {
            return (SV.diemToan + SV.diemVan + SV.diemAnh * 2) / 4;
        }
        static double DiemChuan(SinhVien SV)
        {
            return (SV.diemToan + SV.diemVan + SV.diemAnh);
        }

        static void ketQua(SinhVien SV)
        {
            if (DiemTBSinhVien(SV) <= 8)
            {
                if (DiemTBSinhVien(SV) < 4 || SV.diemAnh < 3.5 || SV.diemToan < 3.5 || SV.diemVan < 3.5 || DiemChuan(SV) < 25)
                {
                    Console.WriteLine("Rot");
                }
                else
                {
                    Console.WriteLine("Sinh vien co hoc luc kha");
                }
            }
            else if (DiemTBSinhVien(SV) <= 9)
            {
                Console.WriteLine("Sinh vien co hoc luc tot");
            }
            else
            {
                Console.WriteLine("Sinh vien xuat sac toan phan");
            }
        }

        static void Main(string[] args)
        {
            SinhVien SV1 = new SinhVien();
            Console.WriteLine("Nhap thong tin sinh vien: ");
            nhapThongTinSV(out SV1);
            Console.WriteLine("Thong tin sinh vien vua nhap la: ");
            XuatThongTinSinhVien(SV1);
            Console.WriteLine("Diem trung binh cua sinh vien la: " + DiemTBSinhVien(SV1));

            Console.WriteLine("Sinh vien nay da ");
            ketQua(SV1);
            Console.ReadLine();

        }
    }
}
