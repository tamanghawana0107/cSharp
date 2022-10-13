//Explicit Conversion
using System;
namespace cSharp
{
    class Explicit
    {
        static void Main(string[] args)
        {
            double myDouble = 13.0815;
            int myInt= (int) myDouble;      //Explicit conversion or Manual Casting

            Console.WriteLine(myDouble);
            Console.WriteLine(myInt);
        }
    }
}