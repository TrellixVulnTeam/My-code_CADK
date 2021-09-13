using System;
using System.Text;
using System.Collections.Generic;

namespace Tinh_Diem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.UTF8;

            string option;
            List<MonLyThuyet> ListLT = new List<MonLyThuyet>();
            List<MonThucHanh> ListTH = new List<MonThucHanh>();
            List<MonDoAn> ListDA = new List<MonDoAn>();

            do
            {
                Console.WriteLine("Nhập điểm môn lý thuyết (Nhập: ilt)");
                Console.WriteLine("Nhập điểm môn thực hành (Nhập: ith)");
                Console.WriteLine("Nhập điểm môn đồ án (Nhập: ida)");
                Console.WriteLine("Hiển thị thông tin môn lý thuyết (Nhập: dlt)");
                Console.WriteLine("Hiển thị thông tin môn thực hành (Nhập: dth)");
                Console.WriteLine("Hiển thị thông tin môn đồ án (Nhập: dda)");
                Console.WriteLine("Thoát chương trình (Nhập: exit)");
                Console.Write("Lựa chọn của bạn: ");
                option = Console.ReadLine();

                switch (option)
                {
                    case "ilt":
                        MonLyThuyet lt = new MonLyThuyet();
                        lt.Input();
                        ListLT.Add(lt);
                        break;
                    case "ith":
                        MonThucHanh th = new MonThucHanh();
                        th.Input();
                        ListTH.Add(th);
                        break;
                    case "ida":
                        MonDoAn da = new MonDoAn();
                        da.Input();
                        ListDA.Add(da);
                        break;
                    case "dlt":
                        foreach (MonLyThuyet lth in ListLT)
                        {
                            lth.Display();
                            Console.WriteLine();
                        }
                        break;
                    case "dth":
                        foreach (MonThucHanh tha in ListTH)
                        {
                            tha.Display();
                            Console.WriteLine();
                        }
                        break;
                    case "dda":
                        foreach (MonDoAn dan in ListDA)
                        {
                            dan.Display();
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
