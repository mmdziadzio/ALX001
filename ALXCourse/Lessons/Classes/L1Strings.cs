using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXCourse.Lessons.Classes
{
    public class L1Strings
    {
        public static void Test()
        {
            string name = "Mateusz";
            name = "Ala";
            Console.WriteLine(name);
            name = name + " ma kota";
            Console.WriteLine(name);

            ExpandString(name, "hallo");
            Console.WriteLine(name);
            ExpandString(name, "Bla Bla Bla");
            Console.WriteLine(name);
            ExpandString(name, "WORLD");
            Console.WriteLine(name);
        }

        public static void ExpandString(string word, string extension)
        {
            word = word + extension;
        }

        public static void ConcatenationTest2()
        {
            string word1 = "Ala ma ";
            string word2 = "Koty dwa ";

            string concat1 = word1 + " " +word2;
            string concat3 = $"{word1} {word2} i dobrze się ma";  // string interpolation
            Console.WriteLine(concat3);
        }
    }
}
