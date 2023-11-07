using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

namespace DesignPrinciples.SRP.Problem
{
    public class Buch
    {
        public string Titel { get; set; }

        public string Autor { get; set; }

        public bool IsVerfuegbar { get; private set; }

        // ...


        public Buch(string titel, string autor)
        {
            Titel = titel;
            Autor = autor;
        }


        public void ausleihen()
        {
            try
            {
                // Code zum Ausleihen ...
                string receiverMail = ""; // ... Mailadresse des Ausleihers
                MailMessage message = new MailMessage("service@mybib.de", receiverMail, "Buch ausgeliehen", "Sehr geehrte/r ... ");
                SendEmail(message);
            }
            catch (Exception e)
            {
                System.IO.File.WriteAllText(@"c:\ErrorLog.txt", e.ToString());
            }
        }

        public void einsehen()
        {
            try
            {
                // Code für die Einsichtnahme ...
            }
            catch (Exception e)
            {
                System.IO.File.WriteAllText(@"c:\ErrorLog.txt", e.ToString());
            }
        }

        public void SendEmail(MailMessage message)
        {
            try
            {
                // Code für den Mailversand ...
            }
            catch (Exception e)
            {
                System.IO.File.WriteAllText(@"c:\ErrorLog.txt", e.ToString());
            }
        }

    }
}
