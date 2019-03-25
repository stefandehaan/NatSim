using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Timers;

namespace NatSimII
{
    public class Koe: Planteneter
    {

        private void initClass(Point locatie, string naam, Color kleur)
        {
            Locatie = locatie;
            Naam = naam;
            Kleur = kleur;
            Verouder.Start();
        }

        public Koe() : base(_verhoudingsTickJaren, _latijnseNaam, _leeftijd, _gewichtMaximaal) {
            initClass(new Point(0, 0), "", Kleur);
        }

        public Koe(Point locatie) : base(_verhoudingsTickJaren, _latijnseNaam, _leeftijd, _gewichtMaximaal) {
            initClass(locatie, "", Kleur);
        }

        public Koe(Point locatie, string naam, Color kleur) : base(_verhoudingsTickJaren, _latijnseNaam, _leeftijd, _gewichtMaximaal) {
            initClass(locatie, naam, kleur);
        }

        public string Naam { get; set; }
        public double Gewicht { get; set; }
        public string AantalLitersMelk { get; set; }

        public DateTime Geboortedatum { get; set; }
        public DateTime Sterfdatum { get; set; }


        private List<string> _wordtVergeiftigdDoor =
                new List<string>() { "Venijnboom, Vingehoedskruid" };

        private const int _leeftijd = 25;
        private const int _verhoudingsTickJaren = 1;
        private const string _latijnseNaam = "Bos taurus";
        private const double _gewichtMaximaal = 800;
    }
}
