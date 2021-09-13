using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace soPhuc2
{
    public class phanso{
        private int tuso1;
        private int mauso1;
        public phanso(int tuso1, int mauso1){
            this.tuso1 = tuso1;
            this.mauso1 = mauso1;
        }
        public phanso(int tuso2){
            this.tuso1 = tuso2;
            mauso1 = 1;
        }
        public static implicit operator phanso(int theInt){
            return new phanso(theInt);
        }
        public static explicit operator int(phanso thephanso){
            return thephanso.tuso1/thephanso.mauso1;
        }
        public static bool operator ==(phanso lhs, phanso rhs){
            if(lhs.tuso1 == rhs.tuso1 && lhs.mauso1 == rhs.mauso1){
                return true;
            }
            return false;
        }
        public static bool operator !=(phanso lhs, phanso rhs){
            Console.WriteLine("su dung toan tu != ");
            return !(lhs == rhs);
        }
        public override bool Equals(object obj)
        {
            Console.WriteLine("phuong thuc equals");
            if(!(obj is phanso)){
                return false;
            }
            return this == (phanso)obj;
        }
        public static phanso operator +(phanso lhs, phanso rhs){
            if(lhs.mauso1 == rhs.mauso1){
                Console.WriteLine("su dung toan tu + voi 2 phan so");
                return new phanso(lhs.tuso1+rhs.tuso1,lhs.mauso1);
            }
                Console.WriteLine("su dung toan tu + cho 1 phan so voi 1 so");
                int fist = lhs.tuso1*rhs.mauso1;
                int second = rhs.tuso1*rhs.mauso1;
                return new phanso(fist +second, lhs.mauso1*rhs.mauso1);
            }
        public override string ToString(){
            string s = tuso1.ToString()+"/"+mauso1.ToString();
            return s;
        }
public class tester{
    static void Main(){
        Console.WriteLine("Phan so thu nhat la: ");
        phanso ps1 = new phanso(2,4);
        Console.WriteLine($"ps1: {ps1.ToString()}");
        Console.WriteLine("phan so 2 la: ");
        phanso ps2 = new phanso(1,4);
        Console.WriteLine($"ps2: {ps2.ToString()}");
        phanso ps3 = ps1+ps2;
        Console.WriteLine("ps1+ps2=ps3");
        Console.WriteLine($"ps2: {ps2.ToString()}");
        // phanso ps3 = ps1 + ps2;
        Console.WriteLine("ps1+ps2=ps3");
        Console.WriteLine($"ps3: {ps3.ToString()}");
        phanso ps4 = ps3 + 5;
        Console.WriteLine($"ps4=ps3+5: {ps4.ToString()}");
        phanso ps5 = new phanso(2,4);
        Console.WriteLine("phanso(2,4");
        Console.WriteLine("so sanh ps1 va ps5");
        if(ps5 == ps1){
            Console.WriteLine($"ps5: {ps5.ToString()}==ps1: {ps1.ToString()}");
            Console.WriteLine("2 phan so nay bang nhau");
        }
        if(ps2 == ps3){
            Console.WriteLine($"ps2: {ps2.ToString()}==ps3: {ps3.ToString()}");
            Console.WriteLine("2 phan so nay bang nhau");
        }Console.WriteLine($"ps2: {ps2.ToString()}!=ps3: {ps3.ToString()}");
        Console.WriteLine("Hai phan so nay khong bang nhau");

            }
        }
    }
}
