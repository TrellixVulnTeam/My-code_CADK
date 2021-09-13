using System;
using System.Collections.Generic;
using System.Text;

namespace NgocThinh_PhongTro
{
    abstract class PhongTro : IRoom
    {
        public string maSoPhong;
        public int soNguoi;
        public int soDien;
        public int SoNuoc;
        public virtual void Display()
        {
            Console.WriteLine("*****");
            Console.WriteLine("Mã số phòng: {0}", this.maSoPhong);
            Console.WriteLine("Số người: {0}", this.soNguoi);
            Console.WriteLine("Số điện: {0}", this.soDien);
            Console.WriteLine("Số nước: {0}", this.SoNuoc);
            Console.WriteLine("*****");
        }
        public virtual void Input()
        {
            Console.Write("Nhập mã số phòng: ");
            this.maSoPhong = Console.ReadLine();
            do
            {
                Console.Write("Nhập số người: ");
                this.soNguoi = Convert.ToInt32(Console.ReadLine());
            } while (this.soNguoi < 0);
            do
            {
                Console.Write("Nhập số điện: ");
                this.soDien = Convert.ToInt32(Console.ReadLine());
            } while (this.soDien < 0);
            do
            {
                Console.Write("Nhập số nước: ");
                this.SoNuoc = Convert.ToInt32(Console.ReadLine());
            } while (this.SoNuoc < 0);
        }
    }
}
