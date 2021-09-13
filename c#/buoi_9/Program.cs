using System;

namespace buoi_9
{
    class Program
    {
        public double banKinh {get; set;}
        public double chieuCao {get; set;}     
    }
    class banKinh : Program{
        private int banKinh{
            get{return banKinh;}
            set {banKinh = value;}
        }
        public void Eat(){
            Console.WriteLine(food);
        }
    }
    class Ga : animal{
        public string food;
        public Ga(){
            legs = 2;
            food = "Thoc";
            weigh = 1.5f;
        }
        public void Eat(){
            Console.WriteLine(food);
        }
    }
    static void Main(string[] args){
        Console.WriteLine("demo meo");
    }
}
