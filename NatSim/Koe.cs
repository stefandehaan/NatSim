using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Timers;

namespace NatSim
{
    public class Koe
    {
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
        private List<string> _wordtVergeiftigdDoor =
                new List<string>() { "Venijnboom, Vingehoedskruid" };
        private string _latijnseNaam = "Bos taurus";
        private int _levensduur = 25;
        private Timer _verouder = new Timer();
        private bool _verwijderd = false;

        public Size Afmetingen { get { return _afmetingen; } }
        private double _gewichtMaximaal = 450;

        public double GewichtMaximaal {
            get { return _gewichtMaximaal; }
        }

        public int MyProperty { get; private set; }

    }
}
