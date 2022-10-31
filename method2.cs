//method parameter
using System;
namespace cSharp
{
    class method2
    {
        static void MyMethod(string fname)
        {
            Console.WriteLine(fname + "Dangol");
        }
        static void Main(string[] args)
        {
            string name;
            name = "Romiya";
            MyMethod(name);
        }
    }
}