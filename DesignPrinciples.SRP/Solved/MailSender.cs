using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPrinciples.SRP.Solved
{
    public class MailSender
    {
        public string From { get; private set; }

        public MailSender(string from)
        {
            From = from;
        }

        public void SendEmail(string to, string subject, string body)
        {
            // Code für den Mailversand ...
        }
    }
}
