using System;

namespace Lession_13_HM
{
    class Program
    {
        static void Main(string[] args)
        {
            //Только в консоль через ConsoleLogWriter
            var consoleLogWriter = new ConsoleLogWriter();
            consoleLogWriter.LogInfo("Programm is running");
            consoleLogWriter.LogWarning("Low memory");
            consoleLogWriter.LogError("100500 backend error");

            //Только в файл через FileLogWriter
            var fileLogWriter = new FileLogWriter();
            fileLogWriter.LogInfo("Programm is running");
            fileLogWriter.LogWarning("Low memory");
            fileLogWriter.LogError("100500 backend error");
        }
    }
}
