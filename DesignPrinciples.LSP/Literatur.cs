using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPrinciples.LSP
{
    public abstract class Literatur
    {
        public string Titel { get; set; }


        public Literatur(String titel)
        {
            this.Titel = titel;
        }

        public virtual String GetInfos()
        {
            return this.Titel;
        }

    }
}
