using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPrinciples.ISP.Problem
{
    public interface IAusleihe
    {
        public bool IstVerfuegbar { get; }

        public void Ausleihen();

        public void EinsichtNehmen();
    }
}
