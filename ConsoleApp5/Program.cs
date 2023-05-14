using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            for (a=0; a<100; a++)
            {
                if (a % 3 == 0 && a % 5 == 0)
                {
                    Console.Write("FizzBuzz, ");
                }
                else if (a % 3 == 0)
                {
                    Console.Write("Fizz, ");
                }
                else if (a % 5 == 0)
                {
                    Console.Write("Buzz, ");
                }
                else
                {
                    Console.Write(a + ", ");
                }
            }
        }
    }
}
