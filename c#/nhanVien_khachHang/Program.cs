using System;
using System.Diagnostics;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace TH1B9
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            List<Employee> empLst = new List<Employee>();
            List<Customer> cusLst = new List<Customer>();
            int cusId = 0, empId = 0;
            string choose;
            do
            {
                Console.WriteLine("******************************");
                Console.WriteLine("Hay nhap yeu cau");
                Console.WriteLine("Them nhan vien (nhap ae): ");
                Console.WriteLine("Them khach hang (nhap ac): ");
                Console.WriteLine("Hien thong tin nhan vien (nhap dae): ");
                Console.WriteLine("Hien thong tin khach hang (nhap dac): ");
                Console.WriteLine("Thong ke khach hang (nhap cs): ");
                Console.WriteLine("Thoat truong trinh (nhap ez): ");
                Console.WriteLine("******************************");

                choose = Console.ReadLine();

                switch (choose)
                {
                    case "ae":
                        Customer customer = new Customer();
                        cusId++;
                        customer.Accept("c" + cusId);
                        cusLst.Add(customer);
                        break;
                    case "ac":
                        Employee employee = new Employee();
                        empId++;
                        employee.Accept("e" + empId);
                        empLst.Add(employee);
                        break;
                    case "dae":
                        foreach (Employee emp in empLst)
                        {
                            emp.Display();
                        }
                        break;
                    case "dac":
                        foreach (Customer cus in cusLst)
                        {
                            cus.Display();
                        }
                        break;
                    case "cs":
                        int vipCnt = 0, newCnt = 0, normalCnt = 0;
                        foreach (Customer cus in cusLst)
                        {
                            switch (cus.type)
                            {
                                case "vip":
                                    vipCnt++;
                                    break;
                                case "new":
                                    newCnt++;
                                    break;
                                case "normal":
                                    normalCnt++;
                                    break;
                            }
                        }
                        Console.WriteLine("tong khach hang vip: {0}", vipCnt);
                        Console.WriteLine("tong khach hang new: {0}", newCnt);
                        Console.WriteLine("tong khach hang normal: {0}", normalCnt);
                        break;
                    default:
                        Console.WriteLine("Nhap sai roi babe");
                        break;
                }
            } while (!choose.Equals("ez"));

        }
    }
}