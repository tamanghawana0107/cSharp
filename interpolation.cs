//C# interpolation
using System;
namespace cSharp
{
    class interpolation
    {
        static void Main(string[] args)
        {
            string firstName = "Romiya";
            string lastName = "Dangol";
            string name = $"Her full name is : {firstName} {lastName}";  //Here "$" is the keyword for the interpolation method
            Console.WriteLine(name);
        }
    }
}