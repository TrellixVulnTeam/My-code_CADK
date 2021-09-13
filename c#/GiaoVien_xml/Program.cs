using System;
using System.Collections.Generic;
using System.Xml;
using System.Linq;
namespace Xml
{
    class Program
    {
        public class GiaoVien
        {
            public string hoten;
            public int sonhom;
            public GiaoVien() { }
            public GiaoVien(string ht, int sn)
            {
                this.hoten = ht;
                this.sonhom = sn;
            }
            public void xuat()
            {
                Console.WriteLine("ho ten: {0}\t so nhom: {1}", hoten, sonhom);
            }
        }
        public class DSGV
        {
            List<GiaoVien> listGV = new List<GiaoVien>();

            public void docFile(string file)
            {
                XmlDocument read = new XmlDocument();
                read.Load(file);
                XmlNodeList nodelist = read.SelectNodes("DanhSach/GV");
                foreach (XmlNode node in nodelist)
                {
                    GiaoVien gv = new GiaoVien();
                    gv.hoten = node["hoten"].InnerText;
                    gv.sonhom = int.Parse(node["sonhom"].InnerText);
                    listGV.Add(gv);
                }
            }
            public int tongSonhom()
            {
                int tong = 0;
                foreach (GiaoVien gv in listGV)
                {
                    tong += gv.sonhom;
                }
                return tong;
            }
            public void sapXepten()
            {
                listGV = listGV.OrderBy(t => t.hoten).ToList();
            }
            public void sapXeptheonhom()
            {
                listGV = listGV.OrderByDescending(t => t.sonhom).ToList();
            }
            public List<GiaoVien> locsonhomlonhon1()
            {
                return listGV.Where(t => t.sonhom > 1).ToList();
            }
            public void xuat()
            {
                Console.WriteLine("danh sach gv: ");
                foreach (GiaoVien gv in listGV)
                    gv.xuat();
            }
        }
        static void Main(string[] args)
        {
            DSGV ds = new DSGV();
            ds.docFile("C:/Users/dat54/OneDrive/Desktop/Learning/c#/GiaoVien_xml/GV.xml");
            ds.xuat();
            Console.WriteLine("tong so nhom la : {0}", ds.tongSonhom());
            Console.WriteLine("sap xep giam dan ");
            ds.sapXeptheonhom();
            ds.xuat();
            List<GiaoVien> dsloc = ds.locsonhomlonhon1();
            Console.WriteLine("so giao vien cos so nhom hon 1 la ");
            foreach(GiaoVien gv in dsloc)
            {
                gv.xuat();
            }
            Console.ReadLine();

        }
    }
}
