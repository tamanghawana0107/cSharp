//sorting in C#
using System;
namespace cSharp
{
    class sorting_program
    {
        static void Main(string[] args)
        {
            string[] cars = {"volvo", "BMW", "Ford", "Mazda"};
            Array.Sort(cars);
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }
            //sorting in array
            int[] myNum = {5,6,3,2,8};
            Array.Sort(myNum);
            foreach (int i in myNum)
            {
                Console.WriteLine(i);
            }
        }
    }
}