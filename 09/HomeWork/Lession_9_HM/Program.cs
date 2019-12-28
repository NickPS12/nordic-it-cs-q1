using System;
using System.Text;

namespace Lession_9_HM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите дату в формате YYYY-MM-DD:");
            string MyDate = Console.ReadLine();
            Console.WriteLine("Введите сообщение, которое должно быть выведено:");
            string MyMessage = Console.ReadLine();
            var r1 = new ReminderItem(DateTimeOffset.Parse(MyDate), MyMessage);
            r1.WriteProperties();
            Console.ReadKey();
        }
    }
}
