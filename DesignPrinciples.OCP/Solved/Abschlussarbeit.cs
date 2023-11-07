using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPrinciples.OCP.Solved
{
    public class Abschlussarbeit : Literatur
    {
        public Abschlussarbeit(string titel, string autor) : base(titel, autor)
        {
        }

        public override string GetInfos()
        {
            return base.GetInfos() + " (Thesis)";
        }
    }
}
