using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpdrachtDesignPatternBatselier
{
    public class Vierkant : IFiguur
    {
        public string getShape()
        {
            return "Vierkant";
        }
        public string getKleur()
        {
            return null;
        }
    }
}
