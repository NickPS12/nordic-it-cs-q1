using System;

namespace Lession_06_HM
{
    class Program
    {
        static void Main(string[] args)
        {
            start:
            static void ExceptionMessage()
            {
                throw new Exception("Ошибка System.FormatException! Попробуйте ещё раз.");
            }

            try
            {
                Console.WriteLine("Введите любое натуральное число:");
                string vvod = Console.ReadLine();
                int num = Int32.Parse(vvod);
                int charnum = 0;

                if (num > 2_000_000_000 && num < 1)
                {
                    ExceptionMessage();
                }

                char[] array = vvod.ToCharArray();

                foreach (char c in vvod)
                {
                    if (c != '0' && Convert.ToInt32(c) % 2 == 0) charnum++;
                }
                Console.WriteLine($"В числе {num} содержится следующее количество четных цифр: {charnum}");
            }
            catch
            {
                ExceptionMessage();
            };

            Console.ReadKey();
            Console.Clear();
            goto start;
        }
    }
}
