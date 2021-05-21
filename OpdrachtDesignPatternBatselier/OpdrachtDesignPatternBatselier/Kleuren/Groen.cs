using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpdrachtDesignPatternBatselier
{
    public class Groen : IFiguur
    {
        private readonly IFiguur Figuur;
        public Groen(IFiguur figuur)
        {
            Figuur = figuur;
        }
        public string getShape()
        {
            return Figuur.getShape();
        }
        public string getKleur()
        {
            return "groen";
        }

    }
}
