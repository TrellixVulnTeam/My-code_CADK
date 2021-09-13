using System;
using System.Security.Cryptography.X509Certificates;

namespace vanDongVien_deCuong
{
    class Program
    {
        class VanDongVien{
            DateTime aDateTime = DateTime.Now;
            string maSo, hoTen, BatDau, KetThuc;
            int soAo;
            DateTime tgBatDau, tgKetThuc;
            TimeSpan thoiGianTieuChuan = new TimeSpan(1,30,30);
            public string _maSo{
                get{return maSo;}
                set{maSo = value;}
            } 
            public string _hoTen{
                get{return hoTen;}
                set{hoTen = value;}
            } 
            public int _soAo{
                get{return soAo;}
                set{soAo = value;}
            } 
            public DateTime _tgBatDau{
                get{return tgBatDau;}
                set{tgBatDau = value;}
            }
            public DateTime _tgKetThuc{
                get{return tgKetThuc;}
                set{tgKetThuc = value;}
            }
            public VanDongVien(){
                maSo = hoTen = "";
                soAo = 0;
                tgBatDau = tgKetThuc = DateTime.MinValue;
            }
            ~VanDongVien(){

            }
            public VanDongVien(string maSo, string hoTen, int soAo,DateTime tgBatDau, DateTime tgKetThuc){
                this.maSo = maSo;
                this.hoTen = hoTen;
                this.soAo = soAo;
                this.tgBatDau = tgBatDau;
                this.tgKetThuc = tgKetThuc;
            }
            public bool kiemtra{
                get{
                    if ((tgBatDau.Hour >= 0 && tgBatDau.Hour <= 23) && (tgKetThuc.Hour >= 0 && tgKetThuc.Hour <= 23)
                    && (tgBatDau.Minute >= 0 && tgBatDau.Minute <= 59) && (tgKetThuc.Minute >= 0 && tgKetThuc.Minute <= 59)
                    && (tgBatDau.Second >= 0 && tgBatDau.Second <= 59) && (tgKetThuc.Second >= 0 && tgKetThuc.Second <= 59))
                    return true;
                return false;
                }
            }
            public TimeSpan ThanhTich{
                get {return tgKetThuc - tgBatDau;}
            }
            public string thanhtich{
                get{return ThanhTich.Hours + " Gio " + ThanhTich.Minutes + " Phut " + ThanhTich.Seconds + "Giay";}
            }
            public void nhap(){
                Console.Write("Nhap ma so: ");
                maSo = Console.ReadLine();
                Console.Write("Nhap ho ten: ");
                hoTen = Console.ReadLine();
                Console.Write("Nhap so ao: ");
                soAo = int.Parse(Console.ReadLine());
                do
                {
                    Console.Write("Nhap thoi gian bat dau (co dang HH:mm:ss): ");
                    _tgBatDau = DateTime.ParseExact(Console.ReadLine(), "HH:mm:ss", null);
                } while (kiemtra==false);          
                BatDau = tgBatDau.ToString("HH:mm:ss");
                do
                {
                    Console.Write("Nhap thoi gian ket thuc (co dang HH:mm:ss): ");
                    _tgKetThuc = DateTime.ParseExact(Console.ReadLine(), "HH:mm:ss", null);
                } while (kiemtra==false);       
                KetThuc = tgKetThuc.ToString("HH:mm:ss");
            }
            public void Xuat()
        {
            Console.WriteLine("*********************");
            Console.WriteLine("***Thong tin van dong vien***");
            Console.WriteLine($"Ma so : {_maSo}");
            Console.WriteLine($"Ho ten : {_hoTen}");
            Console.WriteLine($"So ao : {_soAo} ");
            Console.WriteLine($"Thoi gian bat dau : {tgBatDau}");
            Console.WriteLine($"Thoi gian ket thuc: {tgKetThuc}");
            Console.WriteLine($"Thanh tich: {thanhtich}");
        }

        }
        static void Main(string[] args)
        {
            VanDongVien a = new VanDongVien();
            a.nhap();
            a.Xuat();
        }
    }
}
