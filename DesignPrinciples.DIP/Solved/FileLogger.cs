using System;
using DesignPrinciples.DIP.Solved;

namespace DesignPrinciples.DIP
{
    public class FileLogger : ILogger
    {
        public String LogFile { get; private set; }

        public FileLogger(string logFile)
        {
            // ... create and init logfile
        }
        public void Info(string info)
        {
            // ...
        }
        public void Debug(string info)
        {
            // ...
        }
        public void Error(string message, Exception ex)
        {
            // ...
        }
    }
}