using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace two_sum
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] array = { 1, 2, 3, 4, 5, 6 };
            int target = 6;
            Console.WriteLine("First Solution: ");
            Console.WriteLine(string.Join(", ", TwoSum(array, target)));


            int[] array2 = { 7, 11, 4 ,8, 2, 1 };
            int target2 = 18;
            Console.WriteLine("Second Solution (which is better):");
            Console.WriteLine(string.Join(",",TwoSum2(array2, target2)));
            Console.ReadLine();


        }


        //This solution is O(n^2) 
        public static  int[] TwoSum(int[] nums, int target)
        {

            int length = nums.Length;


            for (int i = 0; i < length; i++)
            {
                //I start i+1 because we don't want to  check same index
                for (int j = i + 1; j < length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        //We found pairs
                        return new int[] { i, j };
                    }
                }
            }
            //if there is no solution return 
            return new int[0];
        }

        //This solution is O(n) which we more wanted
        public static int[] TwoSum2(int[]nums,int target)
        {
            HashSet<int> seen = new HashSet<int>();

            for(int i=0;i<nums.Length; i++)
            {

                int complement = target - nums[i];

                //Find index have added values with search
                for (int j = 0; j < i; j++)
                {
                    if (nums[j] == complement)
                    {
                        return new int[] { i, j };
                    }
                }
                //Add to hashset current number
                seen.Add(nums[i]);
            }

            //Return empty
            return new int[0];
        }
    }
}
