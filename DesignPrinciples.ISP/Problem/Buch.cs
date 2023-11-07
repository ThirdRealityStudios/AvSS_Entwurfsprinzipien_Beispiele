using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPrinciples.ISP.Problem
{
    public class Buch : Literatur, IAusleihe
    {
        public List<string> Autoren { get; private set; }

        public bool IstVerfuegbar { get; private set; }


        public Buch(string titel, params string[] autoren) : base(titel)
        {
            Autoren = new List<string>(autoren);
        }


        public override string GetInfos()
        {
            string autorenString = Autoren.Aggregate((a, b) => string.Concat(a, ", ", b));
            return string.Format("{0}: {1}", autorenString, Titel);
        }

        public void Ausleihen()
        {
            // ... Code für die Ausleihe
        }

        public void EinsichtNehmen()
        {
            // ... Code für die Einsichtnahme
        }
    }
}
