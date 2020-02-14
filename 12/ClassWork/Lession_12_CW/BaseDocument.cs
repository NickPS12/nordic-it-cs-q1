using System;
using System.Collections.Generic;
using System.Text;

namespace Lession_12_CW
{
    class BaseDocument
    {
        public string DocName { get; set; }
        public string DocNumber { get; set; }
        public DateTimeOffset IssueDate { get; set; }
        public virtual string PropertiesString 
        { 
            get 
            { 
                return
                    $"\n{GetType().Name}" +
                    $"\nНаименование документа: {DocName} " + 
                    $"\nНомер документа: {DocNumber} " +
                    $"\nДата выдачи документа: {IssueDate:dd-MM-yyyy}";
            } 
        }
        public void  WriteToConsole()
        {
            Console.WriteLine(PropertiesString);
        }

        public BaseDocument(string name, string number, DateTimeOffset date)
        {
            DocName = name;
            DocNumber = number;
            IssueDate = date;
        }
    }
}

//IssueDate = DateTimeOffset.Parse("dd-MM-yy");
