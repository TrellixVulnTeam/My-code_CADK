using System;
using System.Security;
using System.Xml;
using System.Linq;
using System.Collections.Generic;
using System.CodeDom;

namespace btTrenLop2
{
    class Program
    {
        public class thiSinh
        {
            public int SBD;
            public string HT;
            public int NamSinh;
            public int Toan;
            public int Van;
            public int NN;
            public thiSinh() { }
            public thiSinh(int sbd, string ht, int ns, int dT, int dV, int dNN)
            {
                this.SBD = sbd;
                this.HT = ht;
                this.NamSinh = ns;
                this.Toan = dT;
                this.Van = dV;
                this.NN = dNN;
            }
            public void xuat()
            {
                Console.WriteLine($"SBD: {SBD}\t Ho ten: {HT}\t nam sinh: {NamSinh}\t diem toan: {Toan}\t diem van: {Van}\t diem anh:{NN}\t");
            }
        }
        public class DSSV
        {
            List<thiSinh> listTS = new List<thiSinh>();
            public void docFile(string file)
            {
                XmlDocument read = new XmlDocument();
                read.Load(file);
                XmlNodeList nodelist = read.SelectNodes("DSSV/ThiSinh");
                foreach (XmlNode node in nodelist)
                {
                    thiSinh ts = new thiSinh();
                    ts.SBD = int.Parse(node["SBD"].InnerText);
                    ts.HT = node["HT"].InnerText;
                    ts.NamSinh = int.Parse(node["NamSinh"].InnerText);
                    ts.Toan = int.Parse(node["Toan"].InnerText);
                    ts.Van = int.Parse(node["Van"].InnerText);
                    ts.NN = int.Parse(node["NN"].InnerText);
                    listTS.Add(ts);
                }
            }

            public void tongDiem()
            {
                int tong = 0;

                foreach (thiSinh ts in listTS)
                {
                    tong = ts.Toan + ts.Van + ts.NN;
                    Console.WriteLine(tong);
                }

            }

            public void sapXepTenTang()
            {
                listTS = listTS.OrderBy(t => t.HT).ToList();
            }
            public List<thiSinh> yearOrPoint()
            {
                return listTS.Where(t => t.NamSinh > 1995).Where(t => t.Toan >= 9).ToList();
            }
            public void xuat()
            {
                Console.WriteLine("danh sach gv: ");
                foreach (thiSinh ts in listTS)
                    ts.xuat();
            }
        }
        static void Main(string[] args)
        {
            DSSV ds = new DSSV();
            ds.docFile("SV.xml");
            Console.WriteLine("Moi ban chon: ");
            Console.WriteLine("1. Sap xep thep tong diem giam dan: ");
            Console.WriteLine("2. Sap xep tang dan theo ten: ");
            Console.WriteLine("3. Danh sach thi sinh co ket qua dau: ");
            Console.WriteLine("4. ds sinh vien co nam sinh >1995 or dToan >= 9: ");
            Console.Write("Moi ban chon: ");
            int n = int.Parse(Console.ReadLine());

            switch (n)
            {
                case 1:

                    ds.tongDiem();

                    break;
                case 2:
                    Console.WriteLine("Sap xep tang dan theo ten: ");
                    ds.sapXepTenTang();
                    ds.xuat();
                    break;
                case 3:

                    break;
                case 4:
                    Console.WriteLine("ds sinh vien co nam sinh >1995 or dToan >= 9: ");
                    List<thiSinh> dsloc = ds.yearOrPoint();
                    foreach (thiSinh ts in dsloc)
                    {
                        ts.xuat();
                    }
                    break;
            }
        }
    }
}
