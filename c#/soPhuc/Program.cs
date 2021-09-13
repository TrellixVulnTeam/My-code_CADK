using System;
using System.Security.Cryptography.X509Certificates;

namespace soPhuc
{
    class SoPhuc{
        float a;
        public float A{
            get{return a;}
            set{a = value;}
        }
        float b;
        public float B{
            get{return b;}
            set{b = value;}
        }
        public SoPhuc(){
            a = b = 1;
        }
        public SoPhuc(float a, float b){
            this.a = a; this.b = b;
        }
        public SoPhuc(SoPhuc z){
            this.a = z.a;
            this.b = z.b;
        }
        public void nhapSP(){
            Console.Write("Nhap phan thuc: ");
            a = float.Parse(Console.ReadLine());
            Console.Write("Nhap phan ao: ");
            b = float.Parse(Console.ReadLine());
        }
        public void xuatSP(){
            Console.WriteLine($"z = {a:0.00}+{b:0.00}i");
        }
        public SoPhuc cong2SP(SoPhuc x, SoPhuc y){
            SoPhuc tong = new SoPhuc();
            tong.A = x.a + y.a;
            tong.B = x.b + y.b;
            return tong;
        }
        public bool soSanhBang(SoPhuc x, SoPhuc y){
            return (x.a == y.a && x.b == y.b);
        }
        public static SoPhuc operator +(SoPhuc x, SoPhuc y){
            return new SoPhuc (x.a + y.a, x.b + y.b);
        }
        // public static bool operator==(SoPhuc x, SoPhuc y){
        //     return (x.a == y.a && x.b == y.b);
        // }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SoPhuc x = new SoPhuc(2.3f, 4.0f);
            SoPhuc y = new SoPhuc(2.5f, 8.8f);
            x.xuatSP(); y.xuatSP();

            SoPhuc t = x.cong2SP(x,y);
            Console.WriteLine("Tong 2 so phuc (dung ham bt): ");
            t.xuatSP();
            Console.WriteLine("Tong 2 so phuc (dung operator): ");
            SoPhuc t1 = x + y;
            t1.xuatSP();

            // Console.WriteLine($"Ket qua so sanh 2 so phuc: cach 1 {x.soSanhBang} - cach 2: {x==y}");
            
        }
    }
}
