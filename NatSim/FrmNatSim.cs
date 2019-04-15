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
    public delegate void Callback(int progress);

    public partial class FrmNatSim : Form {
        Timer current = null;

        public FrmNatSim() {

            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e) {
            this.setTimer(this.tracker);
        }

        private void tracker(int process) {
            this.progress.Value = process;
            if (process == 80)
                this.BackColor = Color.Orange;

            if (process == 90)
                this.BackColor = Color.Red;

            if (process == 100)
                this.current.Stop();
        }

        private void setTimer(Callback callback) {

            void ticker(object sender, EventArgs e) {
                callback(this.progress.Value + 1);
            }

            Timer timer = new Timer();
            timer.Tick += new EventHandler(ticker);
            timer.Interval = (int)Math.Ceiling((this.input.Value * 60_000) / 100);
            timer.Start();
            this.current = timer;
        }
    }
}
