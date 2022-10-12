//displaying variables 
using System;
namespace cSharp
{
    class displayVariables
    {
        static void Main(string[] args)
        {
            string name ="Riti";
            Console.WriteLine(name +" Shrestha");
            //for string
            string firstname = "Riti ";
            string lastname = "Shrestha";
            string fullname = firstname+lastname;
            Console.WriteLine(fullname);
            //for numerical
            Console.Write("Met in Grade ");
            int x = 5;
            int y = 3;
            Console.Write(x+y);
        }
    }
    
}