//Relational Operator
using System;
namespace cSharp
{
    class Relational_operator
    {
        static void Main(string[] args)
        {
            bool result;
            int x=9, y=13;
            //using all the relational operator
            result = (x == y);
            Console.WriteLine("Equal to operator:" + result);
            result = (x > y);
            Console.WriteLine("Greater than Operator:" + result);
            result = (x < y);
            Console.WriteLine("Less than Operator:" + result);
            result = (x >= y);
            Console.WriteLine("Greater than or Equals to:" + result);
            result = (x <= y);
            Console.WriteLine("Lesser than or Equal to:" + result);
            result = (x != y);
            Console.WriteLine("Not Equal to Operator:" + result);
        }
    }
}