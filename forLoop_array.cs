//for loop in array
using System;
using System.Linq;
namespace cSharp{
    class forLoop_array
    {
        static void Main(string[] args)
        {
            string[] name= new string[3];
            int i =0;
            for(i=0;i<3;i++)
            {
                Console.WriteLine("Enter the name of " + (i+1) + " student ::");
                name[i] = Console.ReadLine();
            }
            Console.WriteLine("The output is below :");
            for(i = 0; i<3;i++)
            {
                Console.WriteLine(name[i]);
            }
        }
    }
}