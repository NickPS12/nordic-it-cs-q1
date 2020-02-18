using System;
using System.Collections.Generic;
using System.Text;

namespace Lession_12_HM
{
    class ChatReminderItem : ReminderItem
    {
        public string ChatName { get; set; } //Название чата

        public string AccountName { get; set; } //Имя аккаунта в чате, которому нужно послать сообщение

        public ChatReminderItem(string chatName, string accountName, DateTimeOffset date, string message) : base(date, message)
        {
            ChatName = chatName;
            AccountName = accountName;
        }

        public override void WriteProperties()
        {
            base.WriteProperties();
            Console.WriteLine(
                $"Сообщение в чат \"{ChatName}\" для \"{AccountName}\"");
        }
    }
}
