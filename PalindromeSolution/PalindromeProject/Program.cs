using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("type in a string:");
            string testString = Console.ReadLine();
            Console.WriteLine(($"\"{testString}\" ") + (CheckPalindrome(testString) ? "is" : "is not" ) + " a palindrome");
        }

        public static string StripString(string myString)
        {
            StringBuilder builder = new StringBuilder(myString.ToLower());

            int i = 0;
            while (i < builder.Length)
            {
                if (!(Char.IsDigit(builder[i]) || Char.IsLetter(builder[i])))
                {
                    builder.Remove(i, 1);
                }
                else
                {
                    i++;
                }
            }

            return builder.ToString();
        }

        public static bool CheckPalindrome(string myString)
        {
            string testString = StripString(myString);
            bool result = true;

            for(int i = 0; i < testString.Length/2; i++)
            {
                if(testString[i] != testString[testString.Length-i-1])
                {
                    result = false;
                    break;
                }
            }

            return result;
        }
    }
}
