using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Timers;

namespace NatSimII {
    public class Vingerhoedskruid : Plant {
        private Bloeiwijze _bloeiwijzePlant;
        private string _latijnseNaam;
        private int _leeftijd = 4;
        private int verhoudingTicksJaren = 4;

        public Vingerhoedskruid() {

        }
        public Vingerhoedskruid(Point locatie) {
            initClass(locatie);
        }

        private void initClass(Point locatie) {

        }

    }
}
