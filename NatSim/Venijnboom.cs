﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Timers;
namespace NatSim
{
    public class Venijnboom {
        public double aantalKubiekeMetersHout;

        private Size _Afmetingen = new Size(10, 400);
        public Size Afmetingen { get { return _Afmetingen; } }

        private Bloeiwijze _BloeiwijzePlant = Bloeiwijze.kegel;
        public Bloeiwijze BloeiwijzePlant { get { return _BloeiwijzePlant; } }

        private List<string> _GeneesmiddelVoor = new List<string>(){"longkanker,borstkanker"};
        public List<string> GeneesmiddelVoor { get { return _GeneesmiddelVoor; } }

        private Color _Kleur = Color.ForestGreen;
        public Color Kleur { get { return _Kleur; } }

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
        public Timer Verouder {  get { return _Verouder; } }


        private bool _Verwijderd = false;
        public bool Verwijderd { get { return _Verwijderd;  } }

        private int _Voedingswaarde;
        public int Voedingswaarde { get { return _Voedingswaarde; } }
    }
}
