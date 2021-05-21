using OpdrachtDesignPatternBatselier.Colours;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpdrachtDesignPatternBatselier.Shapes
{
    public abstract class Shape
    {
        public readonly Colour colour;
        public string figuur;

        public Shape(Colour colour)
        {
            this.colour = colour;
        }

        public void toonDetails()
        {
            colour.toonDetails(figuur, colour);
        }

        public abstract void setColour(string colour);
    }
}
