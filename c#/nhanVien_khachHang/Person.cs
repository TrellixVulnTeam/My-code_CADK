using System;

namespace TH1B9
{
    class Person
    {
        string id, name, gender, birthday;

        protected void Accept(string id)
        {
            this.id = id;
            Console.Write("Enter name: ");
            this.name = Console.ReadLine();
            Console.Write("Enter gender: ");
            this.gender = Console.ReadLine();
            Console.Write("Enter birthday dd/mm/yy: ");
            this.birthday = Console.ReadLine();
        }

        protected void Display()
        {
            Console.WriteLine($"ID: ", id);
            Console.WriteLine($"Name: ", name);
            Console.WriteLine($"gender: ", gender);
            Console.WriteLine($"Birthday: ", birthday);
        }
    }
}