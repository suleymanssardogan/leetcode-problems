using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace majority_element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Test Case
            int[] a = { 3, 2, 3 };
            Console.WriteLine("Majority Element: " + MajorityElement(a));
        }

        public static int MajorityElement(int[] nums)
        {
            //Create dictionary
            Dictionary<int, int> counts = new Dictionary<int, int>();

            //Travel on the array
            foreach(int num in nums)
            {
                //same element add one every tome
                if (counts.ContainsKey(num))
                {
                    counts[num]++;
                }
                //different element always 1
                else
                {
                    counts[num] = 1;
                }

                //Majority Element Rule
                if (counts[num] > nums.Length / 2)
                {
                    return num;
                }
            }
            // does not exist majority element
            return -1;
        }
    }
}
