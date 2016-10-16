using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class KataRomanNumerals
    {
        public static string NumberToRomanNumerals(int inputNumber)
        {
            if (inputNumber <= 500)
            {
                return NToRUpTo500(inputNumber);
            }
            else if (inputNumber < 900)
            {
                return "D" + NumberToRomanNumerals(inputNumber - 500);
            }
            else if (inputNumber < 1000)
            {
                return "CM" + NumberToRomanNumerals(inputNumber - 900);
            }
            return "M" + NumberToRomanNumerals(inputNumber - 1000);
        }

        private static string NToRLessThan5(int inputNumber)
        {
            string output = "";
            if (inputNumber <= 3)
            {
                for (int i = 0; i < inputNumber; i++)
                {
                    output += "I";
                }
                return output;
            }
            return "IV";
        }

        private static string NToRLessThan9(int inputNumber)
        {
            if (inputNumber < 5)
            {
                return NToRLessThan5(inputNumber);
            }
            return "V" + NToRLessThan5(inputNumber - 5);
        }

        private static string NToRLessThan19(int inputNumber)
        {
            if (inputNumber < 9)
            {
                return NToRLessThan9(inputNumber);
            }
            else if (inputNumber == 9)
            {
                return "IX";
            }
            return "X" + NToRLessThan9(inputNumber - 10);
        }

        private static string NToRLessThan40(int inputNumber)
        {
            string output = "";
            for (int i = inputNumber; i > 19; i -= 10)
            {
                output += "X";
                inputNumber -= 10;
            }

            if (inputNumber == 19)
            {
                return output + "XIX";
            }
            else if (inputNumber < 19)
            {
                return output + NToRLessThan19(inputNumber);
            }

            return output + NToRLessThan19(inputNumber - 20);
        }

        private static string NToRUpTo100(int inputNumber)
        {
            if (inputNumber < 40)
            {
                return NToRLessThan40(inputNumber);
            }
            else if (inputNumber < 50)
            {
                return "XL" + NToRLessThan19(inputNumber - 40);
            }
            else if (inputNumber > 90)
            {
                return "XC" + NToRLessThan9(inputNumber - 90);
            }
            return "L" + NToRLessThan40(inputNumber - 50);
        }

        private static string NToRUpTo500(int inputNumber)
        {
            if (inputNumber < 90)
            {
                return NToRUpTo100(inputNumber);
            }
            else if (inputNumber < 100)
            {
                return "XC" + NToRLessThan19(inputNumber - 90);
            }
            else if (inputNumber > 400)
            {
                return "CD" + NToRUpTo100(inputNumber - 400);
            }
            return "C" + NumberToRomanNumerals(inputNumber - 100);
        }
      

        public static int RomanNumeralsToNumbers(string input)
        {
            int total = 0;

            if (input == "CM")
            {
                return 900;
            }
            else if (input == "M")
            {
                return 1000;
            }
            else if (input.Length > 2 && input.Substring(0,2) == "CM")
            {
                total += 900;
                input = input.Substring(2);
                return total + RToNLessThan400(input);
            }
            else if (input.Length > 1 && input.Substring(0,1) == "M")
            {
                total += 1000;
                input = input.Substring(1);
                return total + RomanNumeralsToNumbers(input);
            }

            return RToNLessThan900(input);
        }

        private static int RToNLessThan5(string input)
        {
            int total = 0;

            if (input == "IV")
            {
                return 4;
            }

            foreach (char nextChar in input)
            {
                total++;
            }

            return total;
        }

        private static int RToNLessThan9(string input)
        {
            int total = 0;

            if (input == "V")
            {
                return 5;
            }
            else if (input.Substring(0, 1) == "V")
            {
                input = input.Substring(1);
                total += 5;
            }
            return total + RToNLessThan5(input);
        }

        private static int RToNLessThan40(string input)
        {
            int total = 0;

            if (input == "IX")
            {
                return 9;
            }
            else if (input == "X")
            {
                return 10;
            }
            else if (input.Substring(0, 1) == "X")
            {
                input = input.Substring(1);
                total += 10;
                return total + RToNLessThan40(input);
            }
            return total + RToNLessThan9(input);
        }

        private static int RToNLessThan90(string input)
        {
            int total = 0;

            if (input == "XL")
            {
                return 40;
            }
            else if (input == "L")
            {
                return 50;
            }
            else if (input.Length > 1 && input.Substring(0, 2) == "XL")
            {
                input = input.Substring(2);
                total += 40;
                return total + RToNLessThan40(input);
            }
            else if (input.Substring(0, 1) == "L")
            {
                total += 50;
                input = input.Substring(1);
                return total + RToNLessThan40(input);
            }

            return RToNLessThan40(input);
        }

        private static int RToNLessThan400(string input)
        {
            int total = 0;

            if (input == "C")
            {
                return 100;
            }
            else if (input.Substring(0, 1) == "C")
            {
                total += 100;
                input = input.Substring(1);
                return total + RomanNumeralsToNumbers(input);
            }
            else if (input.Length > 2 && input.Substring(0, 2) == "XC")
            {
                input = input.Substring(2);
                total += 90;
                return total + RToNLessThan40(input);
            }
            else if (input == "XC")
            {
                return 90;
            }
            return RToNLessThan90(input);
        }

        private static int RToNLessThan900(string input)
        {
            int total = 0;

            if (input == "CD")
            {
                return 400;
            }
            else if (input.Length > 2 && input.Substring(0, 2) == "CD")
            {
                total += 400;
                input = input.Substring(2);
                return total + RToNLessThan400(input);
            }
            else if (input == "D")
            {
                return 500;
            }
            else if (input.Length > 1 && input.Substring(0, 1) == "D")
            {
                total += 500;
                input = input.Substring(1);
                return total + RToNLessThan400(input);
            }

            return RToNLessThan400(input);
        }
    }
}
