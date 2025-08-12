
namespace AvioniApp
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.igrac = new System.Windows.Forms.PictureBox();
            this.metak = new System.Windows.Forms.PictureBox();
            this.neprijatelj3 = new System.Windows.Forms.PictureBox();
            this.neprijatelj2 = new System.Windows.Forms.PictureBox();
            this.neprijatelj1 = new System.Windows.Forms.PictureBox();
            this.labelRezultat = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.igrac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.neprijatelj3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.neprijatelj2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.neprijatelj1)).BeginInit();
            this.SuspendLayout();
            // 
            // igrac
            // 
            this.igrac.Image = global::AvioniApp.Properties.Resources.igrac;
            this.igrac.Location = new System.Drawing.Point(282, 399);
            this.igrac.Name = "igrac";
            this.igrac.Size = new System.Drawing.Size(100, 100);
            this.igrac.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.igrac.TabIndex = 4;
            this.igrac.TabStop = false;
            // 
            // metak
            // 
            this.metak.Image = global::AvioniApp.Properties.Resources.metak;
            this.metak.Location = new System.Drawing.Point(316, 351);
            this.metak.Name = "metak";
            this.metak.Size = new System.Drawing.Size(25, 25);
            this.metak.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.metak.TabIndex = 3;
            this.metak.TabStop = false;
            // 
            // neprijatelj3
            // 
            this.neprijatelj3.Image = global::AvioniApp.Properties.Resources.neprijatelj;
            this.neprijatelj3.Location = new System.Drawing.Point(469, 36);
            this.neprijatelj3.Name = "neprijatelj3";
            this.neprijatelj3.Size = new System.Drawing.Size(100, 100);
            this.neprijatelj3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.neprijatelj3.TabIndex = 2;
            this.neprijatelj3.TabStop = false;
            // 
            // neprijatelj2
            // 
            this.neprijatelj2.Image = global::AvioniApp.Properties.Resources.neprijatelj;
            this.neprijatelj2.Location = new System.Drawing.Point(282, 36);
            this.neprijatelj2.Name = "neprijatelj2";
            this.neprijatelj2.Size = new System.Drawing.Size(100, 100);
            this.neprijatelj2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.neprijatelj2.TabIndex = 1;
            this.neprijatelj2.TabStop = false;
            // 
            // neprijatelj1
            // 
            this.neprijatelj1.Image = global::AvioniApp.Properties.Resources.neprijatelj;
            this.neprijatelj1.Location = new System.Drawing.Point(84, 36);
            this.neprijatelj1.Name = "neprijatelj1";
            this.neprijatelj1.Size = new System.Drawing.Size(100, 100);
            this.neprijatelj1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.neprijatelj1.TabIndex = 0;
            this.neprijatelj1.TabStop = false;
            // 
            // labelRezultat
            // 
            this.labelRezultat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRezultat.Location = new System.Drawing.Point(1, 188);
            this.labelRezultat.Name = "labelRezultat";
            this.labelRezultat.Size = new System.Drawing.Size(662, 100);
            this.labelRezultat.TabIndex = 5;
            this.labelRezultat.Text = "0";
            this.labelRezultat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.TimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(188)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(662, 498);
            this.Controls.Add(this.igrac);
            this.Controls.Add(this.metak);
            this.Controls.Add(this.neprijatelj3);
            this.Controls.Add(this.neprijatelj2);
            this.Controls.Add(this.neprijatelj1);
            this.Controls.Add(this.labelRezultat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Avioni ";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TastaturaDugmeDole);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TastaturaDugmeGore);
            ((System.ComponentModel.ISupportInitialize)(this.igrac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.neprijatelj3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.neprijatelj2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.neprijatelj1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox neprijatelj1;
        private System.Windows.Forms.PictureBox neprijatelj2;
        private System.Windows.Forms.PictureBox neprijatelj3;
        private System.Windows.Forms.PictureBox metak;
        private System.Windows.Forms.PictureBox igrac;
        private System.Windows.Forms.Label labelRezultat;
        private System.Windows.Forms.Timer timer1;
    }
}

