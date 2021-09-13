using System;
using System.Collections.Specialized;

namespace TH1B9
{
    class Employee : Person
    {
        string qualification;
        public new void Accept(string id)
        {
            base.Accept(id);
            Console.Write("Nhap bang cap (trung cap, cao dang, dai hoc, sau dai hoc): ");
            this.qualification = Console.ReadLine();
            Console.WriteLine("Done!");
        }
        public new void Display()
        {
            Console.WriteLine();
            base.Display();
            Console.WriteLine($"bang cap{qualification}");
        }
    }
}