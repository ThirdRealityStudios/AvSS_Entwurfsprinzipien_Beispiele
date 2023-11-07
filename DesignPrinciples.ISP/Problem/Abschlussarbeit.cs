using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPrinciples.ISP.Problem
{
    public class Abschlussarbeit : Literatur, IAusleihe
    {
        public string Autor { get; private set; }

        public bool IstVerfuegbar { get; private set; }

        public Abschlussarbeit(string titel, string autor) : base(titel)
        {
            Autor = autor;
        }

        public override string GetInfos()
        {
            return string.Format("{0}: {1} (Thesis)", Autor, base.GetInfos());
        }

        public void Ausleihen()
        {
            throw new NotSupportedException("Abschlussarbeiten dürfen nicht ausgeliehen werden");
        }

        public void EinsichtNehmen()
        {
            // ... Code für die Einsichtnahme
        }
    }
}
