using System;

namespace DesignPrinciples.OCP.Solved
{
    public abstract class Literatur
    {

        public string Titel { get; set; }
        public string Autor { get; set; }

        public Literatur(string titel, string autor)
        {
            Titel = titel;
            Autor = autor;
        }

        public virtual string GetInfos()
        {
            return string.Format("{0}: {1}", Autor, Titel);
        }


    }
}
