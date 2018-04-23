using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputStr = "Race car";
            Stripper test = new Stripper();
            String outputStr = test.StripNonAlphaNumeric(inputStr.Replace(" ",""));
            Console.WriteLine(outputStr);
            Pal pMoney = new Pal();
            pMoney.printer(outputStr);
            Console.Read();
        }
    }

    public class Stripper
    {
        public string StripNonAlphaNumeric(string inputStr)
        {
            Regex rgx = new Regex("[^a-zA-Z0-9 -]");
            inputStr = rgx.Replace(inputStr, "");
            return inputStr;
        }
    }

    public class Pal
    {
        public string palString;

        public bool checkPalindrome(String inputStr)
        {
            string notCaseSensitive = inputStr.ToLower();
            char[] charArray = notCaseSensitive.ToCharArray();
            Array.Reverse(charArray);
            string reversedString = new String(charArray);
            palString = reversedString;
            return (notCaseSensitive == reversedString);

        }

        public void printer(String inputStr)
        {
            if (this.checkPalindrome(inputStr))
            {
                Console.WriteLine("This is a Palindrome,\n");
            }
            else
            {
                Console.WriteLine("This is not a Palindrome.\n");
            }
        }
    }
}
