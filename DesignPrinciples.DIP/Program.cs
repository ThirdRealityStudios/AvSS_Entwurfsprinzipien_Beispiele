using System;
using DesignPrinciples.DIP.Solved;

namespace DesignPrinciples.DIP
{
    class Program
    {
        static void Main(string[] args)
        {
            MailSender mailSender = new MailSender("service@mybib.de");
            ILogger logger = new FileLogger(@"c:\ErrorLog.txt");
            Buch buch = new Buch("Harry Potter", "Joan K. Rowling", mailSender, logger);
        }
    }
}
