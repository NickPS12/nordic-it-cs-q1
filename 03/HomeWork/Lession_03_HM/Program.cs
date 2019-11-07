using System;
using System.Linq;

namespace Lession_03_HM
{
    class Program
    {
        /*
        Честно говоря, хотел сделать все через циклы, но уж больно долго выходило... Времени не хватило. =(

        static void Ask()
        {
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
        */
        static void Main(string[] args)
        {
            string[,] NamesAndAges = new string[4, 2];

            Console.WriteLine("Введите имя:");
            string a1 = Console.ReadLine();
            Console.WriteLine("Введите возраст:");
            string b1 = Console.ReadLine();

            Console.WriteLine("Введите имя:");
            string a2 = Console.ReadLine();
            Console.WriteLine("Введите возраст:");
            string b2 = Console.ReadLine();

            Console.WriteLine("Введите имя:");
            string a3 = Console.ReadLine();
            Console.WriteLine("Введите возраст:");
            string b3 = Console.ReadLine();

            Console.WriteLine("Введите имя:");
            string a4 = Console.ReadLine();
            Console.WriteLine("Введите возраст:");
            string b4 = Console.ReadLine();

            //Имена
            NamesAndAges[0, 0] = a1;
            NamesAndAges[1, 0] = a2;
            NamesAndAges[2, 0] = a3;
            NamesAndAges[3, 0] = a4;
            //Года
            NamesAndAges[0, 1] = b1;
            NamesAndAges[1, 1] = b2;
            NamesAndAges[2, 1] = b3;
            NamesAndAges[3, 1] = b4;
            Console.Clear();

            Console.WriteLine($"Name: {NamesAndAges[0, 0]}, age in 4 years: {NamesAndAges[0, 1]}");
            Console.WriteLine($"Name: {NamesAndAges[1, 0]}, age in 4 years: {NamesAndAges[1, 1]}");
            Console.WriteLine($"Name: {NamesAndAges[2, 0]}, age in 4 years: {NamesAndAges[2, 1]}");
            Console.WriteLine($"Name: {NamesAndAges[3, 0]}, age in 4 years: {NamesAndAges[3, 1]}");

            Console.ReadKey();
        }
    }
}
