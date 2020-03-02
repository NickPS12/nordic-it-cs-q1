using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Lession_13_HM
{
    abstract class AbstractLogWriter : ILogWriter, IDisposable
    {
        public string FileName = @"./../log/log.txt";

        private StreamWriter _logFileWriter;

        protected string ForamtLogRecord(string message, LogMessageType logMessageType) //метод форматирования записей лога
        {
            return string.Format($"{DateTime.UtcNow:yyyy-MM-ddThh:mm:ss}+0000 {logMessageType} {message}");
        }

        public AbstractLogWriter()
        {
            _logFileWriter = new StreamWriter(File.Open(FileName,
                                                        FileMode.OpenOrCreate,
                                                        FileAccess.ReadWrite,
                                                        FileShare.Read));

            _logFileWriter.BaseStream.Seek(0, SeekOrigin.End);
        }

        public void Write(string message, LogMessageType logMessageType, AbstractLogWriter someClass)
        {
            if (someClass is IDisposable)
            {
                _logFileWriter.WriteLine(ForamtLogRecord(message, LogMessageType.Info));
                _logFileWriter.Flush();
            }
            else
            {
                Console.WriteLine(ForamtLogRecord(message, LogMessageType.Info));
            }
        }

        public void LogInfo(string message)
        {

        }

        public void LogWarning(string message)
        {

        }

        public void LogError(string message)
        {

        }

        public void Dispose()
        {
            if (_logFileWriter != null)
                _logFileWriter.Dispose();
        }
    }
}
