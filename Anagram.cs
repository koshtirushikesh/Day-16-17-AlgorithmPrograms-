using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    internal class Anagram
    {
        public void AnagramDisplay()
        {
            string str1 = "heater";
            string str2 = "reheat";

            char[] char1 = str1.ToLower().ToCharArray();
            char[] char2 = str2.ToLower().ToCharArray();

            Array.Sort(char1);
            Array.Sort(char2);

            string val1 = new string(char1);
            string val2 = new string(char2);

            Console.WriteLine(val1);
            Console.WriteLine(val2);

            if (val1 == val2)
            {
                Console.WriteLine("Anagram");
            }
            else
            {
                Console.WriteLine("Not Anagram");
            }
        }
    }
}
