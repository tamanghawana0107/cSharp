//Logical Operator
using System;
namespace cSharp
{
    class Logical_operator
    {
        static void Main(string[] args)
        {
            bool a = true , b = false, result;
            //using all the logical operator

            //AND operator
            result = a && b;
            Console.WriteLine("AND operator: " + result);

            //OR operator
            result = a || b;
            Console.WriteLine("OR operator: " + result);

            //NOT operator
            result = !a;
            Console.WriteLine("NOT operator:" + result);
        }
    }
}