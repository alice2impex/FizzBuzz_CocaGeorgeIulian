using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            String buzz = "Buzz";
            String fizz = "Fizz";
            for (i = 1; i < 101; i++)
            {
                if (i % 15 == 0)
                {
                    Console.WriteLine(fizz + buzz);
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine(fizz);
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine(buzz);
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey(true);
        }
    }
}
