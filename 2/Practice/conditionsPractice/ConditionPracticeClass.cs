using System;
using System.Diagnostics.Eventing.Reader;
using System.Linq;

namespace conditionsPractice
{
    public class ConditionPracticeClass
    {
        /*TODO: The method must receive one parameter of the int type as input - a number to check.
        The method must return a boolean value, depending on whether the input parameter is even or odd*/
        public static bool IsEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            return false;
        }


        /* TODO: Receives a string as input and returns true if the string contains only unique characters, false otherwise. */
        public static bool HasUniqueCharacters(string input)
        {
            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] == input[i + 1])
                {
                    return false;
                }
            }
            return true;
        }


        /* TODO: Receives an integer as input and returns true if the number is divisible by both 5 and 7, excluding zero, false otherwise. */
        public static bool IsDivisibleBy5And7(int number)
        {
            if (number % 5 == 0 && number % 7 == 0 && number != 0)
            {
                return true;
            }
            return false;


        }

        /* TODO: Performs the specified arithmetic operation (char input paramether) on two double input paramethers and returns the result. */
        public static double PerformOperation(char operation, double number1, double number2)
        {
            string _operation = operation.ToString();
            if (_operation == "add")
                return number1 + number2;
            else if (_operation == "substract")
                return number1 - number2;
            else if (_operation == "devide")
                return number1 / number2;
            else if (_operation == "multiply")
                return number1 * number2;
            else return 000000;
        }


        /* TODO: Receives an integer as input and returns "Positive" if the number is positive, "Negative" if the number is negative, "Zero" if the number is zero. */
        public static string CheckNumber(int number)
        {
            if (number > 0)
               {
                return "Positive";
            }
            else if (number < 0)
            {
                return "Negative";
            }
            else
            {
                return "Zero";
            }
    }


        /* TODO: Receives a string as input and returns true if the string is a palindrome, false otherwise. */
        public static bool IsPalindrome(string input)
        {
            string input1 = input;
            string input2 = (string)input.Reverse(); 
            if (input == input.Reverse
            {
                return true;
            }
            return false;
        }

        /* TODO: Receives a int year as input paramether and returns true if the year is a leap year, false otherwise. */
        public static bool IsLeapYear(int year)
        {
            throw new NotImplementedException();
        }


        /* TODO: Receives a character as input and returns true if the character is a vowel, false otherwise. */
        public static bool IsVowel(char character)
        {
            throw new NotImplementedException();
        }

        /* TODO: Converts a binary number represented as a string to its integer equivalent. */
        public static int BinaryToDecimal(string binaryNumber)
        {
            throw new NotImplementedException();
        }

        /* TODO: Converts a binary number represented as a string to its hexadecimal string equivalent. */
        public static string BinaryToHexadecimal(string binaryNumber)
        {
            throw new NotImplementedException();
        }
    }
}
