using System;

namespace Lession_07_HM
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            var s1 = "()";            // True
            var s2 = "[]()";          // True
            var s3 = "[[]()]";        // True
            var s4 = "([([])])()[]";  // True

            var s5 = "(";             // False
            var s6 = "[][)";          // False
            var s7 = "[(])";          // False
            var s8 = "(()[]]";        // False
            */
            start:
            Console.WriteLine("Введите хаотичную последовательность символов \"(\",\")\",\"[\" или \"]\":");
            string str = Console.ReadLine();
            char[] arr1 = str.ToCharArray(0, str.Length);
            string str1 = ($"{arr1[0]}" + $"{arr1[str.Length-1]}");
            if (str1 == "()" || str1 == "[]")
            {
                Console.WriteLine("true");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("false");
                Console.ReadKey();
                Console.Clear();
            }
            goto start;
        }
    }
}
