using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roman_to_integer
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }

        public static int RomanToInt(string s)
        {
            //We crate char array
            var chars = s.ToCharArray();

            int sum = 0;

            for(int i=0;i<chars.Length-1; i++)
            {
                //Checking like  "IV" conditions IV=4 so 5-1=4
                if (RomanNumbers(chars[i]) < RomanNumbers(chars[i + 1]))
                {
                    sum -= RomanNumbers(chars[i]);
                }

                //Normally addition like "III" III=3 so 1+1+1=3
                else
                {
                    sum += RomanNumbers(chars[i]);
                }
            }

            //before ignored last index and  now we can add sum;
            sum += RomanNumbers(chars[chars.Length - 1]);
            return sum;

        }

        public static int RomanNumbers(char c)
        {
            switch(c){
                case 'I': return 1;
                case 'V': return 5;
                case 'X': return 10;
                case 'L': return 50;
                case 'C': return 100;
                case 'D': return 500;
                case 'M': return 1000;
            };

            return 0;
        }
    }
}
