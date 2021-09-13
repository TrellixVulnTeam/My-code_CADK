using System;
using System.Collections.Generic;
using System.Text;

namespace NgocThinh_PhongTro
{
    class PhongB : PhongTro, IPay
    {
        public double giatui;
        public double somay;
        public override void Input()
        {
            base.Input();
            do
            {
                Console.Write("Nhập số khối lượng giặt ủi: ");
                this.giatui = Convert.ToDouble(Console.ReadLine());
            } while (this.giatui < 0);
            do
            {
                Console.Write("Nhập số máy sử dụng internet: ");
                this.somay = Convert.ToDouble(Console.ReadLine());
            } while (this.giatui < 0);
            Console.WriteLine("Đã nhập xong!");
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Số khối lượng giặt ủi: {this.giatui}");
            Console.WriteLine($"Số máy sử dụng internet: {this.somay}");
            Console.WriteLine($"Tiền phòng: {Pay()}");
            Console.WriteLine("*****");
        }
        public double Pay() => 2000 + 2 * this.soDien + 8 * SoNuoc + 5 * this.giatui;
    }
}
