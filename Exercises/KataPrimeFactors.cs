using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class KataPrimeFactors
    {
        public static int[] Factorize(int input)
        {
            List<int> output = new List<int>();
            int dividedNumber = 0;

            if (input % 2 == 0 && input > 2)
            {
                dividedNumber = input / 2;
                output.Add(2);
                if (dividedNumber > 2)
                {
                    output.AddRange(Factorize(dividedNumber));
                }
                else
                {
                    output.Add(dividedNumber);
                }
                return output.ToArray();
            }
            else if (input% 3 == 0 && input > 3)
            {
                dividedNumber = input / 3;
                output.Add(3);
                if (dividedNumber > 3)
                {
                    output.AddRange(Factorize(dividedNumber));
                }
                else
                {
                    output.Add(dividedNumber);
                }
                return output.ToArray();
            }
            else if (input % 5 == 0 && input > 5)
            {
                dividedNumber = input / 5;
                output.Add(5);
                if (dividedNumber > 5)
                {
                    output.AddRange(Factorize(dividedNumber));
                }
                else
                {
                    output.Add(dividedNumber);
                }
                return output.ToArray();
            }
            else if (input % 7 == 0 && input > 7)
            {
                dividedNumber = input / 7;
                output.Add(7);
                if (dividedNumber > 7)
                {
                    output.AddRange(Factorize(dividedNumber));
                }
                else
                {
                    output.Add(dividedNumber);
                }
                return output.ToArray();
            }

            output.Add(input);
            return output.ToArray();
        }
    }
}
