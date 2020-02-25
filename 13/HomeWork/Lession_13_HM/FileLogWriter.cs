using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Lession_13_HM
{
    public class FileLogWriter : ILogWriter, IDisposable
    {
        public string FileName = @"./../log/log.txt";

        private StreamWriter _logFileWriter;

        public FileLogWriter()
        {
            _logFileWriter = new StreamWriter(File.Open(FileName,
                                                        FileMode.OpenOrCreate,
                                                        FileAccess.ReadWrite,
                                                        FileShare.Read));

            _logFileWriter.BaseStream.Seek(0, SeekOrigin.End);
        }

        #region Методы: ForamtLogRecord, LogInfo, LogWarning, LogError
        protected string ForamtLogRecord(string message, LogMessageType logMessageType) //метод форматирования записей лога
        {
            return string.Format($"{DateTime.UtcNow:yyyy-MM-ddThh:mm:ss}+0000 {logMessageType} {message}");
        }

        public void LogInfo(string message)
        {
            _logFileWriter.WriteLine(ForamtLogRecord(message, LogMessageType.Info));
            _logFileWriter.Flush();
        }

        public void LogWarning(string message)
        {
            _logFileWriter.WriteLine(ForamtLogRecord(message, LogMessageType.Warning));
            _logFileWriter.Flush();
        }

        public void LogError(string message)
        {
            _logFileWriter.WriteLine(ForamtLogRecord(message, LogMessageType.Error));
            _logFileWriter.Flush();
        }
        #endregion

        public void Dispose()
        {
            if (_logFileWriter != null)
                _logFileWriter.Dispose();
        }
    }
}
