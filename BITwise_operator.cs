//BITwise Operator
using System;
namespace cSharp
{
    class BITwise_operator
    {
        static void Main(string [] args)
        {
            int x = 9,y = 13, result;
            //using all the BITwise Operator
            result = x & y;
            Console.WriteLine("Bitwise AND : " + result);
            result = x | y;
            Console.WriteLine("Bitwise OR : " + result);
            result = x ^ y;
            Console.WriteLine("Bitwise XOR : " + result);
            result = ~x;
            Console.WriteLine("Bitwise Complement : " + result);
            result = x << 2;
            Console.WriteLine("Bitwise Left Shift : " + result);
            result = x >> 2;
            Console.WriteLine("Bitwise Right Shift : " + result);
        }
    }
}