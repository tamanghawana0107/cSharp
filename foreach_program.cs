//foreach loop in C#
using System;
namespace cSharp
{
    class foreach_program
    {
        static void Main(string[] args)
        {
            string[] cars = {"volvo" , "BMW", "Thar", "Tesla"};
            foreach(string i in cars)
            {
                Console.WriteLine(i);
            }
         }
    }
}