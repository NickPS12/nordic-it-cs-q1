using System;

namespace Lession_07_HM
{
    class Program
    {
        static void Main(string[] args)
        {
            start:

            var s1 = "()";            // True
            var s2 = "[]()";          // True
            var s3 = "[[]()]";        // True
            var s4 = "([([])])()[]";  // True

            var s5 = "(";             // False
            var s6 = "[][)";          // False
            var s7 = "[(])";          // False
            var s8 = "(()[]]";        // False

            Console.WriteLine("Введите строку для проверки правильности закрытия скобок:");


            
            Console.ReadKey();
            goto start;
        }
    }
}
