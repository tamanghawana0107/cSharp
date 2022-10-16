//unary operator
namespace cSharp
{
    class unaryy
    {
        static void Main(string[] args)
        {
            int a = 10, result = 0;
            result = a++;
            Console.WriteLine("a is {0} and result is {1}", a, result);
            result = a--; 
            Console.WriteLine("a is {0} and result is {1}", a, result);
            result = ++a;
            Console.WriteLine("a is {0} and result is {1}",a , result);
            result = --a;
            Console.WriteLine("a is {0} and result is {1}",a , result);
        }
    }
}