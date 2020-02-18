using System;
using System.Collections.Generic;
using System.Text;

namespace Lession_12_HM
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

        public virtual void WriteProperties()
        {
            Console.WriteLine(
                $"\nОбъект: {GetType().Name}" +
                $"\nДата и время будильника: {AlarmDate}" +
                $"\nСообщение: {AlarmMessage}" +
                $"\nПросрочено ли событие: {IsOutdated}" +
                $"\nВремени до срабатывания будильника: {TimeToAlarm.ToString(@"dd\ hh\:mm\:ss")}");
        }
    }
}
