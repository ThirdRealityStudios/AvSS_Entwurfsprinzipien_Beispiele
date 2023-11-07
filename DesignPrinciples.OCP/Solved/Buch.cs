using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPrinciples.OCP.Solved
{
    public class Buch : Literatur
    {
        public Buch(string titel, string autor) : base(titel, autor)
        {
        }
    }
}
