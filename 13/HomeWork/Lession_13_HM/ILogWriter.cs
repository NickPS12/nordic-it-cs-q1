using System;
using System.Collections.Generic;
using System.Text;

namespace Lession_13_HM
{
    interface ILogWriter
    {
        void LogInfo(string message);

        void LogWarning(string message);

        void LogError(string message);

    }
}
