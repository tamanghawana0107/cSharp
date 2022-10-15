//WAP to take personal details from a student and display them
using System;
namespace cSharp
{
    class personalDetails
    {
        static void Main(string[] args)
        {
            string stu_name, stu_faculty;
            int stu_age, stu_semester,stu_id;
            //asking user input
            Console.WriteLine("Enter your student id:");
            stu_id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your name:");
            stu_name = Console.ReadLine();
            Console.WriteLine("Enter your age:");
            stu_age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your Faculty:");
            stu_faculty = Console.ReadLine();
            Console.WriteLine("Enter your Semester:");
            stu_semester = Convert.ToInt32(Console.ReadLine());
            //Displaying the output
            Console.WriteLine("Student Id is: " + stu_id);
            Console.WriteLine("Student Name is: " + stu_name);
            Console.WriteLine("Student Age is: " + stu_age);
            Console.WriteLine("Student Faculty is: "+ stu_faculty);
            Console.WriteLine("Student Semester is: " + stu_semester);
        }
    }
}