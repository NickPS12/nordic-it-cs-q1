using System;

namespace Lession_10_HM
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[5];
            int num;
            for (int i = 1; i <= 4; i++)
            {
                persons[i] = new Person();

                entername:
                Console.WriteLine($"Введите имя {i}-го человека:");
                persons[i].Name = Console.ReadLine();
                bool CheckNum = int.TryParse(persons[i].Name, out num);
                if (CheckNum == true)
                { 
                    Console.WriteLine("Число не может быть именем. Попробуйте еще раз.");
                    Console.ReadKey();
                    Console.Clear();
                    goto entername;
                }

                enterage:
                Console.WriteLine($"Введите возраст {i}-го человека:");
                try
                {
                    persons[i].Age = Int32.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Так не бывает... Попробуйте еще раз.");
                    Console.ReadKey();
                    Console.Clear();
                    goto enterage;
                }
                
                persons[i].SetBirthPlace();
                Console.Clear();
            }

            for (int i = 1; i <= 4; i++)
            {
                Console.WriteLine(persons[i].Discription);
            }

            Console.ReadKey();
        }
    }
}
