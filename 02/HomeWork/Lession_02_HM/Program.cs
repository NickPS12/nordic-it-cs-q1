using System;
using System.Threading;

namespace Lession_02_HM
{
    class Program
    {
        static void Clear()
        {
            ///Очистка консоли
            Console.Clear();
        }
        static void Whait(Int16 x)
        {
            //Ожидание
            Thread.Sleep(x);
        }
        static void Pause()
        {
            //Пауза
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в калькулятор!");
            Whait(1200);
            Clear();

            Console.WriteLine("Введите первое число:");
            double x = Convert.ToDouble(Console.ReadLine());   

            Console.WriteLine("Выберите  операцию:\nСложение  => +\nВычитание => -\nУмножение => *\nДеление   => /\nОстаток от деления => %\nВозвести в степень => %");
            string operate = Console.ReadLine();
            double result;
            Console.WriteLine("Введите второе число:");
            double y = Convert.ToDouble(Console.ReadLine());
            switch (operate)
            {
                case "+":
                    result = x + y;
                    Console.WriteLine($"Сумма: {result}");
                    break;
                case "-":
                    result = x - y;
                    Console.WriteLine($"Разница: {result}");
                    break;
                case "*":
                    result = x * y;
                    Console.WriteLine($"Произведение: {result}");
                    break;
                case "/":
                    result = x / y;
                    Console.WriteLine($"Частное: {result}");
                    break;
                case "%":
                    result = x % y;
                    Console.WriteLine($"Остаток: {result}");
                    break;
                case "**":
                    result = Math.Pow(x, y);
                    Console.WriteLine($"Результат возведения в степень: {result}");
                    break;
                default:
                    Console.WriteLine($"Вы задали неверную операцию или ввели неверный символ!");
                    break;
            }
            Pause();
        }
    }
}
