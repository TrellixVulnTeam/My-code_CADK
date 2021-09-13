using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;

namespace DocfileXml
{
    class SinhVien
    {
        public String sBD; 
        public String hoTen; 
        public int namsinh; 
        public double diemToan; 
        public double diemVan; 
        public double diemNN; 
        public double tongdiem; 
        public bool ketqua; 
        public string SBD
        {
            get
            {
                return sBD;
            }
            set
            {
                sBD = value;
            }
        }
        public string Hoten
        {
            get
            {
                return hoTen;
            }
            set
            {
                hoTen = value;
            }
        }
        public int Namsinh
        {
            get
            {
                return namsinh;
            }
            set
            {
                namsinh = value;
            }
        }
        public double DiemToan
        {
            get
            {
                return diemToan;
            }
            set
            {
                diemToan = value;
            }
        }
        public double DiemVan
        {
            get
            {
                return diemVan;
            }
            set
            {
                diemVan = value;
            }
        }
        public double DiemNN
        {
            get
            {
                return diemNN;
            }
            set
            {
                diemNN = value;
            }
        }
        public double TongDiem
        {
            get
            {
                return tongdiem = diemToan + diemVan + diemNN * 2.0;
            }
        }
        public bool Ketqua
        {
            get
            {
                double DiemChuan = 25.0;
                if (tongdiem >= DiemChuan)
                {
                    ketqua = true;
                }
                else
                {
                    ketqua = false;
                }
                return ketqua;
            }
        }
        public void xuat()
        {
            Console.WriteLine("SBD: {0}, Ho Ten: {1}, Nam Sinh: {2}, Diem Toan: {3}, Diem Van: {4}, Diem Ngoai Ngu: {5}", SBD, Hoten, Namsinh, DiemToan, DiemVan, DiemNN);
            Console.Write("Tong Diem: {0}", TongDiem); 
            if (Ketqua == true)
            {

                Console.WriteLine(", Kết quả: Đậu");
            }
            else
            { Console.WriteLine(", kết quả: Rớt"); }
        }
        class DSSinhVien
        {
            List<SinhVien> lstGv = new List<SinhVien>(); 
            internal List<SinhVien> LstSv
            {
                get
                {
                    return lstGv;
                }
                set
                {
                    lstGv = value;
                }
            }
            public void docfile(String file)
            {
                XmlDocument read = new XmlDocument(); 
                read.Load(file);
                XmlNodeList nodelist = read.SelectNodes("DanhSach/ThiSinh"); 
                foreach (XmlNode node in nodelist)
                {
                    SinhVien sv = new SinhVien(); 
                    sv.hoTen = node["HT"].InnerText; 
                    sv.sBD = node["sbd"].InnerText;
                    sv.namsinh = int.Parse(node["NamSinh"].InnerText); 
                    sv.diemToan = double.Parse(node["Toan"].InnerText); 
                    sv.diemVan = double.Parse(node["Van"].InnerText); 
                    sv.diemNN = double.Parse(node["NN"].InnerText); 
                    lstGv.Add(sv);
                }
            }
            public void SapxepTen()
            {
                lstGv = lstGv.OrderBy(t => t.Hoten).ToList();
            }
            public void Sapxeptongdiem()
            {
                lstGv = lstGv.OrderByDescending(t => t.tongdiem).ToList();
            }
            public List<SinhVien> locketqua()
            {
                return lstGv.Where(t => t.ketqua = true).ToList();
            }
            public List<SinhVien> locnamsinh2001()
            {
                return lstGv.Where(t => t.namsinh > 2001 || t.diemToan >= 9).ToList();
            }
            public void Xuat()
            {
                Console.WriteLine("Danh Sach Sinh Vien: "); 
                foreach (SinhVien gv in lstGv)
                {
                    gv.xuat();
                }
            }
            static void Main()
            {
                DSSinhVien ds = new DSSinhVien(); 
                ds.docfile("C:/Users/dat54/OneDrive/Desktop/Learning/c#/sinhVien_DeCuong/ThiSinh.xml"); 
                ds.Xuat();
                Console.WriteLine("Danh sach Gv sap xep theo tong diem giam dan: "); 
                ds.Sapxeptongdiem();
                ds.Xuat();
                List<SinhVien> dsloc = ds.locnamsinh2001();
                Console.WriteLine("Danh sach SV co nam sinh lon hon 2001 hoac diem toan >=9 la: ");

                foreach (SinhVien gv in dsloc)
                {
                    gv.xuat();
                }
                Console.ReadLine();
            }
        }
    }
}
