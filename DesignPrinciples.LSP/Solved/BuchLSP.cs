using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPrinciples.LSP.Solved
{
    public class Buch : Literatur
    {
        public List<string> Autoren { get; private set; }

        public Buch(string titel, params string[] autoren) : base(titel)
        {
            Autoren = new List<string>(autoren);
        }

        public override string GetInfos()
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
