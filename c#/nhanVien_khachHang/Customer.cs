using System;

namespace TH1B9
{
    class Customer : Person
    {
        public string type;
        public new void Accept(string id)
        {
            base.Accept(id);
            Console.Write("Nhap loai khach hang (vip, new, normal): ");
            this.type = Console.ReadLine();
            Console.WriteLine("Done!");
        }

        public new void Display()
        {
            base.Display();
            Console.WriteLine($"Loai khach hang: ", this.type);
        }
    }
}