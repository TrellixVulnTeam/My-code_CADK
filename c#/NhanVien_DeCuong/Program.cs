using System;

namespace NhanVien_DeCuong
{
    class NhanVien{
        string maNV, hoTen;
        int ngayCong;
        char xepLoai;
        public string mnv{
            get{return maNV;}
            set{maNV = value;}
        }
        public string HT{
            get{return hoTen;}
            set{hoTen = value;}
        }
        public int NC{
            get{return ngayCong;}
            set { if (value < 0) { Console.WriteLine("data error"); } else { ngayCong = value; } }
        }
        public char XL{
            get{
                if(ngayCong > 26){
                    return 'A';
                }else if(ngayCong >= 22){
                    return 'B';
                }else{
                    return 'C';
                }
            }
        }
        public static int LuongNgay = 200000;
        public NhanVien(){
            mnv = HT = "";
            NC = 0;
        }
        public NhanVien(string maNV, string hoTen, int ngayCong){
            this.maNV = maNV;
            this.hoTen = hoTen;
            this.ngayCong = ngayCong;
        }
        public NhanVien (NhanVien a){
            this.maNV = a.maNV;
            this.hoTen = a.hoTen;
            this.ngayCong = a.ngayCong;
        }
        ~NhanVien(){

        }
        public void nhap(){
            Console.Write("Nhap ma nhan vien: "); mnv = Console.ReadLine();
            Console.Write("Nhap ten nhan vien: "); hoTen = Console.ReadLine();
            Console.Write("Nhap so ngay cong: "); NC = int.Parse(Console.ReadLine());
        }
        public void xuat(){
            Console.WriteLine($"Thong tin nhan vien:\n-Ma nhan vien: {maNV}\n-Ten nhan vien: {hoTen}\n-So ngay cong: {ngayCong}");
        }
        public double tinhLuong(){
            return NC*LuongNgay;
        }
        public double tinhThuong(){
            if(XL == 'A'){
                return tinhLuong()*5/100;
            }else if(XL == 'B'){
                return tinhLuong()*2/100;
            }else{
                return 0;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Nhap so luong nhan vien: ");
            n = int.Parse(Console.ReadLine());
            NhanVien[] arrNV = new NhanVien[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap thong tin nhan vien thu "+(i+1).ToString());
                arrNV[i]= new NhanVien();
                arrNV[i].nhap();
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Xuat thong tin nhan vien thu "+(i+1).ToString());
                arrNV[i].xuat();
                Console.WriteLine($"Luong nhan vien: {arrNV[i].tinhLuong()}");
                Console.WriteLine($"Luong thuong: {arrNV[i].tinhThuong()}");
                Console.WriteLine($"Tong luong nhan: {arrNV[i].tinhLuong() + arrNV[i].tinhThuong()}");
            }
            
        }
    }
}
