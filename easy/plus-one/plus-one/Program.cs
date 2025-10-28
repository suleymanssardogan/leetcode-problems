using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace plus_one
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Test cases
            int[] nums = { 1, 2, 9 };

            int[] b = PlusOne(nums);

            for (int i = 0; i<b.Length; i++) 
            {
                Console.WriteLine(b[i]);
            }
        }


        public static int[] PlusOne(int[] digits)
        {

            int length = digits.Length; 

            for(int i = length - 1; i >= 0; i--)
            {
                //travel array from end to begin
                if(digits[i] < 9)
                {
                    digits[i]++;
                    return digits;
                }
                digits[i]=0;
            }

            //if all digtis are 9 There is carry , create new array
            int[] result = new int[length + 1];
            //Put 1 the start ,remaining part of array already 0
            result[0] = 1;
            return result;
 
        }
    }
}
