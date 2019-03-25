
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Timers;

namespace NatSimII {
    public abstract class Dier: Leven, IBewegendObject
    {

        private double _GewichtMaximaal;

        public double GewichtMaximaal { get { return this._GewichtMaximaal; } }

        public Snelheid SneleidObject { get; set; }
        public Timer Clock { get; set; }

        public int MaagGevuld;
        public Snelheid SnelheidObject;
        public int SpijsverteringsDuur;
        public List<string> WordVergiftigdDoor;
        //private int verhoudingsTickJaren;
        //private string latijnseNaam;
        //private string levensduur;
        //private double gewichtMaximaal;

        public Dier(int verhoudingTickJaren, string latijnseNaam, int levensduur, double gewichtMaximaal) {
            initDier(gewichtMaximaal);

        }

       

        private void initDier(double gewichtMaximaal) {
            this._GewichtMaximaal = gewichtMaximaal;
            this.WordVergiftigdDoor = new List<string>();
        }

        public abstract void Eet(Leven leven);
        public bool Honger() {
            return (MaagGevuld < 25);
        }


        public Point Stap()
        {
            return Stap(this.SnelheidObject);
        }
        public Point Stap(Snelheid snelheidObject)
        {
            this.SnelheidObject = snelheidObject;

            int berekendeX = Locatie.X + (SnelheidObject.X);
            int berekendeY = Locatie.Y + (SnelheidObject.Y);

            Rechthoek niewTekengebied = new Rechthoek(new Point(berekendeX, berekendeY), Tekengebied.Afmetingen);

            Vlak vlak = Rechthoek.GrensBereikt(niewTekengebied, GraphicsVenster);

            SnelheidObject = SnelheidObject.Stuiter(vlak);

            berekendeX = Locatie.X + (SnelheidObject.Y);
            berekendeY = Locatie.Y + (SnelheidObject.X);

            return new Point(berekendeX, berekendeY);

        }
    }
}
