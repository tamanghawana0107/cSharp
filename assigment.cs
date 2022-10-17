//assignment operator
using System;
namespace cSharp
{
    class assignment
    {
        static void Main(string[] args)
        {
            int x = 13;
            //using all assignment operator in the program
            Console.WriteLine("x="+x);
            Console.WriteLine("x="+(x+3));
            Console.WriteLine("x="+(x-3));
            Console.WriteLine("x="+(x*3));
            Console.WriteLine("x="+(x/3));
            Console.WriteLine("x="+(x%3));
            Console.WriteLine("x="+(x&3));
            Console.WriteLine("x="+(x|3));
            Console.WriteLine("x="+(x^3));
            Console.WriteLine("x="+(x>>3));
            Console.WriteLine("x="+(x<<3));
        }
    }
}