using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace add_binary
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string a = "10";
            string b = "11";
            int c  = Convert.ToInt32(b);
            Console.WriteLine(c);

        }

        public static string AddBinary(string a, string b)
        {
            char [] chars = a.ToCharArray();
            char [] chars2 = b.ToCharArray();
            char[] result = new char[Math.Max(chars2.Length,chars.Length)];
            for (int i = chars.Length-1; i >=0; i--)
            {
                for (int j = chars2.Length; j>=0; j--)
                {
                    if( chars2[j] =='1' && chars[i] == '0')
                    {

                    }
                }
            }
        }
    }
}
