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
            this.progress = new System.Windows.Forms.ProgressBar();
            this.input = new System.Windows.Forms.NumericUpDown();
            this.submit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.input)).BeginInit();
            this.SuspendLayout();
            // 
            // progress
            // 
            this.progress.Location = new System.Drawing.Point(37, 105);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(227, 23);
            this.progress.TabIndex = 0;
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(37, 48);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(120, 22);
            this.input.TabIndex = 1;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(189, 48);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 2;
            this.submit.Text = "start";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // FrmNatSim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(318, 181);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.input);
            this.Controls.Add(this.progress);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNatSim";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.input)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ProgressBar progress;
        private NumericUpDown input;
        private Button submit;
    }
}

