using System;
using System.Collections.Generic;
using System.Text;

namespace Lession_11_HM
{
    class ReminderItem
    {
        public DateTimeOffset AlarmDate { get; set; }

        public string AlarmMessage { get; set; }

        public TimeSpan TimeToAlarm => AlarmDate.Subtract(DateTimeOffset.UtcNow);

        public bool IsOutdated => TimeToAlarm <= TimeSpan.Zero;

        public ReminderItem(DateTimeOffset date, string message)
        {
            AlarmDate = date;
            AlarmMessage = message;
        }

        public void WriteProperties()
        {
            Console.WriteLine(
                $"Дата и время будильника: {AlarmDate}\n" +
                $"Сообщение: {AlarmMessage}\n" +
                $"Просрочено ли событие: {IsOutdated}\n" +
                $"Времени до срабатывания будильника: {TimeToAlarm.ToString(@"dd\ hh\:mm\:ss")}\n");
        }
    }
}
