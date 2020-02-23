using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Lession_14_CW
{
    public class LogFileWriterExtended : IDisposable
    {
        private StreamWriter _streamWriter;

        public string FileName { get; }

        public LogFileWriterExtended(string fileName)
        {
            FileName = fileName;
            _streamWriter = new StreamWriter(File.Open(
                fileName,
                FileMode.Append, //в позицию после последнего символа
                FileAccess.Write,
                FileShare.None));
        }

        public void WriteLog(string message) 
        {
            _streamWriter.WriteLine($"{DateTimeOffset.UtcNow:O}\t{message}");
            _streamWriter.Flush();
        }

        public void Close()
        {
            _streamWriter.Dispose();
        }

        public void Dispose() //метод который почистит сам всё
        {
            _streamWriter?.Close(); //Стримврайтер ли сейчас? Ежели да, то деспоузэбл его.
        }
    }
}
