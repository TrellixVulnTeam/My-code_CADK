using System;
using System.Collections.Generic;
using System.Text;

namespace NgocThinh_PhongTro
{
    class PhongA : PhongTro, IPay
    {
        public int soNguoiThan;
        public override void Input()
        {
            base.Input();
            do
            {
                Console.Write("Nhập số lần người thân thăm và ở lại qua đêm: ");
                this.soNguoiThan = Convert.ToInt32(Console.ReadLine());
            } while (this.soNguoiThan < 0);
            Console.WriteLine("Đã nhập xong!");
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine("Số lần người thân thăm: {0}", this.soNguoiThan);
            Console.WriteLine($"Tiền phòng: {Pay()}");
            Console.WriteLine("*****");
        }
        public double Pay() => 1400 + 2 * this.soDien + 8 * SoNuoc + 50 * this.soNguoiThan;

    }
}
