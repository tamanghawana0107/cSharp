//string in C#
using System;
namespace cSharp
{
    class cSharp_strings
    {
        static void Main(string[] args)
        {
            //printing text length
            string name = "Hawana Tamang";
            Console.WriteLine(name);
            //printing text length
            Console.WriteLine("The Length of the name string is :" + name.Length);
            //alternative printing way
            string name2 = "Romiya Dangol";
            Console.WriteLine(name2.ToUpper());
            Console.WriteLine(name2.ToLower());
        }
    }
}