using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpdrachtDesignPatternBatselier.Colours
{
    public abstract class Colour
    {
        public string colour;

        public abstract void toonDetails(string shape, Colour colour);
        public abstract void setColour(string colour);
    }
}
