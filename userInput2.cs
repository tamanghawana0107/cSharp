//user input
using System;
namespace cSharp
{
    class userInput2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is :" + age);
        }
    }
}