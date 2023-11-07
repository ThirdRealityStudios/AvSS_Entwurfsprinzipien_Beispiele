using System;
using System.Collections.Generic;
using System.Text;
using DesignPrinciples.OCP.Problem;

namespace DesignPrinciples.OCP
{
    class Program
    {
        public static void Main()
        {
            Literatur buch = new Literatur("Harry Potter und der Stein der Weisen", "Joan K. Rowling", LiteraturTyp.Buch);
            Console.WriteLine(buch.GetInfos());

            Literatur abschlussarbeit = new Literatur("Kriterienkatalog zur Auswahl von Cross-Plattform-Architekturen", "Fritz Fuchs", LiteraturTyp.Abschlussarbeit);
            Console.WriteLine(abschlussarbeit.GetInfos());
        }
    }
}
