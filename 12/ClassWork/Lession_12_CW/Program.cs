using System;

namespace Lession_12_CW
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseDocument baseDocument = new BaseDocument("Справка формы № 100500", "УК-228", DateTimeOffset.Parse("01-10-2007"));
            baseDocument.WriteToConsole();

            Passport passport = new Passport("4510 654532", DateTimeOffset.Parse("15-10-2007"), "Уганда", "Иванов Иван Александровна");
            passport.WriteToConsole();

            int DocumentsCount = 5;

            BaseDocument[] Documents = new BaseDocument[DocumentsCount];

            Documents[0] = new BaseDocument("Справка", "00", DateTimeOffset.Parse("01-10-2007"));
            Documents[1] = new BaseDocument("Справка", "01", DateTimeOffset.Parse("01-10-2007"));
            Documents[2] = new Passport("02", DateTimeOffset.Parse("01-10-2007"), "Латвия", "Кадыров Р.К.");
            Documents[3] = new Passport("03", DateTimeOffset.Parse("01-10-2007"), "Белоруссия", "Поклонская И.П.");
            Documents[4] = new Passport("04", DateTimeOffset.Parse("01-10-2007"), "Уганда", "Иванов И.И.");

            Console.WriteLine("==================================");

            for (int i = 0; i < DocumentsCount; i++)
            {
                if (Documents[i] is Passport)
                {
                    (Documents[i] as Passport).ChangeIssueDate(DateTimeOffset.Now);
                }
                Documents[i].WriteToConsole();
            }

        }
    }
}
