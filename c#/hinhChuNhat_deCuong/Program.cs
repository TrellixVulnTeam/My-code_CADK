using System;

namespace hinhChuNhat_deCuong
{
    class HinhChuNhat
    {
        int chieuDai, chieuRong;
        public int _chieuDai
        {
            get { return chieuDai; }
            set
            {
                chieuDai = value;
                while (chieuDai < 0)
                {
                    Console.Write("Chieu dai phai > 0\nNhap lai chieu dai: ");
                    chieuDai = int.Parse(Console.ReadLine());
                }
            }
        }
        public int _chieuRong
        {
            get { return chieuRong; }
            set
            {
                chieuRong = value;
                while (chieuRong < 0)
                {
                    Console.Write("Chieu rong phai > 0\nNhap lai chieu rong: ");
                    chieuRong = int.Parse(Console.ReadLine());
                }
            }
        }
        public HinhChuNhat()
        {
            chieuDai = chieuRong = 0;
        }
        public HinhChuNhat(int chieuDai, int chieuRong)
        {
            this.chieuDai = chieuDai;
            this.chieuRong = chieuRong;
        }
        public HinhChuNhat(HinhChuNhat a)
        {
            this.chieuDai = a.chieuDai;
            this.chieuRong = a.chieuRong;
        }
        public double chuVi()
        {
            return (_chieuDai + _chieuRong) * 2;
        }
        public double dienTich()
        {
            return _chieuDai * _chieuRong;
        }
        public double duongCheo()
        {
            return Math.Sqrt(_chieuDai * _chieuDai + _chieuRong * _chieuRong);
        }
        public void changeSize(int tx, int ty, int kieu)
        {
            if (kieu == 1)
            {
                _chieuDai += tx;
                _chieuRong += ty;
            }
            else
            {
                _chieuDai -= tx;
                _chieuRong -= ty;
            }
        }
        public void changeSize(HinhChuNhat a, int kieu)
        {
            if (kieu == 1)
            {
                _chieuDai += a._chieuDai;
                _chieuRong += a._chieuRong;
            }
            else
            {
                _chieuDai -= a._chieuDai;
                _chieuRong -= a._chieuRong;
            }
        }
        public void input()
        {
            Console.Write("nhap chieu dai: ");
            _chieuDai = int.Parse(Console.ReadLine());
            Console.Write("nhap chieu rong: ");
            _chieuRong = int.Parse(Console.ReadLine());
        }
        public void output()
        {
            Console.WriteLine($"chieu dai= {_chieuDai}\nchieu rong= {_chieuRong}\nChu vi: {chuVi()}\nDien tich: {dienTich()}\nDuong cheo: {duongCheo():0.00}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            HinhChuNhat hcn = new HinhChuNhat();
            hcn.input();
            hcn.output();
            Console.WriteLine("============ change size ============");
            string n;
            int kieu, tx, ty, choose;
            Console.Write("1. Doi theo theo kich thuoc x,y: \n2. Doi theo kich thuoc HCN a: \nNhap lua chon: ");
            choose = int.Parse(Console.ReadLine());
            switch (choose)
            {
                case 1:
                    Console.WriteLine("Ban muon tang hay giam ?: ");
                    Console.Write("Nhap (tang|giam): ");
                    n = (Console.ReadLine());
                    while (n != "giam" && n != "tang")
                    {
                        Console.Write("Nhap (tang|giam): ");
                        n = (Console.ReadLine());
                    }
                    if (n == "tang")
                    {
                        kieu = 1;
                    }
                    else
                    {
                        kieu = 0;
                    }
                    Console.Write($"Nhap chieu dai muon {n}: ");
                    tx = int.Parse(Console.ReadLine());
                    Console.Write($"Nhap chieu rong muon {n}: ");
                    ty = int.Parse(Console.ReadLine());
                    Console.WriteLine("Kich thuoc sau khi doi: ");
                    hcn.changeSize(tx, ty, kieu);
                    hcn.output();
                    break;
                case 2:
                    Console.WriteLine("Ban muon tang hay giam ?: ");
                    Console.Write("Nhap (tang|giam): ");
                    n = (Console.ReadLine());
                    while (n != "giam" && n != "tang")
                    {
                        Console.Write("Nhap (tang|giam): ");
                        n = (Console.ReadLine());
                    }
                    if (n == "tang")
                    {
                        kieu = 1;
                    }
                    else
                    {
                        kieu = 0;
                    }
                    HinhChuNhat a = new HinhChuNhat();
                    a.input();
                    hcn.output();
                    break;
                default:
                    Console.WriteLine("Nhap sai!!");
                    break;
            }
        }
    }
}
