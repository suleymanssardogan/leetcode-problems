using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maximum_69_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 9969;
            int b = Maximum69Number(a);
            Console.WriteLine(b);   
        }

        public static int Maximum69Number(int num)
        {
            //Acces to number We can create char array
            char[] digits = num.ToString().ToCharArray();
            
            //Already 9999 is the biggest
            if (num == 9999)
            {
                return num;
            }

            
            else
            {
                for(int i = 0; i < digits.Length; i++)
                {

                    //The first 6 has to convert to 9
                    if(digits[i] == '6')
                    {
                        digits[i] = '9';
                        break;
                    }
                }
            }
            // convert int
            return int.Parse(new string(digits));
        }
    }
}
