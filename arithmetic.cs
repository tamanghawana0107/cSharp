//operator
using System;
namespace cSharp
{
    class arithmetic
    {
        static void Main(string[] args)
        {
            int x,y;
            x = 9;
            y = 3;
            //Using Arithmetic operators
            //Addition Operator
            Console.WriteLine("Add =",x+y);
            //Subtraction Operator
            Console.WriteLine(x-y);
            //Multiplication Operator
            Console.WriteLine(x*y);
            //Division Operator
            Console.WriteLine(x/y);
            //Modulus Operator
            Console.WriteLine(x%y);
            //Increment Operator
            Console.WriteLine(x++);
            Console.WriteLine(y++);
            //Decrement Operator
            Console.WriteLine(x--);
            Console.WriteLine(y--);
            //end of program
        }
    }
}