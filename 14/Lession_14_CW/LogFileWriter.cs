using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Lession_14_CW
{
    public class LogFileWriter
    {
        public string FileName { get; }

        public LogFileWriter(string fileName)
        {
            FileName = fileName;
        }

        public void WriteLog(string message) 
        {
            var sw = new StreamWriter(File.Open(
                FileName, 
                FileMode.Append, //в позицию после последнего символа
                FileAccess.Write,
                FileShare.None));

            sw.WriteLine($"{DateTimeOffset.UtcNow:O}\t{message}");

            //sw.Flush(); //метод записи на диск, ибо до этого все висит в оперативной памяти
            sw.Close(); //Flush + закрытие потока
        }
    }
}
