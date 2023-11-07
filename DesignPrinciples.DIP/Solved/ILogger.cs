using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPrinciples.DIP.Solved
{
    public interface ILogger
    {
        public void Info(string info);

        public void Debug(string info);

        public void Error(string message, Exception ex);
    }
}
