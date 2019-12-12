using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Lession_8_HM
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] person = new Person[3];

            for (int i = 0; i < person.Length; i++)
            {
                person[i] = new Person();
                enter:
                Console.Write($"Введите имя {i}-го человека: ");
                person[i].Name = Console.ReadLine();
                
                Console.Write($"Введите возраст {i}-го человека: ");
                try
                {
                    person[i].Age = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine($"Возраст должен являться целым числом, попробуйте еще раз!\nНажмите любую клавишу, чтобы повторить ввод."); Console.ResetColor();
                    Console.ReadKey();
                    Console.Clear();
                    goto enter;
                }
                
            }

            for (int i = 0; i < person.Length; i++)
            {
                Console.WriteLine(person[i].STR);
            }
            Console.ReadKey();
        }
    }
}
