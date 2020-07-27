using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.ProductionCode
{
    public class FizzBuzzGame
    {
        public string Algoritm(int nr)
        {
                if (nr % 15 == 0)
                {
                return "FizzBuzz";
                }
                else if (nr % 3 == 0)
                {
                return "Fizz";
                }
                else if (nr % 5 == 0)
                {
                return "Buzz";
                }
            return nr.ToString();
        }
    }
}
