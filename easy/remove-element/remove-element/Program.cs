using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace remove_element
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }

        public static int RemoveElement(int[] nums, int val)
        {
            //counter what is not val in the array
            int counter = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    //in-place 
                    nums[counter] = nums[i];
                    //add counter
                    counter++;

                }

            }

            return counter;
        }
    }
}
