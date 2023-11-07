using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPrinciples.LSP.Problem
{
    public class Abschlussarbeit : Buch
    {
        public Abschlussarbeit(string titel, string autor) : base(titel, autor)
        {
        }

        public override void Ausleihen()
        {
            throw new NotSupportedException();
        }
    }
}
