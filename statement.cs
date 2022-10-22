//if...else statement
using System;
namespace cSharp
{
    class statement
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());
            if(age<=12)
            {
                Console.WriteLine("You are bachha!");
            }
            else if (age >12 && age <20)
            {
                Console.WriteLine("You are a teenager!");
            }
            else
            {
                Console.WriteLine("You are an adult!");
            }
        }
    }
}