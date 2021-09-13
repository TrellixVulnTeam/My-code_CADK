using System;
namespace tinhDienTich_DeCuong{
    class TinhDienTich{
        public string name, code;
        public double chiSoCu, chiSoMoi;
        int DM = 100;
        int DGTDM = 1500;
        public string _name{
            get{return name;}
            set{name = value;}
        }
        public string _code{
            get{return code;}
            set{code = value;}
        }
        public double _chiSoCu{
            get{return chiSoCu;}
            set{chiSoCu = value;}
        }
        public double _chiSoMoi{
            get{return chiSoMoi;}
            set{chiSoMoi = value;}
        }
        public double sDSD{
            get{return chiSoMoi - chiSoCu;}
        }
        public double TD{
            get{
                if(sDSD <= DM){
                    return sDSD * DGTDM;
                }
                else{
                    return sDSD * DGTDM *1.5;
                }
            }
        }
        public void Nhap(){
            Console.Write("Nhap ten chu ho: ");
            name = Console.ReadLine();
            Console.Write("Nhap id cong to dien: ");
            code = Console.ReadLine();
            Console.Write("Nhap chi so dien cu: ");
            chiSoCu = double.Parse(Console.ReadLine());
            Console.Write("Nhap chi so dien moi: ");
            chiSoMoi = double.Parse(Console.ReadLine());
        }
        public void Xuat(){
            Console.WriteLine("Thong tin tien dien");
            Console.WriteLine($"Ho ten chu ho: {name}\nMa so cong to: {code}\nChi so cu: {chiSoCu}\nChi so moi: {chiSoMoi}");
            Console.WriteLine($"So dien su dung: {sDSD}\nTong so tien dien: {TD}");
        }
    }
    class Program{
        static void Main(string[] args){
            TinhDienTich a = new TinhDienTich();
            a.Nhap();
            a.Xuat();
        }
    }
}