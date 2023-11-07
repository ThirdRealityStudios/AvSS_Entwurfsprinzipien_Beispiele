using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPrinciples.LSP.Solved
{
    public class Abschlussarbeit : Literatur
    {
        public string Autor { get; private set; }

        public Abschlussarbeit(string titel, string autor) : base(titel)
        {
            Autor = autor;
        }

        public override string GetInfos()
        {
            return string.Format("{0}: {1} (Thesis)", Autor, base.GetInfos());
        }
    }
}
