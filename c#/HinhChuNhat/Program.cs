using System;

namespace HinhChuNhat
{
    class HinhChuNhat
    {
        float chieuDai, chieuRong;
        double duongCheo;
        public float cd
        {
            get
            {
                return chieuDai;
            }
            set
            {
                if (value < 0)
                {
                    Console.Write("Ban da nhap sai");
                }
                else
                {
                    chieuDai = value;
                }
            }
        }
        public float cr
        {
            get
            {
                return chieuRong;
            }
            set
            {
                if (value < 0)
                {
                    Console.Write("Ban da nhap sai");
                }
                else
                {
                    chieuRong = value;
                }
            }
        }
        public double dc
        {
            get
            {
                return duongCheo;
            }
            set
            {
                duongCheo = Math.Sqrt(cd * cd + cr * cr);
            }
        }

        public void Nhap()
        {
            Console.Write("Nhap chie dai: ");
            chieuDai = float.Parse(Console.ReadLine());
            Console.Write("Nhap chieu rong: ");
            chieuRong = float.Parse(Console.ReadLine());
            duongCheo = Math.Sqrt(cd * cd + cr * cr);
        }
        public void xuat()
        {
            Console.WriteLine($"Duong chep hcn la: {duongCheo:0.00}");
        }
        static void Main(string[] args)
        {
            HinhChuNhat hcn = new HinhChuNhat();
            hcn.Nhap();
            hcn.xuat();
        }
    }
}
