using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Lession_13_HM
{
    class ConsoleLogWriter : ILogWriter
    {
        #region Методы: ForamtLogRecord, LogInfo, LogWarning, LogError
        protected string ForamtLogRecord(string message, LogMessageType logMessageType) //метод форматирования записей лога
        {
            return string.Format($"{DateTime.UtcNow:yyyy-MM-ddThh:mm:ss}+0000 {logMessageType} {message}");
        }

        public void LogInfo(string message)
        {
            Console.WriteLine(ForamtLogRecord(message, LogMessageType.Info));
        }

        public void LogWarning(string message)
        {
            Console.WriteLine(ForamtLogRecord(message, LogMessageType.Warning));
        }

        public void LogError(string message)
        {
            Console.WriteLine(ForamtLogRecord(message, LogMessageType.Error));
        }
        #endregion  
    }
}
