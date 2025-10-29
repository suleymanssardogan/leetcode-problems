using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace find_highest_altitude
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Test Case
            int[] gain = { -5, 1, 5, 0, -7 };
            Console.WriteLine("Result :" + LargestAltitude(gain));

        }

        public static int LargestAltitude(int[] gain)
        {

            //New array 
            int[] sum = new int[gain.Length+1];
            //First altitude is 0
            sum[0] = 0;

            //Adding whole gain
            for(int i=0;i<gain.Length; i++)
            {
                sum[i + 1] = sum[i] + gain[i];
            }

            //Find max in the our new array
            return sum.Max();
        }
    }
}
