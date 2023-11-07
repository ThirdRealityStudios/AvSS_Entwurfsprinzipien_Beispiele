using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPrinciples.LSP.Problem
{
    public class Buch
    {
        public string Titel { get; set; }
        public List<string> Autoren { get; private set; }

        public Buch(string titel, params string[] autoren)
        {
            Titel = titel;
            Autoren = new List<string>(autoren);
        }


        public virtual string GetInfos()
        {
            string autorenString = Autoren.Aggregate((a, b) => string.Concat(a, ", ", b));
            return string.Format("{0}: {1}", autorenString, Titel);
        }

        public virtual void Ausleihen()
        {
            // ... Code für die Ausleihe
        }
    }
}
