using System;

namespace Tools.Logger
{
    public interface ILogger
    {
        void Debug(object log, Exception e = null);
        void Info(object log, Exception e = null);
        void Warn(object log, Exception e = null);
        void Error(object log, Exception e = null);
        void Fatal(object log, Exception e = null);
    }
}
