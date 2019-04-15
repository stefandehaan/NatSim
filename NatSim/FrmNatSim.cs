using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NatSim
{

    public delegate void TerugMelding(string boodschap, long tussenresultaat, int percentage);

    public partial class FrmNatSim : Form {

        public FrmNatSim() {

            InitializeComponent();
        }

        public delegate void SchrijfDeligate(int getal);

        public void SchrijfGetal(int getal) {
            txtUitvoerGetallen.Text = txtUitvoerGetallen.Text + String.Format("Getal: {0, -12:N0}", getal) + "\r\n";
        }

        public void SchrijfGeld(int geld) {
            txtUitvoerGetallen.Text = txtUitvoerGetallen.Text + String.Format("Geld: {0:C}", geld) + "\r\n";
        }

        public void SchrijfVoorloopnullen(int getal) {
            txtUitvoerGetallen.Text = txtUitvoerGetallen.Text + String.Format("Voorloopnullen: {0:C}", getal) + "\r\n";
        }

        private void btnSchrijfWijzes_Click(object sender, EventArgs e) {
            SchrijfDeligate schrijfDeligate = SchrijfGetal;
            schrijfDeligate(10000);
            schrijfDeligate(200);

            schrijfDeligate = SchrijfGeld;
            schrijfDeligate(10000);
            schrijfDeligate(200);

            schrijfDeligate = SchrijfVoorloopnullen;
            schrijfDeligate.Invoke(10000);
            schrijfDeligate.Invoke(200);
        }

        public void Melding(string meldingenText, long totaal, int percentage) {
            lblTerugMelding.Text = meldingenText;
            lblTussenResultaat.Text = "Tussenresultaat:" + totaal.ToString();
            progressbar.Value = percentage;
            this.Refresh();
        }

        private void btnTerugMelding_Click(object sender, EventArgs e) {
            lblTerugMelding.Text = "Totaal: " + Berekeningen.LangeBerekining(Melding);
        }
    }
}
