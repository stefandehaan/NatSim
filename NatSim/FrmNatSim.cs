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
   

    public partial class FrmNatSim : Form
    {
        Graphics papier;

        public FrmNatSim()
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

    }
}
