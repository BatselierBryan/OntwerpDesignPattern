using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpdrachtDesignPatternBatselier.Figuren
{
    public class Cirkel : IFiguur
    {
        public string getShape()
        {
            return "Cirkel";
        }
        public string getKleur()
        {
            return null;
        }
    }
}
