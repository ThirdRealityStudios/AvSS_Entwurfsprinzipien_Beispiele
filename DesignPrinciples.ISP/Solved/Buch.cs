using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPrinciples.ISP.Solved
{
    public class Buch : Literatur, IVerleihbar
    {
        public List<String> Autoren { get; private set; }

        public bool IstVerfuegbar { get; private set; }


        public Buch(string titel, params String[] autoren) : base(titel)
        {
            this.Autoren = new List<String>(autoren);
        }


        public override String GetInfos()
        {
            String autorenString = this.Autoren.Aggregate((a, b) => string.Concat(a, ", ", b));
            return String.Format("{0}: {1}", autorenString, this.Titel);
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
