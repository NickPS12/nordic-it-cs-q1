using System;

namespace Lession_12_HM
{
    class Program
    {
        static void Main(string[] args)
        {
            var reminder = new ReminderItem(DateTimeOffset.Parse("2020-03-31"), "Wake up, Neo... The Matrix has you...");
            reminder.WriteProperties();

            var phonereminder = new PhoneReminderItem("8-800-555-35-35", DateTimeOffset.Parse("2020-03-31"), "Wake up, Neo... The Matrix has you...");
            phonereminder.WriteProperties();

            var chatreminder = new ChatReminderItem("Курсы C# NordicSchool","Nikolay Panov", DateTimeOffset.Parse("2020-01-10"), "Wake up, Neo... The Matrix has you...");
            chatreminder.WriteProperties();
    }
    }
}
