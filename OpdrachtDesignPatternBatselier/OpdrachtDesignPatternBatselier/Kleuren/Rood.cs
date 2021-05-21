using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpdrachtDesignPatternBatselier
{
    public class Rood : IFiguur
    {
        private readonly IFiguur Figuur;
        public Rood (IFiguur figuur)
        {
            Figuur = figuur;
        }
        public string getShape()
        {
            return Figuur.getShape();
        }
        public string getKleur()
        {
            return "rood";
        }

    }
}
