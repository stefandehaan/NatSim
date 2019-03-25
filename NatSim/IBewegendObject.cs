using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace NatSimII
{
    interface IBewegendObject
    {
        // eigenschappen

        Snelheid SneleidObject { get; set; }
        Timer Clock { get; set; }

        // methoden

        Point Stap();
        Point Stap(Snelheid snelheidObject);

    }
}
