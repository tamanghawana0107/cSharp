// different methods in one program
using System;
namespace cSharp
{
    class typeConversion
    {
        static void Main(string [] args)
        {
            int myInt = 09;
            double myDouble = 13.0815;
            bool myBool = true;

            Console.WriteLine(Convert.ToString(myInt));   //convert int to string
            Console.WriteLine(Convert.ToDouble(myInt));   //convert int to double
            Console.WriteLine(Convert.ToInt32(myDouble)); //convert double to int
            Console.WriteLine(Convert.ToString(myBool)); //convert bool to string
        }
    }

}