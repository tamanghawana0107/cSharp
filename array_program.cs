//array in C#
using System;
namespace cSharp
{
    class array_program
    {
        static void Main(string[] args)
        {
            string[] name, address;
            name = new string [] {"Hawana","Romiya","Srijana","Sama"};
            address = new string [] {"Gathaghar", "Manamaiju","Lubhu"};
            Console.WriteLine(name[1]);
            Console.WriteLine(address[1]);
            Console.WriteLine(name.Length);
            Console.WriteLine(address.Length);
        }
    }
}