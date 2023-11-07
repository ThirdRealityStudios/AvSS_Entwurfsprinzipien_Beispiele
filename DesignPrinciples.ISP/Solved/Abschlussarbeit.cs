using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPrinciples.ISP.Solved
{
    public class Abschlussarbeit : Literatur, IEinsehbar
    {
        public String Autor { get; private set; }

        public bool IstVerfuegbar { get; private set; }

        public Abschlussarbeit(string titel, String autor) : base(titel)
        {
            this.Autor = autor;
        }

        public override String GetInfos()
        {
            return string.Format("{0}: {1} (Thesis)", this.Autor, base.GetInfos());
        }

        public void EinsichtNehmen()
        {
            // ... Code für die Einsichtnahme
        }
    }
}
