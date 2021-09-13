using System;

namespace DinhThuc_1
{
    class DinhThuc{
        private float s1,s2,s3,s4;
        public DinhThuc(){
            s1 = s2 = s3 = s4 = 0;
        }
        public DinhThuc(float s1, float s2, float s3, float s4){
            this.s1 = s1;
            this.s2 = s2;
            this.s3 = s3;
            this.s4 = s4;
        }
        public float S1{
            get { return s1;}
            set { s1 = value;}
        }
        public float S2{
            get { return s2;}
            set { s2 = value;}
        }
        public float S3{
            get { return s3;}
            set { s3 = value;}
        }
        public float S4{
            get { return s4;}
            set { s4 = value;}
        }
        public DinhThuc(DinhThuc Dt){
            this.s1 = Dt.s1;
            this.s2 = Dt.s2;
            this.s3 = Dt.s3;
            this.s4 = Dt.s4;
        }
        public DinhThuc cong2DinhThuc(DinhThuc Dt1, DinhThuc Dt2){
            DinhThuc tong = new DinhThuc();
            tong.S1 = Dt1.s1+Dt2.s1;
            tong.S2 = Dt1.s2+Dt2.s2;
            tong.S3 = Dt1.s3+Dt2.s3;
            tong.S4 = Dt1.s4+Dt2.s4;
            return tong;
        }
        public DinhThuc tru2DinhThuc(DinhThuc Dt1, DinhThuc Dt2){
            DinhThuc hieu = new DinhThuc();
            hieu.S1 = Dt1.s1-Dt2.s1;
            hieu.S2 = Dt1.s2-Dt2.s2;
            hieu.S3 = Dt1.s3-Dt2.s3;
            hieu.S4 = Dt1.s4-Dt2.s4;
            return hieu;
        }
        public DinhThuc nhan2DinhThuc(DinhThuc Dt1, DinhThuc Dt2){
            DinhThuc tich = new DinhThuc();
            tich.S1 = Dt1.s1*Dt2.s1;
            tich.S2 = Dt1.s2*Dt2.s2;
            tich.S3 = Dt1.s3*Dt2.s3;
            tich.S4 = Dt1.s4*Dt2.s4;
            return tich;
        }
        public static DinhThuc operator + (DinhThuc Dt1, DinhThuc Dt2){
            return new DinhThuc (Dt1.s1 + Dt2.s1, Dt1.s2 + Dt2.s2, Dt1.s3 + Dt2.s3, Dt1.s4 + Dt2.s4);
        }
        public static DinhThuc operator - (DinhThuc Dt1, DinhThuc Dt2){
            return new DinhThuc (Dt1.s1 - Dt2.s1, Dt1.s2 - Dt2.s2, Dt1.s3 - Dt2.s3, Dt1.s4 - Dt2.s4);
        }
        public static DinhThuc operator * (DinhThuc Dt1, DinhThuc Dt2){
            return new DinhThuc (Dt1.s1 * Dt2.s1, Dt1.s2 * Dt2.s2, Dt1.s3 * Dt2.s3, Dt1.s4 * Dt2.s4);
        }
        public void nhap(){
            Console.Write("enter s1: ");
            s1 = float.Parse(Console.ReadLine());
            Console.Write("enter s2: ");
            s2 = float.Parse(Console.ReadLine());
            Console.Write("enter s3: ");
            s3 = float.Parse(Console.ReadLine());
            Console.Write("enter s4: ");
            s4 = float.Parse(Console.ReadLine());
        }
        public void xuat(){
            Console.WriteLine($"{S1, -15}{S2, -15}{S3, -15}");
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            DinhThuc Dt1 = new DinhThuc();
            DinhThuc Dt2 = new DinhThuc();
            Dt1.nhap();
            Dt2.nhap();
            Console.Write("enter DT1: ");
            Dt1.xuat();
            Console.Write("enter DT2: ");
            Dt2.xuat();
            Console.WriteLine("Tong 2 dinh thuc: ");
            DinhThuc tong = Dt1 + Dt2;
            tong.xuat();
            Console.WriteLine("Hieu 2 dinh thuc: ");
            DinhThuc hieu = Dt1 + Dt2;
            hieu.xuat();
            Console.WriteLine("Nhan 2 dinh thuc: ");
            DinhThuc nhan = Dt1 + Dt2;
            nhan.xuat();
        }
    }
}
