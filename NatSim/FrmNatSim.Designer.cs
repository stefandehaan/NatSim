namespace NatSim
{
    using System.Windows.Forms;

    partial class FrmNatSim
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
            this.pnlDeligateAanmaken = new System.Windows.Forms.Panel();
            this.txtUitvoerGetallen = new System.Windows.Forms.TextBox();
            this.btnSchrijfWijzes = new System.Windows.Forms.Button();
            this.pnlDeligateToepassing = new System.Windows.Forms.Panel();
            this.btnTerugMelding = new System.Windows.Forms.Button();
            this.lblTerugMelding = new System.Windows.Forms.Label();
            this.lblTussenResultaat = new System.Windows.Forms.Label();
            this.progressbar = new System.Windows.Forms.ProgressBar();
            this.pnlDeligateAanmaken.SuspendLayout();
            this.pnlDeligateToepassing.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDeligateAanmaken
            // 
            this.pnlDeligateAanmaken.Controls.Add(this.txtUitvoerGetallen);
            this.pnlDeligateAanmaken.Controls.Add(this.btnSchrijfWijzes);
            this.pnlDeligateAanmaken.Location = new System.Drawing.Point(22, 52);
            this.pnlDeligateAanmaken.Name = "pnlDeligateAanmaken";
            this.pnlDeligateAanmaken.Size = new System.Drawing.Size(284, 173);
            this.pnlDeligateAanmaken.TabIndex = 0;
            // 
            // txtUitvoerGetallen
            // 
            this.txtUitvoerGetallen.Location = new System.Drawing.Point(109, 17);
            this.txtUitvoerGetallen.Multiline = true;
            this.txtUitvoerGetallen.Name = "txtUitvoerGetallen";
            this.txtUitvoerGetallen.Size = new System.Drawing.Size(172, 143);
            this.txtUitvoerGetallen.TabIndex = 1;
            // 
            // btnSchrijfWijzes
            // 
            this.btnSchrijfWijzes.Location = new System.Drawing.Point(4, 39);
            this.btnSchrijfWijzes.Name = "btnSchrijfWijzes";
            this.btnSchrijfWijzes.Size = new System.Drawing.Size(99, 23);
            this.btnSchrijfWijzes.TabIndex = 0;
            this.btnSchrijfWijzes.Text = "schrijf wijzes";
            this.btnSchrijfWijzes.UseVisualStyleBackColor = true;
            this.btnSchrijfWijzes.Click += new System.EventHandler(this.btnSchrijfWijzes_Click);
            // 
            // pnlDeligateToepassing
            // 
            this.pnlDeligateToepassing.Controls.Add(this.progressbar);
            this.pnlDeligateToepassing.Controls.Add(this.lblTussenResultaat);
            this.pnlDeligateToepassing.Controls.Add(this.lblTerugMelding);
            this.pnlDeligateToepassing.Controls.Add(this.btnTerugMelding);
            this.pnlDeligateToepassing.Location = new System.Drawing.Point(22, 253);
            this.pnlDeligateToepassing.Name = "pnlDeligateToepassing";
            this.pnlDeligateToepassing.Size = new System.Drawing.Size(281, 208);
            this.pnlDeligateToepassing.TabIndex = 1;
            // 
            // btnTerugMelding
            // 
            this.btnTerugMelding.Location = new System.Drawing.Point(13, 24);
            this.btnTerugMelding.Name = "btnTerugMelding";
            this.btnTerugMelding.Size = new System.Drawing.Size(221, 23);
            this.btnTerugMelding.TabIndex = 0;
            this.btnTerugMelding.Text = "Langdurige berkening";
            this.btnTerugMelding.UseVisualStyleBackColor = true;
            this.btnTerugMelding.Click += new System.EventHandler(this.btnTerugMelding_Click);
            // 
            // lblTerugMelding
            // 
            this.lblTerugMelding.AutoSize = true;
            this.lblTerugMelding.Location = new System.Drawing.Point(10, 83);
            this.lblTerugMelding.Name = "lblTerugMelding";
            this.lblTerugMelding.Size = new System.Drawing.Size(80, 17);
            this.lblTerugMelding.TabIndex = 1;
            this.lblTerugMelding.Text = "percentage";
            // 
            // lblTussenResultaat
            // 
            this.lblTussenResultaat.AutoSize = true;
            this.lblTussenResultaat.Location = new System.Drawing.Point(10, 131);
            this.lblTussenResultaat.Name = "lblTussenResultaat";
            this.lblTussenResultaat.Size = new System.Drawing.Size(110, 17);
            this.lblTussenResultaat.TabIndex = 2;
            this.lblTussenResultaat.Text = "Tussenresultaat";
            // 
            // progressbar
            // 
            this.progressbar.Location = new System.Drawing.Point(4, 174);
            this.progressbar.Name = "progressbar";
            this.progressbar.Size = new System.Drawing.Size(264, 23);
            this.progressbar.TabIndex = 3;
            // 
            // FrmNatSim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(318, 563);
            this.Controls.Add(this.pnlDeligateToepassing);
            this.Controls.Add(this.pnlDeligateAanmaken);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNatSim";
            this.Text = "Form1";
            this.pnlDeligateAanmaken.ResumeLayout(false);
            this.pnlDeligateAanmaken.PerformLayout();
            this.pnlDeligateToepassing.ResumeLayout(false);
            this.pnlDeligateToepassing.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlDeligateAanmaken;
        private TextBox txtUitvoerGetallen;
        private Button btnSchrijfWijzes;
        private Panel pnlDeligateToepassing;
        private Button btnTerugMelding;
        private Label lblTussenResultaat;
        private Label lblTerugMelding;
        private ProgressBar progressbar;
    }
}

