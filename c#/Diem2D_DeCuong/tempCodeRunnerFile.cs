using System;

namespace Diem2D_DeCuong
{
    class Point2D
    {
        public int Ox, Oy;
        public int _Ox
        {
            get { return Ox; }
            set { Ox = value; }
        }
        public int _Oy
        {
            get { return Oy; }
            set { Oy = value; }
        }
        public Point2D(int ox, int oy)
        {
            this.Ox = ox;
            this.Oy = oy;
        }
        public Point2D()
        {
            Ox = Oy = 0;
        }
        public Point2D(Point2D a)
        {
            Ox = a.Ox;
            Oy = a.Oy;
        }
        ~Point2D()
        {

        }
        public void Nhap()
        {
            Console.Write("Nhap toa do ox: ");
            Ox = int.Parse(Console.ReadLine());
            Console.Write("Nhap toa do oy: ");
            Oy = int.Parse(Console.ReadLine());
        }
        public void Xuat()
        {
            Console.WriteLine($"Diem: {_Ox},{_Oy}");
        }
        public void KiemTra()
        {
            if (Ox == 0)
            {
                Console.WriteLine("Diem nam tren truc oy!");
            }
            else if (Oy == 0)
            {
                Console.WriteLine("Diem nam tren truc  Ox!");
            }
            else if (Ox == 0 && Oy == 0)
            {
                Console.WriteLine("diem vua nhap la goc toa do!");
            }
            else
            {
                Console.WriteLine("diem khong nam tren bat cu truc nao!");
            }
        }
        public double TinhKhoangCah()
        {
            double d = Math.Round(Math.Sqrt(Math.Pow(_Ox, 2) + Math.Pow(_Oy, 2)), 2); return d;
        }
        public double TinhKhoangCach(Point2D a)
        {
            double d = Math.Round(Math.Sqrt(Math.Pow(this._Ox - a._Ox, 2) + Math.Pow(this._Oy - a._Oy, 2)), 2); ;
            return d;
        }
        public void DiemDoiXung()
        {
            Console.WriteLine($"Diem doi xung qua truc ox la: {_Ox},{-_Oy}");
            Console.WriteLine($"Diem doi xung qua truc ox la: {-_Ox},{_Oy}");
        }
        public void SongSong(Point2D B)
        {
            if (Oy == B.Oy)
            {
                Console.WriteLine("Doan thang tao boi 2 diem song song voi Ox");
            }
            else if (Ox == B.Ox)
            {
                Console.WriteLine("Doan thang tao boi 2 diem song song voi oy");
            }
            else
            {
                Console.WriteLine("Doan thang tao boi 2 diem khong song song voi bat ki trung nao");
            }
        }
        public void quaGoc(Point2D C)
        {
            if (Ox == -C.Ox && Oy == -C.Oy)
            {
                Console.WriteLine("Doan thang di qua goc toa do Oxy!");
            }
            else
            {
                Console.WriteLine("Doan thang khong di qua doc toa do!");
            }

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Point2D A = new Point2D(2, 3); 
            Point2D a = new Point2D(); 
            A.Xuat();
            A.KiemTra(); A.DiemDoiXung();
            Console.WriteLine("Khoang cach tu O(0,0) toi A la:{0} ", A.TinhKhoangCach()); Console.WriteLine("Nhập điểm a:");
            a.Nhap();
            a.Xuat();
            Console.WriteLine("Khoang cach tu O(0,0) toi a la: {0}", a.TinhKhoangCach()); Console.WriteLine("Khoang cach tu A toi a la:{0} ", A.TinhKhoangCach(a)); A.SongSong(a);
            A.quaGoc(a); Console.ReadLine();

        }
    }
}
