using System;
using System.Linq;

namespace Lession_03_HM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------Часть 1-я задания (теперь через массивы)-------------");

            string[] Names = new string[4];
            int[] Ages = new int[4];

            for (int i = 1; i <= 4; i++)
            {
                //Имена
                Console.WriteLine($"Введите имя {i}-го человека:");
                string name = Console.ReadLine();
                Names[i - 1] = name;

                //Года
                Console.WriteLine($"Введите возраст {i}-го человека:");
                int age = Int32.Parse(Console.ReadLine());
                Ages[i - 1] = age;
            }

            //Вывод массивов
            for (int i = 1; i <= 4; i++)
            {
                Console.WriteLine($"Name: {Names[i-1]}, age in 4 years: {Ages[i-1]}");
            }

            Console.ReadKey();
            
            Console.WriteLine("-------------Часть 2-я задания (Таблица Пифагора через )-------------");

            Console.WriteLine("Введите первое число:");
            int a1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            int a2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine
                (
                string.Join("\n", Enumerable.Range(a1, a2)
                .Select(n => string.Join(" ",Enumerable.Range(a1, a2)
                .Select(x => string.Format("{0,2}", n * x)))))
                );

            Console.ReadKey();
        }
    }
}
