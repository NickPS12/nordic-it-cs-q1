using System;

namespace Lession_06_2_HM
{
    class Program
    {
        static void Main(string[] args)
        {
            start:
            try
            {
                Console.WriteLine("Введите сумму первоначального взноса:");
                double vznos = Convert.ToDouble((Console.ReadLine()).Replace(".", ","));

                if (vznos > 0)
                {
                    Console.WriteLine("Введите сумму ежедневного процента дохода в виде десятичной дроби (1% = 0.01):");
                    double proz = (Convert.ToDouble((Console.ReadLine()).Replace(".", ",")))*100;

                    Console.WriteLine("Введите сумму желаемого накопления:");
                    double EndSum = Convert.ToDouble((Console.ReadLine()).Replace(".", ","));

                    int days = 0;

                    while (vznos <= EndSum)
                    {
                        //Console.WriteLine($"День {days}, денег {vznos}");
                        vznos *= (1 + proz / 100);
                        days++;
                    }

                    Console.WriteLine($"Кол-во дней: {days}");
                }
                else 
                { 
                    Console.WriteLine("Размер первоначального взноса должен быть больше ноля! Повторите ввод.");
                    Console.ReadKey();
                    goto start;
                }
                

            }
            catch
            {
                throw new Exception("Oooops! System.FormatException!");
            }

            Console.ReadKey();
        }
    }
}
