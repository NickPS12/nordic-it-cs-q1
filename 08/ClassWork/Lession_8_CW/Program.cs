using System;

namespace Lession_8_CW
{
    class Program
    {
        static void Main(string[] args)
        {
            Cash mycash = new Cash();

            Console.WriteLine("Мои доллары 1: " + mycash.Dollars);
            Console.WriteLine("Мои рубли 1: " + mycash.Rubles);

            mycash.Dollars =+ 100;

            Console.WriteLine("\nМои доллары 2: " + mycash.Dollars);
            Console.WriteLine("Мои рубли 2: " + mycash.Rubles);

            mycash.Rubles =+ 6500;

            Console.WriteLine("\nМои доллары 3: " + mycash.Dollars);
            Console.WriteLine("Мои рубли 3: " + mycash.Rubles);

            Console.ReadKey();
        }
    }
}
