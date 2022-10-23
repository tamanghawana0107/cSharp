//using of different loops
using System;
namespace cSharp
{
    class loop_program
    {
        static void Main(string[] args)
        {
            int i = 0;
            //using while loop
             while(i<5)
            {
                Console.WriteLine(i);
                i++;
            }
            //using do....while loop
            do 
            {
                Console.WriteLine(i);
                i++;
            }while(i == 10);
        }
    }    
}