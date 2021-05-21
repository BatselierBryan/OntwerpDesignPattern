using OpdrachtDesignPatternBatselier.Figuren;
using System;

namespace OpdrachtDesignPatternBatselier
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaratie vierkanten met verschillende kleuren + console.writeline ervan
            IFiguur rodeVierkant = new Rood(new Vierkant());
            IFiguur groeneVierkant = new Groen(new Vierkant());
            IFiguur blauweVierkant = new Blauw(new Vierkant());

            Console.WriteLine($"Ik teken een {rodeVierkant.getShape()} in het {rodeVierkant.getKleur()}");
            Console.WriteLine($"Ik teken een {groeneVierkant.getShape()} in het {groeneVierkant.getKleur()}");
            Console.WriteLine($"Ik teken een {blauweVierkant.getShape()} in het {blauweVierkant.getKleur()}");

            //Declaratie cirkels met verschillende kleuren + console.writeline ervan
            IFiguur rodeCirkel = new Rood(new Cirkel());
            IFiguur groeneCirkel = new Groen(new Cirkel());
            IFiguur blauweCirkel = new Blauw(new Cirkel());

            Console.WriteLine($"Ik teken een {rodeCirkel.getShape()} in het {rodeCirkel.getKleur()}");
            Console.WriteLine($"Ik teken een {groeneCirkel.getShape()} in het {groeneCirkel.getKleur()}");
            Console.WriteLine($"Ik teken een {blauweCirkel.getShape()} in het {blauweCirkel.getKleur()}");
        }
    }
}
