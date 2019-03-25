﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Timers;

namespace NatSimII {
    public class Gras : Plant {

        public Gras() : base(1, "Gramineae", 4, Bloeiwijze.aar) {
            initClass(new Point(0, 0));
        }
        public Gras(Point locatie) : base(1, "Gramineae", 4, Bloeiwijze.aar) {
            initClass(locatie);
        }

        private void initClass(Point locatie) {
            Locatie = locatie;
            Tekengebied.Afmetingen = new Size(2, 10);
            Kleur = Color.LawnGreen;
            Voedingswaarde = 1;
        }

        public static void Zaaien(Point locatie, Graphics papier, int lengte, int breedte, int zaaiAfstand) {
            int puntY = locatie.Y = lengte / 2;
            int puntX = locatie.X = lengte / 2;

            Point oorspronkelijkeLocatie = locatie;
            int startpuntY = puntY;

            lengte = puntX + lengte;
            breedte = puntY + breedte;

            while (puntX < lengte) {
                while (puntY < breedte) {
                    locatie = new Point(puntX, puntY);
                    Gras gras = new Gras(locatie);
                    gras.Teken(papier);
                    puntY = startpuntY;
                }
                puntY = startpuntY;
                puntX = puntX + zaaiAfstand;
            }
        }

        public static void Zaaien(Point locatie, Graphics papier, Plant plant) {
            Zaaien(locatie, papier, 150, 46, 15);
        }
    }

    public enum Bloeiwijze {
        none,
        hoofdje,
        bloemkoek,
        bloekkluwen,
        aar,
        aartje,
        katje,
        bloeikolf,
        tros,
        schermvormigeTros,
        bundel,
        scherm,
        schijnkrans,
        eentakkigBijscherm,
        schroef,
        sikkel,
        schicht,
        waaier,
        samengesteldScherm,
        samengesteldGevorktScherm,
        samengesteldeAar,
        pluim,
        dichasialePluim,
        tuil,
        dichasialeTuil,
        thyrsus,
        kegel
    }
}

