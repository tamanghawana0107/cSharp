//typecasting in C#
//Implicit Conversion
using System;
namespace cSharp
{
    class Implicit
    {
        static void Main( string [] args)
        {
            int myInt = 13;
            double myDouble;
            myDouble = myInt;  // automatic casting
            Console.WriteLine(myInt);
            Console.WriteLine(myDouble);
        }
    }
}