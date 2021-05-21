using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpdrachtDesignPatternBatselier.Colours
{
    public class Kleur : Colour
    {
        public override void setColour(string colour)
        {
            this.colour = colour;
        }

        public override void toonDetails(string shape, Colour colour)
        {
            Console.WriteLine($"Ik teken een {shape} in het {colour.colour}");
        }
    }
}
