using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatSim {
    class Berekeningen {
        public static long LangeBerekining(TerugMelding terugMelding) {
            long totaal = 0;
            int grootGetal = 10_000_000;
            int eenProcent = grootGetal / 100;
            int percentage = 1;

            for (int i = 0; i <= grootGetal; i++) {
                if (i % eenProcent == 0) {
                    for (int index = 0; index < grootGetal; index++) {
                        totaal += index;
                    }

                terugMelding(percentage.ToString() + " procent bereikt", totaal, percentage);
                    if (percentage < 100)
                        percentage++;
                }
            }

            return totaal;
        }
    }
}
