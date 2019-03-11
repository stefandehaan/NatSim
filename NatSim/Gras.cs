using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace NatSimII
{
    class Gras : Plant
    {

        public Gras(): base(1, "Gramineae", 4, Bloeiwijze.aar)
        {
            initClass(new Point(0, 0));
        }
        public Gras(Point locatie): base(1, "Gramineae", 4, Bloeiwijze.aar)
        {
            initClass(locatie);
        }

        private void initClass(Point locatie)
        {
            Locatie = locatie;
            Tekengebied.Afmetingen = new Size(2, 10);
            Kleur = Color.LawnGreen;
            Voedingswaarde = 1;
        }

        private void Zaaien(Point locatie, Graphics papier, int lengte, int breedte, int zaaiAfstand)
        {
            int puntY = locatie.Y = lengte / 2;
            int puntX = locatie.X = lengte / 2;

            Point oorspronkelijkeLocatie = locatie;
            int startpuntY = puntY;

            lengte = puntX + lengte;
            breedte = puntY + breedte;

            while (puntX < lengte)
            {
                while (puntY < breedte)
                {
                    locatie = new Point(puntX, puntY);
                    Gras gras = new Gras(locatie);
                    gras.Teken(papier);
                    puntY = startpuntY;                    
                }
                puntY = startpuntY;
                puntX = puntX + zaaiAfstand; 
            }
        }

        public static void Zaaien(Point locatie, Graphics papier, Plant plant)
        {
            Zaaien(locatie, papier, 150, 46, 15);
        }

        #region test
        private void initClass(Point locatie)
        {
            Locatie = locatie;
            Verouder.Start();
        }

        public Gras(Color kleur)
        {
            initClass(new Point(0, 0));
        }

        public Gras(Point loactie)
        {
            initClass(loactie);
        }

        public double aantalKubiekeMetersHout;

        private Size _Afmetingen = new Size(10, 400);
        public Size Afmetingen { get { return _Afmetingen; } }

        private Bloeiwijze _BloeiwijzePlant = Bloeiwijze.kegel;
        public Bloeiwijze BloeiwijzePlant { get { return _BloeiwijzePlant; } }

        private List<string> _GeneesmiddelVoor = new List<string>() { "longkanker,borstkanker" };
        public List<string> GeneesmiddelVoor { get { return _GeneesmiddelVoor; } }

        private Color _Kleur = Color.ForestGreen;
        public Color Kleur
        {
            get { return _Kleur; }
            set => this._Kleur = value;
        }

        private string _LatijnseNaam = "Taxus bacatta";
        public string LatijnseNaam { get { return _LatijnseNaam; } }

        public int Leeftijd;

        private int _Levensduur = 2200;
        public int Levensduur { get { return _Levensduur; } }

        public Point Locatie;

        private int _MaximaleGrootte = 20000;

        public int MaximaleGrootte { get { return _MaximaleGrootte; } }

        private string _NederlandseNaam = "Venijnboom";
        public string NederlandseNaam { get { return _NederlandseNaam; } }

        private Timer _Verouder = new Timer(1000);
        public Timer Verouder { get { return _Verouder; } }
        private bool _verwijderd = false;


        private bool _Verwijderd = false;
        public bool Verwijderd { get { return _Verwijderd; } }

        private int _Voedingswaarde;
        public int Voedingswaarde { get { return _Voedingswaarde; } }

        public void Verwijder() {
            _verwijderd = true;
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

#endregion

 enum Bloeiwijze
    {
        none,
        hoofdje,
        bloemkoek,
        bloekkluwen,
        aar,
        aartje,
        katje,
        bloeikolf,
        tros,
        schermvormigeTros,
        bundel,
        scherm,
        schijnkrans,
        eentakkigBijscherm,
        schroef,
        sikkel,
        schicht,
        waaier,
        samengesteldScherm,
        samengesteldGevorktScherm,
        samengesteldeAar,
        pluim,
        dichasialePluim,
        tuil,
        dichasialeTuil,
        thyrsus,
        kegel
    }

