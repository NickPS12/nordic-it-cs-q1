using System;

namespace Lession_04_HM
{
    class Program
    {
        enum Months: byte
        {
            January = 1,    // Каждый следующий элемент ++
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер месяца:");
            byte MonthSelect = byte.Parse(Console.ReadLine());

            switch (MonthSelect)
            {
                case 1:
                    Console.WriteLine($"Месяц: {Months.January} \nКвартал: I  \nСезон: Зима");
                    break;
                case 2:
                    Console.WriteLine($"Месяц: {Months.February} \nКвартал: I  \nСезон: Зима");
                    break;
                case 3:
                    Console.WriteLine($"Месяц: {Months.March} \nКвартал: I  \nСезон: Весна");
                    break;
                case 4:
                    Console.WriteLine($"Месяц: {Months.April} \nКвартал: II  \nСезон: Весна");
                    break;
                case 5:
                    Console.WriteLine($"Месяц: {Months.May} \nКвартал: II  \nСезон: Весна");
                    break;
                case 6:
                    Console.WriteLine($"Месяц: {Months.June} \nКвартал: II  \nСезон: Лето");
                    break;
                case 7:
                    Console.WriteLine($"Месяц: {Months.July} \nКвартал: III  \nСезон: Лето");
                    break;
                case 8:
                    Console.WriteLine($"Месяц: {Months.August} \nКвартал: III  \nСезон: Лето");
                    break;
                case 9:
                    Console.WriteLine($"Месяц: {Months.September} \nКвартал: III  \nСезон: Осень");
                    break;
                case 10:
                    Console.WriteLine($"Месяц: {Months.October} \nКвартал: IV  \nСезон: Осень");
                    break;
                case 11:
                    Console.WriteLine($"Месяц: {Months.November} \nКвартал: IV  \nСезон: Осень");
                    break;
                case 12:
                    Console.WriteLine($"Месяц: {Months.December} \nКвартал: IV  \nСезон: Зима");
                    break;
                default:
                    Console.WriteLine("Месяца с таким номером не существует.");
                    break;
            }

            Console.ReadKey();
        }
    }
}
