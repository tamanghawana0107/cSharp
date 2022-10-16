//operator
using System;
namespace cSharp
{
    class arithmetic
    {
        static void Main(string[] args)
        {
            int x,y,result;
            x = 9;
            y = 3;
            //Using Arithmetic operators
            //Addition Operator
            result = x+y;
            Console.WriteLine("Add = "+ result);
            //Subtraction Operator
            result = x-y;
            Console.WriteLine("Subtract = "+ result);
            //Multiplication Operator
            result = x*y;
            Console.WriteLine("Multiplication = "+ result);
            //Division Operator
            result = x/y;
            Console.WriteLine("Division = "+ result);
            //Modulus Operator
            result = x%y;
            Console.WriteLine("Modulus = "+ result);
            //Increment Operator
            result = x++;
            Console.WriteLine("Increment = "+ result);
            result = y++;
            Console.WriteLine("Increment = "+ result);
            //Decrement Operator
            result = x--;
            Console.WriteLine("Decrement = "+ result);
            result = y--;
            Console.WriteLine("Decrement = "+ result);
            //end of program
        }
    }
}