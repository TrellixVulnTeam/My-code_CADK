using System;
using System.Text;
using System.Collections.Generic;
namespace NgocThinh_PhongTro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.UTF8;

            string option;
            List<PhongA> ListRA = new List<PhongA>();
            List<PhongB> ListRB = new List<PhongB>();

            do
            {
                Console.WriteLine("Nhập thông tin phòng loại A (Nhập: ira)");
                Console.WriteLine("Nhập thông tin phòng loại B (Nhập: irb)");
                Console.WriteLine("Hiển thị thông tin phòng loại A (Nhập: dra)");
                Console.WriteLine("Hiển thị thông tin phòng loại B (Nhập: drb)");
                Console.WriteLine("Thoát chương trình (Nhập: exit)");
                Console.Write("Lựa chọn của bạn: ");
                option = Console.ReadLine();

                switch (option)
                {
                    case "ira":
                        PhongA ra = new PhongA();
                        ra.Input();
                        ListRA.Add(ra);
                        break;
                    case "irb":
                        PhongB rb = new PhongB();
                        rb.Input();
                        ListRB.Add(rb);
                        break;
                    case "dra":
                        foreach (PhongA la in ListRA)
                        {
                            la.Display();
                            Console.WriteLine();
                        }
                        break;
                    case "drb":
                        foreach (PhongB lb in ListRB)
                        {
                            lb.Display();
                            Console.WriteLine();
                        }
                        break;
                    default:
                        if (!option.Equals("exit"))
                            Console.WriteLine("Không có tính năng này!!");
                        break;
                }
            } while (!option.Equals("exit"));
        }
    }
}
