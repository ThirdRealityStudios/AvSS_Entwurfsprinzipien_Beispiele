using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPrinciples.ISP.Solved
{
    public interface IVerleihbar : IEinsehbar
    {
        public void Ausleihen();
    }
}
