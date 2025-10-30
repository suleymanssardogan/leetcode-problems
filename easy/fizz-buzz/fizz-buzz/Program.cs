using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fizz_buzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Test Cases
            int a = 16;
            var test = FizzBuzz(a);

            foreach (var item in test)
            {
                Console.WriteLine(item);
            }
        }

        public static IList<string> FizzBuzz(int n)
        {
            //Describe our list
            List<string> my_list = new List<string>();
            for (int i = 1; i <= n; i++)
            {
                //We have to start wide part
                if (i % 3 == 0 && i % 5 == 0)
                {
                    my_list.Add("FizzBuzz");
                }

                else if (i % 3 == 0)
                {
                    my_list.Add("Fizz");
                }

                else if (i % 5 == 0)
                {
                    my_list.Add("Buzz");
                }

                // Any conditions is wrong.Then we have to do add to list normal number
                else
                {
                    my_list.Add(i.ToString());

                }
            }


            return my_list;


        }
    }
}
