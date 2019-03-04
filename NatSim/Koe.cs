using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Timers;

namespace NatSimII
{
    public class Koe
    {

        private void initClass(Point locatie, string naam, Color kleur)
        {
            Locatie = locatie;
            Naam = naam;
            Kleur = kleur;
            Verouder.Start();
        }

        public Koe()
        {
            initClass(new Point(0, 0), "", Kleur);
        }

        public Koe(Point locatie)
        {
            initClass(locatie, "", Kleur);
        }

        public Koe(Point locatie, string naam, Color kleur)
        {
            initClass(locatie, naam, kleur);
        }

        public string Naam { get; set; }
        public DateTime Geboortedatum { get; set; }
        public double Gewicht { get; set; }
        public int Leeftijd { get; set; }
        public int MaagGevuld { get; set; }
        public DateTime Sterfdatum { get; set; }
        public Color kleur { get; set; }
        public Point Locatie { get; set; }
        public int RichtingX { get; set; }
        public int RichtingY { get; set; }


        private Size _afmetingen = new Size(80, 40);
        private double _gewichtMaximaal = 450;
        private List<string> _wordtVergeiftigdDoor =
                new List<string>() { "Venijnboom, Vingehoedskruid" };

        private string _latijnseNaam = "Bos taurus";
        private int _levensduur = 25;
        private string _nederlandseNaam = "Koe";
        private Timer _verouder = new Timer();
        private bool _verwijderd = false;
        private Color _kleur = Color.Brown;


        public Size Afmetingen { get { return _afmetingen; } }
        public double GewichtMaximaal { get { return _gewichtMaximaal; } }
        public List<string> WordtVergiftigdDoor { get { return _wordtVergeiftigdDoor; } }
        public string LatijnseNaam { get { return _latijnseNaam; } }
        public int Levensduur { get { return _levensduur; } }
        public string NederlandseNaam { get { return _nederlandseNaam; } }
        public Timer Verouder { get { return _verouder; } }
        public bool Verwijderd { get { return _verwijderd; } }
        public Color Kleur { get { return _kleur; } set { _kleur = value; } }

        // methods

        public void Verwijder() {
            _verwijderd = true;
        }

        // private methods

        private bool honger() {
            return (MaagGevuld < 25);
        }

        private void eetGras(Gras voedsel) {
            if (WordtVergiftigdDoor.Contains(voedsel.NederlandseNaam)) {
                if (honger()) {
                    Verwijder();
                }
            }
            else if (MaagGevuld < 100) {
                MaagGevuld = MaagGevuld + voedsel.Voedingswaarde;

                if (MaagGevuld > 100) {
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
            }
            else if (MaagGevuld < 100) {
                MaagGevuld = MaagGevuld + voedsel.Voedingswaarde;

                if (MaagGevuld > 100) {
                    MaagGevuld = 100;
                }
                voedsel.Verwijder();
            }
        }

        public void Eet(object voedsel) {
            if (voedsel.GetType() == typeof(Gras)) {
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
