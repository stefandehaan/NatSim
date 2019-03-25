using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Timers;

namespace NatSimII
{
    public class Konijn : Planteneter
    {

        private void initClass(Point locatie, string naam, Color kleur)
        {
            Locatie = locatie;
            Naam = naam;
            Kleur = kleur;
            Tekengebied.Afmetingen = new Size(10, 10);

            WordVergiftigdDoor.Add("Vingerhoedskruid");
            WordVergiftigdDoor.Add("Venijnboom");

            Gewicht = 5;
            Voedingswaarde = 1;
        }

        public Konijn() : base(_verhoudingsTickJaren, _latijnseNaam, _leeftijd, _gewichtMaximaal) {

            initClass(new Point(0,0), "", Kleur );
        }

        public Konijn(Point locatie) : base(_verhoudingsTickJaren, _latijnseNaam, _leeftijd, _gewichtMaximaal) { 
            initClass(locatie, "", Kleur);
        }

        public Konijn(Point locatie, string naam, Color kleur) : base(_verhoudingsTickJaren, _latijnseNaam, _leeftijd, _gewichtMaximaal) { 

            initClass(locatie, naam, kleur);
        }


        private const int _leeftijd = 9;
        private const int _verhoudingsTickJaren = 1;

        private const string _latijnseNaam = "Oryctolagus cuniculus";
        private const double _gewichtMaximaal = 10;

        private string _nederlandseNaam = "Konijn";

        private List<string> _wordtVergeiftigdDoor =
                new List<string>() { "Venijnboom, Vingehoedskruid" };

        private string _naam = "";
        private double _gewicht = 3;
        private DateTime _sterfdatum;
        private DateTime _geboortedatum;


        public string Naam { get { return _naam; } set { _naam = value; } }
        public double Gewicht { get { return _gewicht; } set { _gewicht = value; } }
        public DateTime Sterfdatum { get { return _sterfdatum; } set { _sterfdatum = value; } }
        public DateTime GeboorteDatum { get { return _geboortedatum; } set { _geboortedatum = value; } }
    }
}
