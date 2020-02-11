using System;

namespace Lession_10_HM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество человек: ");

            string str = Console.ReadLine();

            bool CheckNum1 = int.TryParse(str, out int num1);
            
            if (CheckNum1 == true)
            {
                int persons_count = Int32.Parse(str);

                Person[] persons = new Person[persons_count + 1];

                for (int i = 1; i <= persons_count; i++)
                {
                    persons[i] = new Person();

                    Console.Write($"Введите имя {i}-го человека: ");

                    persons[i].Name = Console.ReadLine();

                    bool CheckNum2 = int.TryParse(persons[i].Name, out int num2);

                    if (CheckNum2 == true)
                    {
                        throw new Exception ("Число не может быть именем.");
                    }

                    Console.Write ($"Введите возраст {i}-го человека: ");
                    try
                    {
                        persons[i].Age = Int32.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        throw new Exception ("Возраст должен быть целочисленным значением.");
                    }

                    persons[i].AgeAdder();
                }

                for (int i = 1; i <= persons_count; i++)
                {
                    Console.WriteLine(persons[i].Discription);
                }
            }
            else 
            {
                throw new Exception ("Количество людей должно быть целочисленным значением.");
            }

            

            Console.ReadKey();
        }
    }
}
