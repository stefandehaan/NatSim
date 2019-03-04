using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NatSimII
{
   

    public partial class FrmNatSimII : Form
    {
         Graphics papier;
        
        public FrmNatSimII()
        {
           
            InitializeComponent();

            papier = pbWereld.CreateGraphics();

        }

        private void ResizePictureBox()
        {
            int margeBreedte = 40;
            int margeHoogte = 64;
            pbWereld.Width =
                this.Width = grbDieren.Width = grbPlanten.Width - grbPlanten.Width - margeBreedte;
            pbWereld.Height = this.Height - margeHoogte;
            papier = pbWereld.CreateGraphics();

        }

        private void ResizeLblInformatie()
        {
            int margeHoogte = 88;
            lblInformatie.Height = this.Height = margeHoogte - pnlKnoppen.Height;
        }

        private void FrmNatSim_Resicze(object sender, EventArgs e)
        {
            ResizePictureBox();
            ResizeLblInformatie();
        }

  

        private void TekenDier(Point positie)
        {
            if (this.rdbKonijn.Checked)
            {
                Konijn Konijn01 = new Konijn(positie, "Flappie", Color.Brown);
                Konijn01.Teken(this.pbWereld.CreateGraphics());
            }
            else if (this.rdbKoe.Checked)
            {
                Koe Koe01 = new Koe(positie, "Bella", Color.Black);
                Koe01.Teken(this.pbWereld.CreateGraphics());
            }
            
        }

        private void TekenPlant(Point positie)
        {
            if (this.rdbGras.Checked)
            {
                Gras gras = new Gras(positie);
                gras.Teken(this.pbWereld.CreateGraphics());
            }
            else if (this.rdbVenijnboom.Checked)
            {
                Venijnboom venijnboom = new Venijnboom(positie);
                venijnboom.Teken(this.pbWereld.CreateGraphics());
            }
        }

        private void pbWereld_Click(object sender, EventArgs e)
        {

        }
        private void pbWereld_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                TekenDier(e.Location);
            }
            else if (e.Button == MouseButtons.Right)
            {
                TekenPlant(e.Location);
            }
         
        }
    }
}
