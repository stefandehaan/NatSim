using System.Collections.Generic;
using System.Drawing;
using System.Timers;
namespace NatSim
{
    public class Venijnboom
    {

        private void initClass(Point locatie)
        {
            Locatie = locatie;
            Verouder.Start();
        }

        public Venijnboom()
        {
            initClass(new Point(0, 0));
        }

        public Venijnboom(Point loactie)
        {
            initClass(loactie);
        }

        public double aantalKubiekeMetersHout;

        private Size _Afmetingen = new Size(10, 400);
        public Size Afmetingen => _Afmetingen;

        private readonly Bloeiwijze _BloeiwijzePlant = Bloeiwijze.kegel;
        public Bloeiwijze BloeiwijzePlant => _BloeiwijzePlant;

        private readonly List<string> _GeneesmiddelVoor = new List<string>() { "longkanker, borstkanker" };
        public List<string> GeneesmiddelVoor => _GeneesmiddelVoor;

        private readonly Color _Kleur = Color.ForestGreen;
        public Color Kleur => _Kleur;

        private readonly string _LatijnseNaam = "Taxus bacatta";
        public string LatijnseNaam => _LatijnseNaam;

        public int Leeftijd;

        private readonly int _Levensduur = 2200;
        public int Levensduur => _Levensduur;

        public Point Locatie;

        private readonly int _MaximaleGrootte = 20000;

        public int MaximaleGrootte => _MaximaleGrootte;

        private readonly string _NederlandseNaam = "Venijnboom";
        public string NederlandseNaam => _NederlandseNaam;

        private readonly Timer _Verouder = new Timer(1000);
        public Timer Verouder => _Verouder;
        private bool _verwijderd = false;


        private readonly bool _Verwijderd = false;
        public bool Verwijderd => _Verwijderd;

        private readonly int _Voedingswaarde;
        public int Voedingswaarde => _Voedingswaarde;

        public void Verwijder()
        {
            _verwijderd = true;
        }

        public void Teken(Graphics graphics)
        {
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
