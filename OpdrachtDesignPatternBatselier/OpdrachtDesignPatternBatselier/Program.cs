using OpdrachtDesignPatternBatselier.Colours;
using OpdrachtDesignPatternBatselier.Shapes;
using System;

namespace OpdrachtDesignPatternBatselier
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef de vierkanten weer in verschillende kleuren");
            var vierkant = new Vierkant(new Kleur());
            vierkant.setColour("blauw");
            vierkant.toonDetails();
            vierkant.setColour("groen");
            vierkant.toonDetails();
            vierkant.setColour("rood");
            vierkant.toonDetails();

            Console.WriteLine();
            Console.WriteLine("Geef de cirkels weer in verschillende kleuren");
            var cirkel = new Cirkel(new Kleur());
            cirkel.setColour("blauw");
            cirkel.toonDetails();
            cirkel.setColour("groen");
            cirkel.toonDetails();
            cirkel.setColour("rood");
            cirkel.toonDetails();
        }
    }
}
