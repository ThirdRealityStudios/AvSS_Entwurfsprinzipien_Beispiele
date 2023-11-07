using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPrinciples.ISP.Solved
{
    public interface IEinsehbar
    {
        public bool IstVerfuegbar { get; }

        public void EinsichtNehmen();
    }
}
