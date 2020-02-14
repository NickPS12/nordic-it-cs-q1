using System;
using System.Collections.Generic;
using System.Text;

namespace Lession_12_CW
{
    class Passport : BaseDocument
    {
        public string Country { get; set; }

        public string PersonName { get; set; }

        public override string PropertiesString
        {
            get
            {
                return
                    $"\n{GetType().Name}" +
                    $"\nНаименование документа: {DocName}" +
                    $"\nНомер документа: {DocNumber}" +
                    $"\nДата выдачи документа: {IssueDate:dd-MM-yyyy}" +
                    $"\nГражданство: {Country}" +
                    $"\nФИО владельца: {PersonName}";
            }
        }

        public Passport ( string number, DateTimeOffset date, string country, string personName) : base ("Паспорт", number, date)
        {
            Country = country;
            PersonName = personName;
        }

        public void ChangeIssueDate(DateTimeOffset newIssueDate)
        {
            IssueDate = newIssueDate;
        }
    }
}
