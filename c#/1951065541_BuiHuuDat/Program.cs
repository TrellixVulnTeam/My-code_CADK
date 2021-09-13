using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Xml;
using System.IO;

//Bui Huu Dat 1951065541
// k61th1
namespace _1951065541_BuiHuuDat
{
    public class SinhVien
    {
        public String soBaoDanh;
        public String tenThiSinh;
        public int namSinh;
        public double diemToan;
        public double diemVan;
        public double diemNN;
        public double tongDiem;
        public bool ketQua;

        public string _soBaoDanh
        {
            get { return soBaoDanh; }
            set { soBaoDanh = value; }
        }
        public string _tenThiSinh
        {
            get { return tenThiSinh; }
            set { tenThiSinh = value; }
        }
        public int _namSinh
        {
            get { return namSinh; }
            set { namSinh = value; }
        }
        public double _diemToan
        {
            get { return diemToan; }
            set { diemToan = value; }
        }
        public double _diemVan
        {
            get { return diemVan; }
            set { diemVan = value; }
        }
        public double _diemNN
        {
            get { return diemNN; }
            set { diemNN = value; }
        }
        public SinhVien()
        {
            soBaoDanh = "";
            tenThiSinh = "";
            namSinh = 0;
            diemToan = 0;
            diemVan = 0;
            diemNN = 0;
        }
        public SinhVien(string SoBaoDanh, string TenThiSinh, int NamSinh, double DiemToan, double DiemVan, double DiemNN)
        {
            this.soBaoDanh = SoBaoDanh;
            this.tenThiSinh = TenThiSinh;
            this.namSinh = NamSinh;
            this.diemToan = DiemToan;
            this._diemVan = DiemVan;
            this.diemNN = DiemNN;
        }
        public double _tongDiem
        {
            get
            {
                return tongDiem - diemToan + diemVan + diemNN * 2.0;
            }
        }
        public bool _ketQua
        {
            get
            {
                double DiemChuan = 25.0;
                if (tongDiem >= DiemChuan)
                {
                    ketQua = true;
                }
                else
                {
                    ketQua = false;
                }
                return ketQua;
            }
        }
        public void Nhap()
        {
            Console.WriteLine(" -Nhap So bao danh: ");
            _soBaoDanh = (Console.ReadLine());
            Console.WriteLine(" -Nhap ho ten sinh vien: ");
            _tenThiSinh = Console.ReadLine();
            Console.WriteLine(" -Nhap Nam Sinh: ");
            _namSinh = int.Parse(Console.ReadLine());
            Console.WriteLine(" -Nhập Điểm Văn: ");
            diemToan = double.Parse(Console.ReadLine());
            Console.WriteLine(" -Nhap diem toan: ");
            diemVan = double.Parse(Console.ReadLine());
            Console.WriteLine(" -Nhap diem tieng anh: ");
            diemNN = double.Parse(Console.ReadLine());
        }
        public void xuat()
        {
            Console.WriteLine($"So bao danh: {_soBaoDanh}\nHo ten: {_tenThiSinh}\nNam sinh: {_namSinh}\nDiem toan: {_diemToan}\nDiem van: {_diemVan}\nDiem NN: {_diemNN}");
            Console.WriteLine($"Tong diem: {_tongDiem}");
            if (_ketQua == true)
            {
                Console.WriteLine("Ket qua: Dau");
            }
            else
            {
                Console.WriteLine("Ket qua: rot");
            }
        }
    }
    public class DSSinhVien
    {
        List<SinhVien> lstSv = new List<SinhVien>();
        internal List<SinhVien> LstSv
        {
            get
            {
                return lstSv;
            }
            set
            {
                lstSv = value;
            }
        }
        public void docfile(String file)
        {
            XmlDocument read = new XmlDocument();
            read.Load(file);
            XmlNodeList nodeList = read.SelectNodes("/DanhSach/ThiSinh");
            foreach (XmlNode node in nodeList)
            {
                SinhVien sv = new SinhVien();
                sv._tenThiSinh = node["HT"].InnerText;
                sv._soBaoDanh = (node["SBD"].InnerText);
                sv._namSinh = int.Parse(node["NamSinh"].InnerText);
                sv._diemToan = double.Parse(node["Toan"].InnerText);
                sv._diemVan = double.Parse(node["Van"].InnerText);
                sv._diemNN = double.Parse(node["NN"].InnerText);
                lstSv.Add(sv);
            }
        }
        public void Sapxeptongdiem()
        {
            lstSv = lstSv.OrderByDescending(t => t._tongDiem).ToList();
        }
        public void SapxepTen()
        {
            lstSv = lstSv.OrderBy(t => t._tenThiSinh).ToList();
        }
        public List<SinhVien> locketqua()
        {
            return lstSv.Where(t => t.ketQua = true).ToList();
        }
        public List<SinhVien> locnamsinh1995()
        {
            return lstSv.Where(t => t.namSinh > 1995 || t.diemToan >= 9).ToList();
        }

        public void nhap()
        {
            Console.WriteLine("Nhap danh sach sinh vien: ");
            foreach (SinhVien sv in lstSv)
            {
                sv.Nhap();
            }
        }
        public void xuat()
        {
            Console.WriteLine("Danh sach sinh vien: ");
            foreach (SinhVien sv in lstSv)
            {
                sv.xuat();
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            DSSinhVien ds = new DSSinhVien();
            ds.docfile("C:/Users/dat54/OneDrive/Desktop/SinhVien.xml");
            ds.nhap();
            ds.xuat();
            
            Console.WriteLine("Danh sach Gv sap xep theo tong diem giam dan: ");
            ds.Sapxeptongdiem();
            ds.xuat();
            List<SinhVien> dsloc = ds.locnamsinh1995();
            Console.WriteLine("Danh sach sinh vien co nam sinh lon hon 1995 hoac diem toam >= 9");
            foreach (SinhVien sv in dsloc)
            {
                sv.xuat();
            }

        }
    }
}

