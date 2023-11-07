using System;

namespace DesignPrinciples.OCP.Problem
{
    public enum LiteraturTyp
    {
        Abschlussarbeit,
        Buch,
        Sammelband,
    }

    public class Literatur
    {

        public string Titel { get; set; }
        public string Autor { get; set; }
        public LiteraturTyp Typ { get; private set; }

        public Literatur(string titel, string autor, LiteraturTyp typ)
        {
            Titel = titel;
            Autor = autor;
            Typ = typ;
        }

        public string GetInfos()
        {
            switch (Typ)
            {
                //case LiteraturTyp.Sammelband:
                //    return String.Format("{0} (Hrsg.): {1}", this.Autor, this.Titel);
                case LiteraturTyp.Abschlussarbeit:
                    return string.Format("{0}: {1} (Thesis)", Autor, Titel);
                case LiteraturTyp.Buch:
                default:
                    return string.Format("{0}: {1}", Autor, Titel);
            }
        }


    }
}
