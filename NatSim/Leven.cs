using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NatSimII
{
    public abstract class Leven : Grafischobject
    {
        public Leven()
        {
            initClass(1, "", int.MaxValue);
        }
        public Leven(int verhoudingTicksJaren, string latijnseNaam, int levensduur)
        {
            initClass(verhoudingTicksJaren, latijnseNaam, levensduur);
        }
        private void initClass(int verhoudingTicksJaren, string latijnseNaam, int levensduur)
        {
            VerhoudingTicksJaren = verhoudingTicksJaren;
            _latijnseNaam = latijnseNaam;
            _levensduur = levensduur;
            _verouder = new Timer();
            _verouder.Interval = _aantalTicksPerSeconde * verhoudingTicksJaren;
        }

        // interne variabelen
        private const int _aantalTicksPerSeconde = 1000;
        private string _latijnseNaam;
        private double _levensduur;
        private Timer _verouder;

        // Eigenschappen
        public int Leeftijd { get; set; }
        public int VerhoudingTicksJaren { get; set; }
        public int Voedingswaarde { get; set; }

        // ReadOnly-eigenschappen
        public string LatijnseNaam { get { return _latijnseNaam; } }
        public double Levensduur { get { return _levensduur; } }
        public string NederlandseNaam { get { return this.ToString().Split('.').Last(); } }
        public Timer Verouder { get { return _verouder; } }

        public bool IsPlant {
            get { return this.GetType().IsSubclassOf(typeof(Plant)); }
        }

        // methoden
        public void Sterf()
        {
            Verwijder();
        }
    }
}
