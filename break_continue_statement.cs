//using break and continue 
using System;
namespace cSharp
{
    class break_continue_statement
    {
        static void Main(string[] args)
        {
            for(int i =0; i<10; i++)
            {
                if(i==5)
                {
                    break;
                }
                Console.WriteLine("For Break statement");
                Console.WriteLine(i);
            }
            for(int i = 0; i<10;i++)
            {
                if(i==9)
                {
                    continue;
                }
                Console.WriteLine("For Continue statement!");
                Console.WriteLine(i);
            }
        }
    }
}