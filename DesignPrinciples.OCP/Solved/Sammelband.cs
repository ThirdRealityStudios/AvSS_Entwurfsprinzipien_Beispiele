using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPrinciples.OCP.Solved
{
    public class Sammelband : Literatur
    {
        public Sammelband(string titel, string autor) : base(titel, autor)
        {
        }

        public override string GetInfos()
        {
            return string.Format("{0} (Hrsg.): {1}", Autor, Titel);
        }
    }
}
