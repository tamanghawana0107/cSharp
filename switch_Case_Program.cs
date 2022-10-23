//C# - switch statement
using System;
namespace cSharp
{
    class switchCaseProgram
    {
        static void Main(string[] args)
        {
            int a,b,ch;
            int sum = 0, diff = 0, mul = 0, div =0;
            Console.WriteLine("Enter the first number: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            Console.WriteLine("1.Sum\n2.Difference\n3.Multiply\n4.Division");
            Console.WriteLine("Enter the choice:");
            ch = Convert.ToInt32(Console.ReadLine());
            switch(ch)
            {
                case 1:
                    sum = a+b;
                    Console.WriteLine("The sum value is :" + sum);
                    break;
                case 2:
                    diff = a-b;
                    Console.WriteLine("The difference value is :" + diff);
                    break;
                case 3:
                    mul = a*b;
                    Console.WriteLine("The multiplication value is :" + mul);
                    break;
                case 4:
                    div = a/b;
                    Console.WriteLine("The division value is :" + div);
                    break;
                default:
                    Console.WriteLine("You have entered invalid number!!!");
                    break;
            }
        }
    }
}