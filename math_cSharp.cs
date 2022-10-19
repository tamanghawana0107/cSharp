//C#-Math
using System;
namespace cSharp
{
    class math_cSharp
    {
        static void Main(string[] args)
        {
            int x,y,z;
            x = 09;
            y = 13;
            z = -7;
            Console.WriteLine("Highest Number :" +(Math.Max(x,y)));
            Console.WriteLine("Smallest Number :" +(Math.Min(x,y)));
            Console.WriteLine("Square root :" +(Math.Sqrt(x)));
            Console.WriteLine("Absolute Value :" +(Math.Abs(z)));
            Console.WriteLine("Round of Value : " +(Math.Round(0.9999)));
        }
    }
}