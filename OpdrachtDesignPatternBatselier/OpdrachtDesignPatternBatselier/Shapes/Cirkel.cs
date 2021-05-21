using OpdrachtDesignPatternBatselier.Colours;

namespace OpdrachtDesignPatternBatselier.Shapes
{
    public class Cirkel : Shape
    {
        public Cirkel(Colour colour) : base(colour)
        {
            this.figuur = "cirkel";
        }

        public override void setColour(string colour)
        {
            this.colour.setColour(colour);
        }
    }
}
