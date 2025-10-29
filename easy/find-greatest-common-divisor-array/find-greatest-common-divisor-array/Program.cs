using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace find_greatest_common_divisor_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 3, 5, 6, 9, 15 };
            Console.WriteLine("Brute Force: "+GratestDivisor(nums));
            Console.WriteLine("Brute Froce T(n) = O(n), Space Complexity= O(1)");
            Console.WriteLine("Euclidian: "+FindDivisor(nums));
            Console.WriteLine("Euclidean  T(n)= O(log n)  Space Complexity= O(1)");
        }


        //Brute Force Approching
        public static int GratestDivisor(int[] nums)
        {
            int max = nums.Max();
            int min = nums.Min();

            int divisor = 0;
            if (max == min)
            {
                return max;
            }

            //We check one by one
            for (int i = 1; i <= min; i++)
            {
                if (max % i == 0 && min % i == 0)
                {
                    divisor = i;
                }
            }
            return divisor;
        }



        //Euclidian 
        public static int FindDivisor(int[] nums)
        {

            int max = nums.Max();
            int min = nums.Min();

            return GCD(min, max);
            
        }

        public static int GCD(int a, int b)
        {
            while(b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }

            return a;
        }
    }

}
