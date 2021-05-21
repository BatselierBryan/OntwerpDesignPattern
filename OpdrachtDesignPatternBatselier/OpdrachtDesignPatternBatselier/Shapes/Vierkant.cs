using OpdrachtDesignPatternBatselier.Colours;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpdrachtDesignPatternBatselier.Shapes
{
    public class Vierkant : Shape
    {
        public Vierkant(Colour colour) : base(colour)
        {
            this.figuur = "vierkant";
        }

        public override void setColour(string colour)
        {
            this.colour.setColour(colour);
        }
    }
}
