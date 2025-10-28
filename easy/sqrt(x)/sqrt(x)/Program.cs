using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace sqrt_x_
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine(MySqrt(225));
            Console.WriteLine(MySqrt(0));
            Console.WriteLine(MySqrt(1));
            Console.WriteLine(MySqrt(17));
            Console.WriteLine(MySqrt(37));

        }

        public static int MySqrt(int x)
        {
            //Newton Raphson Method
            double x0 = x / 2;
            double prevX;
            double n = x;
            double tol = 0.0001;


            //Special cases 0 and 1
            if (x == 0)
            {
                return 0;
            }
            else if (x == 1)
            {
                return 1;
            }


            //We can use 1000 instead of n or vice versa
            for (int i = 1; i < n; i++)
            {
                prevX = x0;

                x0 = (x0 + (n / x0)) / 2;


                //error smaller than tol we find it
                if (Math.Abs(x0 - prevX) < tol)
                {
                    break;
                }


            }

            //Return integer part
            return (int)Math.Floor(x0);
        }
    }
}
