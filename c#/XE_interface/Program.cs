using System;
namespace bt_lopTruuTuong
{
    class MyMotor
    {
        public string code;
        public string name;
        public int capacity;
        public string type;

        public virtual void Display()
        {
            Console.WriteLine("**************");
            Console.WriteLine($"code: ", this.code);
            Console.WriteLine($"code: ", this.name);
            Console.WriteLine($"code: ", this.capacity);
            Console.WriteLine($"code: ", this.type);
            Console.WriteLine("**************");
        }

        public virtual void InPut()
        {
            do
            {
                Console.Write("Nhap code toi thieu 4 ky tu: ");
                this.code = Console.ReadLine();
            } while (this.code.Trim().Length < 4);
            do
            {
                Console.Write("Nhap name toi thieu 6 ky tu: ");
                this.name = Console.ReadLine();
            } while (this.name.Trim().Length < 6);
            do
            {
                Console.Write("Nhap capacity >= 50: ");
                this.capacity = Convert.ToInt32(Console.ReadLine());
            } while (this.capacity < 50);
            do
            {

                Console.Write("Nhap loai xe(tay ga hoac so) :");
                this.type = Console.ReadLine();
            } while (!this.type.Equals("tay ga") && !this.type.Equals("so"));

        }
    }
}