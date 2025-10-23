using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polindrome_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Test Cases
            Console.WriteLine("121: "+IsPolindrome(121));
            Console.WriteLine("155: "+IsPolindrome(155));
            Console.WriteLine("0: "+ IsPolindrome(0));
            Console.WriteLine("-4" + IsPolindrome(-4));
        }

        public static bool IsPolindrome(int x)
        {
            //Reverse number
            int reverse = 0;

            int original = x;

            //Negative number is not polindrome
            if (x < 0)
            {
                return false;
            }
            else
            {
                while (x != 0)
                {
                    //Ex: Our number is "161"
                    //Mod 10 --> 161%10 = 1(digit);
                    // 1 = 0*10 +1 (reverse number's first digit)
                    // 161 --> 161/10 = 16;
                    int digit = x % 10;
                    reverse = reverse*10+digit;
                    x = x / 10;
                }
            }

            //if reverse number and original number are same it is polindrome number
            return reverse==original;
           
        }
    }
}
