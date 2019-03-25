
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace NatSimII {
    public abstract class Dier: Leven {

        private double _GewichtMaximaal;

        public double GewichtMaximaal { get { return this._GewichtMaximaal; } }

        public int MaagGevuld;
        public Snelheid SnelheidObject;
        public int SpijsverteringsDuur;
        public List<string> WordVergiftigdDoor;
        private int verhoudingsTickJaren;
        private string latijnseNaam;
        private string levensduur;
        private double gewichtMaximaal;

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
    }
}
