//multiple parameters
using System;
namespace cSharp
{
    class method3
    {
        static void MyMethod(string fname, int age)
        {
            Console.WriteLine(fname + "is" + age);
        }
        static void Main(string[] args)
        {
            MyMethod("Romiya",16);
            MyMethod("Sama",20);
        }
    }
}