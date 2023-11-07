using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

namespace DesignPrinciples.DIP.Solved
{
    public class Buch
    {


        public string Titel { get; set; }

        public string Autor { get; set; }

        public bool IsVerfuegbar { get; private set; }

        // ...

        private MailSender MailSender { get; set; }
        private ILogger Logger { get; set; }

        public Buch(string titel, string autor, MailSender mailSender, ILogger logger)
        {
            Titel = titel;
            Autor = autor;

            MailSender = mailSender;
            Logger = logger;
        }


        public void ausleihen()
        {
            try
            {
                // Code zum Ausleihen ...
                string receiverMail = ""; // ... Mailadresse des Ausleihers
                MailSender.SendEmail(receiverMail, "Buch ausgeliehen", "Sehr geehrte/r ... ");
                Logger.Info("Ausleihen erfolgreich ...");
            }
            catch (Exception e)
            {
                Logger.Error("Fehler beim Ausleihen", e);
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
                Logger.Error("Fehler bei der Einsichtnahme", e);
            }
        }

    }
}
