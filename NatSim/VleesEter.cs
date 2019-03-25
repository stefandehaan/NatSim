using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatSimII {
    public abstract class VleesEter : Dier {

        public VleesEter(int verhoudingsTickJaren, string latijnseNaam, int levensduur, double gewichtMaximaal) :
            base(verhoudingsTickJaren, latijnseNaam, levensduur, gewichtMaximaal) {
        }

        public override void Eet(Leven leven) {
            if (! leven.IsPlant) {
                if (((Dier)leven).GewichtMaximaal >= this.GewichtMaximaal) {
                    SnelheidObject = SnelheidObject.Keerom();

                } else if (MaagGevuld < 100) {
                    MaagGevuld = MaagGevuld + leven.Voedingswaarde;
                    leven.Sterf();

                }

            } else {
                SnelheidObject = SnelheidObject.Keerom();
            }
        }
    }
}
