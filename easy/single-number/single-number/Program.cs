using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace single_number
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] array = { 1, 2, 3, 3, 2 };
            Console.WriteLine($"Single Number is:{SingleNumber(array)} ");
        }

        public static int SingleNumber(int[] nums)
        {
            int result = 0;
            //Travel every number
            foreach (var n in nums)
            {
                //Bitwise XOR
                // 1,2,1,2,3
                // (1^1)^(2^2)^3
                // 0 ^ 0 ^ 3
                // 3
                result = result ^ n;
            }
            return result;
        }
    }
}
