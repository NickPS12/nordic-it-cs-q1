using System;
using System.IO;

namespace Lession_14_CW
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(File.Exists(filePath));
            //Console.WriteLine(Path.GetDirectoryName(filePath)); //относительный путь до нашего файла
            //Console.WriteLine(Path.GetFullPath(filePath)); //абсолютный путь до нашего файла
            //Console.WriteLine(Path.Combine(@"C:\", @"somepath")); //склейка путей
            /*
            var logger = new LogFileWriter(@"./../log/log.txt");
            logger.WriteLog(Path.GetFullPath(logger.FileName));
            logger.WriteLog("Thank you very much!");

            var logger2 = new LogFileWriterExtended(@"./../log/log2.txt");
            logger2.WriteLog(Path.GetFullPath(logger2.FileName));
            logger2.WriteLog("Thank you very much!");
            logger2.Dispose();

            using (var logger3 = new LogFileWriterExtended(@"./../log/log3.txt")) 
            {
                logger3.WriteLog(Path.GetFullPath(logger3.FileName));
                logger3.WriteLog("Thank you very much!");
            }
            */
            //ErrorList.OutputPrefixFormat("dddd dd MMM yy hh:mm:ss:ffd");

            using (var errorList = new ErrorList("System error"))
            {
                errorList.Add("0");
                errorList.Add("1");
                errorList.Add("2");
                errorList.Add("ОМАГАД! АШИБКА!1");
                errorList.WriteToConsole();
                //foreach (string error in errorList)
                //{
                //    Console.WriteLine(errorList.Category + ": " + error);
                //}
            }
            /*
            Console.WriteLine(Calculations.Add(7, 12));
            Console.WriteLine(Calculations.Multiplay(7, 12));
            */

        }
    }
}
