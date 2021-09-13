using System;

namespace tamGiac
{
    class TamGiac
    {
        float AB, BC ,AC;
        double p,s,h,nuaP;
        public float canhAB{
            get{
                return AB;
            }
            set{
                AB = value;
            }
        }
        public float canhBC{
            get{
                return BC;
            }
            set{
                BC = value;
            }
        }
        public float canhAC{
            get{
                return AC;
            }
            set{
                if(value < 0){
                    Console.WriteLine("Nhap sai");
                }
            }
        }
        public double cv{
            get{
                return p;
            }
            set{
                p = AB + BC+ AC;
            }
        }
        public double dt{
            get{
                return s;
            }
            set{
                s = (BC*AC)/2;
            }
        }
        public double nuaTamGiac{
            get{
                return nuaP;
            }
            set{
                nuaP = (AB+BC+AC)/2;
            }
        }
        public double cc{
            get{
                return h;
            }
            set{
                h = 2* (Math.Sqrt(nuaP*(nuaP-AB)*(nuaP - AC)*(nuaP-BC))/nuaP);
            }
        }
        public void Nhap(){
            Console.Write("Nhap canh AB: ");
            AB = float.Parse(Console.ReadLine());
            Console.Write("Nhap canh BC: ");
            BC = float.Parse(Console.ReadLine());
            Console.Write("Nhap canh AC: ");
            AC = float.Parse(Console.ReadLine());
            nuaP = (AB + BC + AC) / 2;
            p = (AB + AC + BC);
            h = 2 * (Math.Sqrt(nuaP * (nuaP - AB)*(nuaP - AC)*(nuaP - BC))/BC);
            s = (BC*AC)/2;
        }
        public void xuat(){
            Console.WriteLine($"Chu vi tam giac la: {p:0.00}");
            Console.WriteLine($"Nua chu vi tam giac la: {nuaP:0.00}");
            Console.WriteLine($"Dien tich tam giac la: {s:0.00}");
        }

        static void Main(string[] args)
        {
            TamGiac tg= new TamGiac();
            tg.Nhap();
            tg.xuat();
        }
    }
}
