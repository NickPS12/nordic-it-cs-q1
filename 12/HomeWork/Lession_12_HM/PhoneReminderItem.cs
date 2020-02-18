using System;
using System.Collections.Generic;
using System.Text;

namespace Lession_12_HM
{
    class PhoneReminderItem : ReminderItem
    {
        public string PhoneNumber { get; set; } //Номер телефона, куда нужно послать сообщение.

        public PhoneReminderItem(string phoneNumber, DateTimeOffset date, string message) : base(date, message)
        {
            PhoneNumber = phoneNumber;
        }

        public override void WriteProperties()
        {
            base.WriteProperties();
            Console.WriteLine(
                $"Сообщение отправлено на номер: {PhoneNumber}");
        }
    }
}
