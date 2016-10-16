using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class KataFizzBuzz
    {
        public string FizzBuzz(int number)
        {
            string output = "";

            if (number <1 || number >100)
            {
                return output;
            }

            if ((number % 3 == 0) || number.ToString().Contains("3"))
            {
                output += "Fizz";
            }
            if ((number % 5 == 0) || number.ToString().Contains("5"))
            {
                output += "Buzz";
            }

            if (output == "")
            {
                return number.ToString();
            }
            return output;
        }
    }
}
