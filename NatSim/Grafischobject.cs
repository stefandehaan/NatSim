using System;
using System.Drawing;

namespace NatSimII
{
    public abstract class Grafischobject
    {
        public Grafischobject()
        {
            initClass();
        }

        public Color Kleur { get; set; }
        public Color KaderKleur { get; set; }
        public Point Locatie {
            get { return Tekengebied.Locatie; }
            set { Tekengebied.Locatie = value;}
        }


        public Graphics Papier {
            get { return _papier; }
            set {
                _papier = value;

                if (value != null)
                {
                    int breedteVenster = (int)Papier.VisibleClipBounds.Width;
                    int hoogteVenster = (int)Papier.VisibleClipBounds.Height;
                    _graphicsVenster = new Rechthoek(new Point(0, 0),
                                       new Size(breedteVenster, hoogteVenster));
                }
            }
        }

        public Rechthoek Tekengebied { get; set; }
        public Color Wiskleur { get; set; }

        /// <summary>
        /// ReadOnly eigenschappen
        /// </summary>
        public Rechthoek GraphicsVenster { get { return _graphicsVenster;} }

        public Guid ID => _id;
        /// <summary>
        /// variabelen
        /// </summary>
        private Guid _id;
        private Rechthoek _graphicsVenster;
        private bool _verwijderd = false;
        private Graphics _papier;
        /// <summary>
        /// methoden
        /// </summary>
        private void initClass()
        {
            KaderKleur = Color.Black;
            Kleur = Color.WhiteSmoke;
            Wiskleur = Color.PaleGoldenrod;

            //graphische instellingen:
            this.Tekengebied = new Rechthoek();

            _id = Guid.NewGuid();
        }

        public void Verwijder()
        {
            this._verwijderd = true;
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

        public void Teken(Graphics papier)
        {
            Papier = papier;

            Pen pen = new Pen(KaderKleur, 2);

            if (Papier != null)
            {
                Papier.DrawRectangle(pen, Tekengebied.ToRectangle());

                pen.Dispose();

                SolidBrush kwast = new SolidBrush(Kleur);
                Papier.FillRectangle(kwast, Tekengebied.ToRectangle());

                kwast.Dispose();
            }
        }

        public void Teken()
        {
            Teken(Papier);
        }

    }
}
