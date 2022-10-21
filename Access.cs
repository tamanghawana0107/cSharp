//Access of characters in string
using System;
namespace cSharp
{
    class Access
    {
        static void Main(string[] args)
        {
            string college = "Kist College";
            Console.WriteLine(college[0]);  //character
            int charPos = college.IndexOf("C");
            Console.WriteLine(charPos);  //position of character
            string lastName = college.Substring(charPos);
            Console.WriteLine(lastName);

            //Special Character
            string word  = "We are so called \"Vikings\" from the north .";
            Console.WriteLine(word);
        }
    }
}