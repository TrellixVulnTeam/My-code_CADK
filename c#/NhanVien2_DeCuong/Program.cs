using System;
using System.Xml;
using System.Collections.Generic;
using System.Linq;
namespace Cau7_DeCuong
{
    class NhanVien
    {
        string manv; 
        string tennv; 
        string phongban;

        string chucvu; 
        double hsl; 
        float thamnien; 
        int songaylam;
        const double luongcoban = 1150;

        public string MaNV
        {
            get { return this.manv; }
            set { manv = value; }
        }
        public string TenNV
        {
            get { return this.tennv; }
            set { tennv = value; }
        }
        public string PhongBan
        {
            get { return this.phongban; }
            set { phongban = value; }
        }
        public string ChucVu
        {
            get { return this.chucvu; }
            set { chucvu = value; }
        }
        public double HSL
        {
            get { return this.hsl; }
            set { hsl = value; }
        }
        public float ThamNien
        {
            get { return this.thamnien; }
            set { thamnien = value; }
        }
        public int SoNgayLam
        {
            get { return this.songaylam; }
            set { songaylam = value; }
        }
        public double PhuCap
        {
            get
            {
                double phucap = 0;
                if (ChucVu == "Lanh dao")
                {
                    return phucap = 2000;
                }
                return phucap;
            }
        }
        public double HeSoThiDua
        {
            get
            {
                double hstd = 0;
                if (ChucVu == "Lanh dao")
                {
                    return hstd = 1;
                }
                else
                {
                    if (ChucVu == "Nhan vien")
                    {

                        if (SoNgayLam > 22)
                        {
                            return hstd = 1;
                        }
                        else
                        {
                            if (SoNgayLam > 20)
                            {
                                return hstd = 0.8;
                            }
                            else
                            {
                                return hstd = 0.6;
                            }
                        }
                    }
                }
                return hstd;
            }
        }
        public double Luong
        {
            get { return HSL * luongcoban * HeSoThiDua + 1100 + PhuCap; }
        }
        public virtual void Nhap()
        {
            do
            {
                Console.Write("Nhap ma nhan vien: "); this.manv = Console.ReadLine();
            } while (this.manv.Length < 4);
            do
            {
                Console.Write("Nhap ten nhan vien: "); this.tennv = Console.ReadLine();
            } while (this.tennv.Length < 2);
            do
            {
                Console.Write("Nhap ten phong ban: "); this.phongban = Console.ReadLine();
            } while (this.phongban.Length < 4);
            do
            {
                Console.Write("Nhap chuc vu (chi dc nhap 'lanh dao' hoac 'nhan vien'): ");
                this.ChucVu = Console.ReadLine();
            } while (this.ChucVu != "Lanh dao" && this.ChucVu != "Nhan vien");

            do
            {
                Console.Write("Nhap he so luong: "); this.hsl = double.Parse(Console.ReadLine());
            } while (this.hsl < 0);
            do
            {
                Console.Write("Nhap tham nien cong tac: "); this.thamnien = float.Parse(Console.ReadLine());
            } while (this.thamnien < 0);

            do
            {
                Console.Write("Nhap so ngay lam trong thang: "); this.songaylam = int.Parse(Console.ReadLine());
            } while (this.songaylam < 0 && this.songaylam > 31);
        }
        public virtual void Xuat()
        {
            Console.WriteLine("***************************************"); 
            Console.WriteLine("**********Thong tin nhan vien**********"); 
            Console.WriteLine("Ma nhan vien: {0}", MaNV); 
            Console.WriteLine("Ten nhan vien: {0}", TenNV); 
            Console.WriteLine("Phong ban: {0}", PhongBan); 
            Console.WriteLine("Chuc vu: {0}", ChucVu); 
            Console.WriteLine("He so luong: {0}", HSL); 
            Console.WriteLine("Tham nien cong tac: {0}", ThamNien); 
            Console.WriteLine("So ngay lam : {0} ", SoNgayLam); 
            Console.WriteLine("Phu cap: {0}", PhuCap); 
            Console.WriteLine("He so thi dua: {0}", HeSoThiDua); 
            Console.WriteLine("Tong luong: {0}", Luong); 
            Console.WriteLine("***************************************");
        }
    }
    class DSNhanVien : NhanVien
    {
        List<NhanVien> listNV = new List<NhanVien>(); internal List<NhanVien> ListNV
        {
            get { return this.listNV; }
            set { listNV = value; }
        }
        public void DocFile(String file)
        {
            XmlDocument read = new XmlDocument(); 
            read.Load("DS.xml");
            XmlNodeList nodeList = read.SelectNodes("/DSNV/NhanVien"); 
            foreach (XmlNode node in nodeList)
            {
                NhanVien nhanvien = new NhanVien(); 
                nhanvien.MaNV = node["MaNV"].InnerText; 
                nhanvien.TenNV = node["TenNV"].InnerText; 
                nhanvien.PhongBan = node["PhongBan"].InnerText;

                nhanvien.ChucVu = node["ChucVu"].InnerText; 
                nhanvien.HSL = double.Parse(node["HSL"].InnerText);
                nhanvien.ThamNien = float.Parse(node["ThamNien"].InnerText); 
                nhanvien.SoNgayLam = int.Parse(node["SoNgayLam"].InnerText); 
                listNV.Add(nhanvien);
            }
        }
        public override void Nhap()
        {
            base.Nhap();
        }
        public override void Xuat()
        {
            base.Xuat();
        }
        public void xuat()
        {
            foreach (NhanVien nv in listNV) nv.Xuat();
        }
        public void Sapxepheso()
        {
            listNV = listNV.OrderByDescending(t => t.HeSoThiDua).ToList();
        }
        public void DSNVtheophong()
        {
            Console.Write("Nhap ten phong ban:"); 
            string tenphong = Console.ReadLine();
            listNV = listNV.Where(t => t.PhongBan == tenphong).ToList();
        }
        public void DSNVLanhdao()
        {
            listNV = listNV.Where(t => t.ChucVu == "Lanh dao").ToList();
        }
        public double TongLuong()
        {
            double tong = 0;
            foreach (NhanVien nv in listNV) tong = tong + nv.Luong;
            return tong;
        }
        public void DSNVsongaylonhon10()
        {
            listNV = listNV.Where(t => t.SoNgayLam >= 10).ToList();
        }
        public void DSNVsongaylonhon22()
        {
            listNV = listNV.Where(t => t.ChucVu != "Lanh dao" && t.SoNgayLam > 22).ToList();
        }
        public void DSNV_HSL_PTaivu()
        {
            listNV = listNV.Where(t => t.HSL >= 4.34 && t.PhongBan == "Tai vu").ToList();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            DSNhanVien ds = new DSNhanVien(); 
            ds.DocFile("DS.xml");
            Console.WriteLine("Danh sach nhan vien cong ty"); ds.xuat();
            Console.WriteLine("Danh sach nhan vien theo he so thi dua"); 
            ds.Sapxepheso();
            ds.xuat();
            //Console.WriteLine("Danh sach nhan vien o phong hanh chinh");
            //ds.DSNVtheophong();
            //ds.xuat();
            Console.WriteLine("Danh sach nhan vien co chuc vu lanh dao"); 
            ds.DSNVLanhdao();
            ds.xuat();
            Console.WriteLine("Loai bo nhung nhan vien co so ngay lam nho hon 10"); 
            ds.DSNVsongaylonhon10();
            ds.xuat();
            double tong = ds.TongLuong();
            Console.WriteLine("Tong luong phai tra cho nhan vien: {0} ", tong);
        }
    }
}
