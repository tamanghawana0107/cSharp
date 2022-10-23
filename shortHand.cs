//short - hand if....else statement
//ternary operator
using System;
namespace cSharp
{
    class shortHand
    {
        static void Main(string[] args)
        {
            int time = 20;
            string result = (time < 18) ? "Good Day." : "Good evening.";
            Console.WriteLine(result); 
        }
    }
}