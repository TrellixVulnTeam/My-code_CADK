using System;
namespace nuocGiaiKhat{
    class Nuoc{
        string tenHang;
        string donViTinh;
        int soLuong;
        float donGia;
        float thue;
        public string _tenHang{
            get{return tenHang;}
            set{tenHang = value;}
        }
        public string _donViTinh{
            get{
                if(donViTinh == "thung"){
                    return "thung";
                }else if (donViTinh == "chai"){
                    return "chai";
                }else if(donViTinh == "lon"){
                    return "lon";
                }else{
                    return "ket";
                }
            }
        }
        public int _soLuong{
            get{return soLuong;}
            set{if(value<0){
                Console.WriteLine("Nhap sai sl");
                soLuong = 0;
            }else{
                soLuong = value;
            }}
        }
        public float _donGia{
            get{return donGia;}
            set{if(value<0){
                Console.WriteLine("Nhap sai don gia");
                donGia = 0;
            }else{
                donGia = value;
            }}
        }
        public float _thue{
            get{return thue;}
            set{thue = value;}
        }
        public Nuoc(){
            tenHang = donViTinh = "";
            soLuong = 0;
            donGia = thue = 0f;
        }
        public Nuoc(string tenHang, string donViTinh, int soLuong, float donGia, float thue){
            this.tenHang = tenHang;
            this.donViTinh = donViTinh;
            this.soLuong = soLuong;
            this.donGia = donGia;
            this.thue = thue;
        }
        public Nuoc(Nuoc a){
            this.tenHang = a.tenHang;
            this.donViTinh = a.donViTinh;
            this.soLuong = a.soLuong;
            this.donGia = a.donGia;
            this.thue = a.thue;
        }
        ~Nuoc(){

        }
        public double thanhTien(){
            if(_donViTinh == "ket" || _donViTinh == "thung"){
                return _soLuong*_donGia*_thue;
            }else if(_donViTinh == "chai"){
                return _soLuong*(_donGia/20)*_thue;
            }else{
                return _soLuong*(_donGia/24)*_thue;
            }
        }
        public void nhap(){
            Console.Write("Nhap ten hang: ");
            tenHang = Console.ReadLine();
            Console.Write("Nhap don vi tinh (ket|chai|thung|lon): ");
            donViTinh = Console.ReadLine();
            Console.Write("Nhap so luong: ");
            soLuong = int.Parse(Console.ReadLine());
            Console.Write("Nhap don gia: ");
            donGia = float.Parse(Console.ReadLine());
            Console.Write("nhap thue: ");
            thue = float.Parse(Console.ReadLine());
        }
        public void xuat(){
            Console.WriteLine($"thong tin don hang:\n-Ten hang: {_tenHang}\n-Don vi tinh: {_donViTinh}\n-So luong: {_soLuong}\n-Don gia: {_donGia}\n-Thue: {_thue}");
        }
    }
    class Program{
        static void Main(string[] args){
            Console.Write("Nhap so luong don hang: ");
            int n = int.Parse(Console.ReadLine());
            Nuoc[] arrWater = new Nuoc[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap don hang thu "+(i+1).ToString());
                arrWater[i] = new Nuoc();
                arrWater[i].nhap();
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Xuat don hang thu "+(i+1).ToString());
                arrWater[i].xuat();
                Console.WriteLine($"Thanh tien: {arrWater[i].thanhTien()}");
            }


        }
    }
}