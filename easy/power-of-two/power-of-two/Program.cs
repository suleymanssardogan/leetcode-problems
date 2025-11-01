
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace power_of_two
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Test
            bool a = IsPowerOfTwo(2);
            Console.WriteLine(a);
        }

        public static bool IsPowerOfTwo(int n)
        {
            //Less than 0 false
            if (n<= 0) return false;

            //Based 2 Log
            double x = Math.Log(n,2);
            //a whole number control
            return x % 1 == 0;
        }

    }
}
