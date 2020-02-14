using System;

namespace Lession_11_HM
{
    class Program
    {
        static void Main(string[] args)
        {
            var reminder = new ReminderItem(DateTimeOffset.Parse("2020-03-31"), "Wake up, Neo... The Matrix has you...");
            reminder.WriteProperties();
        }
    }
}
