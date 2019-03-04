using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Timers;

namespace NatSim
{
    public class Konijn
    {

        private void initClass(Point locatie, string naam, Color kleur)
        {
            Locatie = locatie;
            Naam = naam;
            Kleur = kleur;
            Verouder.Start();
        }

        public Konijn()
        {
            initClass(new Point(0,0), "", Kleur );
        }

        public Konijn(Point locatie)
        {
            initClass(locatie, "", Kleur);
        }

        public Konijn(Point locatie, string naam, Color kleur)
        {
            initClass(locatie, naam, kleur);
        }


        private string _latijnseNaam = "Oryctolagus cuniculus";

        private string _nederlandseNaam = "Konijn";
        private double _gewichtMaximaal = 5;

        private List<string> _wordtVergeiftigdDoor =
                new List<string>() { "Venijnboom, Vingehoedskruid" };

        private string _naam = "";

        private double _gewicht = 3;
        private int _maagGevuld = 0;
        private int _voedingswaarde = 0;
        private Timer _verouder = new Timer(1000);

        private int _leeftijd = 0;
        private DateTime _geboortedatum;
        private DateTime _sterfdatum;

        private Size _afmetingen = new Size(10, 10);

        private bool _verwijderd = false;
        private Color _kleur = Color.Brown;
        private Point _locatie = new Point(0, 0);
        private int _richtingX = 0;
        private int _richtingY = 0;

        public string Naam { get { return _naam; } set { _naam = value; } }
        public int MyProperty { get; set; }

        public int Leeftijd { get { return _leeftijd; } set { _leeftijd = value; } }
        public double Gewicht { get { return _gewicht; } set { _gewicht = value; } }
        public int Voedingswaarde { get { return _voedingswaarde; } set { _voedingswaarde = value; } }
        public int MaagGevuld { get { return _maagGevuld; } set { _maagGevuld = value; } }
        public DateTime GeboorteDatum { get { return _geboortedatum; } set { _geboortedatum = value; } }
        public DateTime Sterfdatum { get { return _sterfdatum; } set { _sterfdatum = value; } }


        public Size Afmetingen { get { return _afmetingen; } set { _afmetingen = value; } }
        public Color Kleur { get { return _kleur; } set { _kleur = value; } }
        public Point Locatie { get { return _locatie; } set { _locatie = value; } }
        public int RichtingX { get { return _richtingX; } set { _richtingX = value; } }
        public int RichtingY { get { return _richtingY; } set { _richtingY = value; } }

        public string NederlandseNaam { get { return _nederlandseNaam; } }

        public readonly string LatijnseNaam;
        public readonly double GewichtMaximaal;
        public readonly int Levensduur;
        public readonly bool Verwijderd;

        public List<string> WordtVergiftigdDoor { get { return _wordtVergeiftigdDoor; } }
        public Timer Verouder { get { return _verouder; } }

        // methods

        public void Verwijder()
        {
            _verwijderd = true;
        }

        // private methods

        private bool honger()
        {
            return (MaagGevuld < 25);
        }

        private void eetGras(Gras voedsel)
        {
            if (WordtVergiftigdDoor.Contains(voedsel.NederlandseNaam))
            {
                if (honger())
                {
                    Verwijder();
                }
            }
                else if (MaagGevuld< 100) {
                MaagGevuld = MaagGevuld + voedsel.Voedingswaarde;

                if(MaagGevuld > 100) {
                    MaagGevuld = 100;
                }
                voedsel.Verwijder();
            }
        }
        private void eetVenijnBoom(Venijnboom voedsel) {
            if (WordtVergiftigdDoor.Contains(voedsel.NederlandseNaam)) {
                if (honger()) {
                    Verwijder();
                }
            } else if (MaagGevuld < 100) {
                MaagGevuld = MaagGevuld + voedsel.Voedingswaarde;

                if(MaagGevuld > 100) {
                    MaagGevuld = 100;
                }
                voedsel.Verwijder();
            }
        }

        public void Eet(object voedsel) {
            if(voedsel.GetType() == typeof(Gras)) {
                eetGras((Gras)voedsel);
            }
            else if (voedsel.GetType() == typeof(Venijnboom)) {
                eetVenijnBoom((Venijnboom)voedsel);
            }
        }

        public void Teken(Graphics graphics) {
            Pen pen = new Pen(Color.Black, 2);
            int startHoogte = Locatie.Y - Afmetingen.Height;
            graphics.DrawRectangle(pen, Locatie.X, startHoogte, Afmetingen.Width, Afmetingen.Height);

            pen.Dispose();

            SolidBrush kwast = new SolidBrush(Kleur);
            graphics.FillRectangle(kwast, Locatie.X, startHoogte, Afmetingen.Width, Afmetingen.Height);

            kwast.Dispose();
        }
    }
}
