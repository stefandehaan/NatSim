using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.

namespace NatSim
{
    public class Grafischobject
    {
        public Grafischobject()
        {
            initClass();
        }

        public Color Kleur { get; set; }
        public Color KaderKleur { get; set; }
        public Point Locatie 
        {
            get { return Tekengebied.Locatie; }
            set { Tekengebied.Locatie = value; }
        }
        public Rechthoek Tekengebied { get; set; }
        public Color Wiskleur { get; set; }
        public Rechthoek GraphicsVenster { get { return _graphicsVenster; } }
        public Guid ID { get { return _id; } }
        private Guid _id;
        private Rechthoek _graphicsVenster;
        private bool _verwijderd = false;
        private Graphics _papier;

        private void initClass()
        {
            KaderKleur = Color.Black;
            Kleur = Color.WhiteSmoke;
            Wiskleur = Color.PaleGoldenrod;

            Tekengebied = new Rechthoek();

            _id = new Guid.NewGuid();
        }

        public void Verwijder()
        {
            _verwijderd = true;
            Wis();
        }
        public void Wis()
        {
            Color oudeKleur = Kleur;
            Color oudeKaderKleur = KaderKleur;
            Kleur = Wiskleur;
            KaderKleur = Wiskleur;
            Teken();
            KaderKleur = oudeKaderKleur;
            Kleur = oudeKleur;
        }

  
    }
}
