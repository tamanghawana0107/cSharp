//user input for string only
using System;
namespace cSharp
{
    class userInput1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the username:");
            string userName = Console.ReadLine();
            Console.WriteLine("Username is: " + userName);
        }
    }
}