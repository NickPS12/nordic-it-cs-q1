using System;

namespace Lession_03_HM
{
    class Program
    {
        static void Ask()
        {
            string[,] NamesAndAges = new string[4,2];

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Введите имя:");
                string a = Console.ReadLine();
                Console.WriteLine("Введите возраст:");
                string b = Console.ReadLine();
                int x = 0;
                x++;
                int y = 0;
                y++;
                NamesAndAges[x, y] = a;
                NamesAndAges[0, 1] = b;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
