namespace NatSimII
{
    using System.Windows.Forms;

    partial class FrmNatSimII
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbDieren = new System.Windows.Forms.GroupBox();
            this.rdbBeer = new System.Windows.Forms.RadioButton();
            this.rdbLynx = new System.Windows.Forms.RadioButton();
            this.rdbKoe = new System.Windows.Forms.RadioButton();
            this.rdbKonijn = new System.Windows.Forms.RadioButton();
            this.grbPlanten = new System.Windows.Forms.GroupBox();
            this.chbZaai = new System.Windows.Forms.CheckBox();
            this.rdbVingerhoedskruid = new System.Windows.Forms.RadioButton();
            this.rdbVenijnboom = new System.Windows.Forms.RadioButton();
            this.rdbGras = new System.Windows.Forms.RadioButton();
            this.Label1 = new System.Windows.Forms.Label();
            this.lblInformatie = new System.Windows.Forms.Label();
            this.pbWereld = new System.Windows.Forms.PictureBox();
            this.pnlKnoppen = new System.Windows.Forms.Panel();
            this.btnEinde = new System.Windows.Forms.Button();
            this.hsbSnelheid = new System.Windows.Forms.HScrollBar();
            this.label2 = new System.Windows.Forms.Label();
            this.grbDieren.SuspendLayout();
            this.grbPlanten.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbWereld)).BeginInit();
            this.pnlKnoppen.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbDieren
            // 
            this.grbDieren.BackColor = System.Drawing.Color.BurlyWood;
            this.grbDieren.Controls.Add(this.rdbBeer);
            this.grbDieren.Controls.Add(this.rdbLynx);
            this.grbDieren.Controls.Add(this.rdbKoe);
            this.grbDieren.Controls.Add(this.rdbKonijn);
            this.grbDieren.Location = new System.Drawing.Point(12, 12);
            this.grbDieren.Name = "grbDieren";
            this.grbDieren.Size = new System.Drawing.Size(119, 192);
            this.grbDieren.TabIndex = 0;
            this.grbDieren.TabStop = false;
            this.grbDieren.Text = "Dieren";
            // 
            // rdbBeer
            // 
            this.rdbBeer.AutoSize = true;
            this.rdbBeer.BackColor = System.Drawing.Color.BurlyWood;
            this.rdbBeer.Location = new System.Drawing.Point(7, 92);
            this.rdbBeer.Name = "rdbBeer";
            this.rdbBeer.Size = new System.Drawing.Size(47, 17);
            this.rdbBeer.TabIndex = 3;
            this.rdbBeer.Text = "Beer";
            this.rdbBeer.UseVisualStyleBackColor = false;
            // 
            // rdbLynx
            // 
            this.rdbLynx.AutoSize = true;
            this.rdbLynx.BackColor = System.Drawing.Color.BurlyWood;
            this.rdbLynx.Location = new System.Drawing.Point(7, 68);
            this.rdbLynx.Name = "rdbLynx";
            this.rdbLynx.Size = new System.Drawing.Size(47, 17);
            this.rdbLynx.TabIndex = 2;
            this.rdbLynx.Text = "Lynx";
            this.rdbLynx.UseVisualStyleBackColor = false;
            // 
            // rdbKoe
            // 
            this.rdbKoe.AutoSize = true;
            this.rdbKoe.BackColor = System.Drawing.Color.BurlyWood;
            this.rdbKoe.Location = new System.Drawing.Point(7, 44);
            this.rdbKoe.Name = "rdbKoe";
            this.rdbKoe.Size = new System.Drawing.Size(44, 17);
            this.rdbKoe.TabIndex = 1;
            this.rdbKoe.Text = "Koe";
            this.rdbKoe.UseVisualStyleBackColor = false;
            // 
            // rdbKonijn
            // 
            this.rdbKonijn.AutoSize = true;
            this.rdbKonijn.BackColor = System.Drawing.Color.BurlyWood;
            this.rdbKonijn.Checked = true;
            this.rdbKonijn.Location = new System.Drawing.Point(7, 20);
            this.rdbKonijn.Name = "rdbKonijn";
            this.rdbKonijn.Size = new System.Drawing.Size(54, 17);
            this.rdbKonijn.TabIndex = 0;
            this.rdbKonijn.TabStop = true;
            this.rdbKonijn.Text = "Konijn";
            this.rdbKonijn.UseVisualStyleBackColor = false;
            // 
            // grbPlanten
            // 
            this.grbPlanten.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.grbPlanten.BackColor = System.Drawing.Color.PaleGreen;
            this.grbPlanten.Controls.Add(this.chbZaai);
            this.grbPlanten.Controls.Add(this.rdbVingerhoedskruid);
            this.grbPlanten.Controls.Add(this.rdbVenijnboom);
            this.grbPlanten.Controls.Add(this.rdbGras);
            this.grbPlanten.Location = new System.Drawing.Point(12, 210);
            this.grbPlanten.Name = "grbPlanten";
            this.grbPlanten.Size = new System.Drawing.Size(119, 169);
            this.grbPlanten.TabIndex = 1;
            this.grbPlanten.TabStop = false;
            this.grbPlanten.Text = "Planten";
            // 
            // chbZaai
            // 
            this.chbZaai.AutoSize = true;
            this.chbZaai.Location = new System.Drawing.Point(62, 20);
            this.chbZaai.Name = "chbZaai";
            this.chbZaai.Size = new System.Drawing.Size(47, 17);
            this.chbZaai.TabIndex = 3;
            this.chbZaai.Text = "Zaai";
            this.chbZaai.UseVisualStyleBackColor = true;
            // 
            // rdbVingerhoedskruid
            // 
            this.rdbVingerhoedskruid.AutoSize = true;
            this.rdbVingerhoedskruid.Location = new System.Drawing.Point(6, 65);
            this.rdbVingerhoedskruid.Name = "rdbVingerhoedskruid";
            this.rdbVingerhoedskruid.Size = new System.Drawing.Size(107, 17);
            this.rdbVingerhoedskruid.TabIndex = 2;
            this.rdbVingerhoedskruid.TabStop = true;
            this.rdbVingerhoedskruid.Text = "Vingerhoedskruid";
            this.rdbVingerhoedskruid.UseVisualStyleBackColor = true;
            // 
            // rdbVenijnboom
            // 
            this.rdbVenijnboom.AutoSize = true;
            this.rdbVenijnboom.Location = new System.Drawing.Point(6, 42);
            this.rdbVenijnboom.Name = "rdbVenijnboom";
            this.rdbVenijnboom.Size = new System.Drawing.Size(80, 17);
            this.rdbVenijnboom.TabIndex = 1;
            this.rdbVenijnboom.TabStop = true;
            this.rdbVenijnboom.Text = "Venijnboom";
            this.rdbVenijnboom.UseVisualStyleBackColor = true;
            // 
            // rdbGras
            // 
            this.rdbGras.AutoSize = true;
            this.rdbGras.Location = new System.Drawing.Point(6, 19);
            this.rdbGras.Name = "rdbGras";
            this.rdbGras.Size = new System.Drawing.Size(47, 17);
            this.rdbGras.TabIndex = 0;
            this.rdbGras.TabStop = true;
            this.rdbGras.Text = "Gras";
            this.rdbGras.UseVisualStyleBackColor = true;
            // 
            // Label1
            // 
            this.Label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(505, 12);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(56, 13);
            this.Label1.TabIndex = 4;
            this.Label1.Text = "Natuurinfo";
            // 
            // lblInformatie
            // 
            this.lblInformatie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInformatie.Location = new System.Drawing.Point(483, 31);
            this.lblInformatie.Name = "lblInformatie";
            this.lblInformatie.Size = new System.Drawing.Size(103, 173);
            this.lblInformatie.TabIndex = 0;
            // 
            // pbWereld
            // 
            this.pbWereld.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbWereld.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbWereld.Location = new System.Drawing.Point(137, 12);
            this.pbWereld.Name = "pbWereld";
            this.pbWereld.Size = new System.Drawing.Size(340, 367);
            this.pbWereld.TabIndex = 6;
            this.pbWereld.TabStop = false;
            this.pbWereld.Click += new System.EventHandler(this.pbWereld_Click);
            this.pbWereld.MouseClick += new MouseEventHandler(this.pbWereld_MouseClick);
            // 
            // pnlKnoppen
            // 
            this.pnlKnoppen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlKnoppen.Controls.Add(this.btnEinde);
            this.pnlKnoppen.Controls.Add(this.hsbSnelheid);
            this.pnlKnoppen.Controls.Add(this.label2);
            this.pnlKnoppen.Location = new System.Drawing.Point(486, 210);
            this.pnlKnoppen.Name = "pnlKnoppen";
            this.pnlKnoppen.Size = new System.Drawing.Size(100, 169);
            this.pnlKnoppen.TabIndex = 0;
            // 
            // btnEinde
            // 
            this.btnEinde.Location = new System.Drawing.Point(22, 143);
            this.btnEinde.Name = "btnEinde";
            this.btnEinde.Size = new System.Drawing.Size(75, 23);
            this.btnEinde.TabIndex = 10;
            this.btnEinde.Text = "Einde";
            this.btnEinde.UseVisualStyleBackColor = true;
            // 
            // hsbSnelheid
            // 
            this.hsbSnelheid.Location = new System.Drawing.Point(22, 130);
            this.hsbSnelheid.Name = "hsbSnelheid";
            this.hsbSnelheid.Size = new System.Drawing.Size(80, 17);
            this.hsbSnelheid.TabIndex = 9;
            this.hsbSnelheid.Value = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Snelheid";
            this.label2.UseCompatibleTextRendering = true;
            // 
            // FrmNatSim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(598, 391);
            this.Controls.Add(this.pnlKnoppen);
            this.Controls.Add(this.pbWereld);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.lblInformatie);
            this.Controls.Add(this.grbPlanten);
            this.Controls.Add(this.grbDieren);
            this.Name = "FrmNatSim";
            this.Text = "Form1";
            this.grbDieren.ResumeLayout(false);
            this.grbDieren.PerformLayout();
            this.grbPlanten.ResumeLayout(false);
            this.grbPlanten.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbWereld)).EndInit();
            this.pnlKnoppen.ResumeLayout(false);
            this.pnlKnoppen.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDieren;
        private System.Windows.Forms.RadioButton rdbBeer;
        private System.Windows.Forms.RadioButton rdbLynx;
        private System.Windows.Forms.RadioButton rdbKoe;
        private System.Windows.Forms.RadioButton rdbKonijn;
        private System.Windows.Forms.GroupBox grbPlanten;
        private System.Windows.Forms.CheckBox chbZaai;
        private System.Windows.Forms.RadioButton rdbVingerhoedskruid;
        private System.Windows.Forms.RadioButton rdbVenijnboom;
        private System.Windows.Forms.RadioButton rdbGras;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label lblInformatie;
        private System.Windows.Forms.PictureBox pbWereld;
        private System.Windows.Forms.Panel pnlKnoppen;
        private System.Windows.Forms.Button btnEinde;
        private System.Windows.Forms.HScrollBar hsbSnelheid;
        private System.Windows.Forms.Label label2;
    }
}

