using System;

namespace DesignPrinciples.SRP.Solved
{
    public class FileLogger
    {
        public string LogFile { get; private set; }

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