using System;
using DesignPrinciples.LSP.Problem;

namespace DesignPrinciples.LSP
{
    class Program
    {
        static void Main(string[] args)
        {
            Buch buch = new Buch("Harry Potter und der Stein der Weisen", "Joan K. Rowling", "Klaus Fritz (Übersetzer)");
            Console.WriteLine(buch.GetInfos());

            Abschlussarbeit abschlussarbeit = new Abschlussarbeit("Kriterienkatalog zur Auswahl von Cross-Plattform-Architekturen", "Fritz Fuchs");
            Console.WriteLine(abschlussarbeit.GetInfos());
            abschlussarbeit.Autoren.Add("Peter Lustig");
            Console.WriteLine(abschlussarbeit.GetInfos());

        }
    }
}
