using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace NatSimII {

    enum Vlak {
        Horizontaal,
        Verticaal,
        Hoek,
        Geen,
    }

    struct Snelheid {

        public int X;
        public int Y;

        public Snelheid(int x, int y): this() {
            this.X = x;
            this.Y = y;

        }

        public Snelheid Keerom() {
            X = -1 * this.X;
            Y = -1 * this.Y;

            return new Snelheid(X, Y);
        }

        public Snelheid Stuiter(Vlak vlak) {
            switch (vlak) {
                case Vlak.Horizontaal:
                    Y = -1 * this.Y;
                    break;

                case Vlak.Verticaal:
                    X = -1 * this.X;
                    break;

                case Vlak.Hoek:
                    X = -1 * this.X;
                    Y = -1 * this.Y;
                    break;
            }

            return new Snelheid(X, Y);
        }
    }
}
