using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "heater";
            string str2 = "reater";

            char[] ch1 = str1.ToLower().ToCharArray();
            char[] ch2 = str1.ToLower().ToCharArray();

            Array.Sort(ch1);
            Array.Sort(ch2);

            string val1 = new string(ch1);
            string val2 = new string(ch2);

            if(val1==val2)
            {
                Console.WriteLine("Anagram");

            }else
            {
                Console.WriteLine("Not Anagram");
            }

        }
    }
}
