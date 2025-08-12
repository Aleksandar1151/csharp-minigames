
namespace KokoskaIgra
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.igrac = new System.Windows.Forms.PictureBox();
            this.labelRezultat = new System.Windows.Forms.Label();
            this.labelPromaseno = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.igrac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::KokoskaIgra.Properties.Resources.egg;
            this.pictureBox1.Location = new System.Drawing.Point(64, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "eggs";
            // 
            // igrac
            // 
            this.igrac.BackColor = System.Drawing.Color.Transparent;
            this.igrac.Image = global::KokoskaIgra.Properties.Resources.chicken_normal;
            this.igrac.Location = new System.Drawing.Point(192, 418);
            this.igrac.Name = "igrac";
            this.igrac.Size = new System.Drawing.Size(100, 100);
            this.igrac.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.igrac.TabIndex = 3;
            this.igrac.TabStop = false;
            // 
            // labelRezultat
            // 
            this.labelRezultat.BackColor = System.Drawing.Color.Transparent;
            this.labelRezultat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRezultat.ForeColor = System.Drawing.Color.Black;
            this.labelRezultat.Location = new System.Drawing.Point(12, 9);
            this.labelRezultat.Name = "labelRezultat";
            this.labelRezultat.Size = new System.Drawing.Size(153, 23);
            this.labelRezultat.TabIndex = 4;
            this.labelRezultat.Text = "Rezultat: 0";
            // 
            // labelPromaseno
            // 
            this.labelPromaseno.BackColor = System.Drawing.Color.Transparent;
            this.labelPromaseno.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPromaseno.ForeColor = System.Drawing.Color.Black;
            this.labelPromaseno.Location = new System.Drawing.Point(287, 9);
            this.labelPromaseno.Name = "labelPromaseno";
            this.labelPromaseno.Size = new System.Drawing.Size(185, 23);
            this.labelPromaseno.TabIndex = 5;
            this.labelPromaseno.Text = "Promašeno: 0";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::KokoskaIgra.Properties.Resources.egg;
            this.pictureBox5.Location = new System.Drawing.Point(214, 85);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(40, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 6;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "eggs";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = global::KokoskaIgra.Properties.Resources.egg;
            this.pictureBox6.Location = new System.Drawing.Point(365, 85);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(40, 50);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 7;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Tag = "eggs";
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
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(196)))), ((int)(((byte)(106)))));
            this.BackgroundImage = global::KokoskaIgra.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(484, 511);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.labelPromaseno);
            this.Controls.Add(this.labelRezultat);
            this.Controls.Add(this.igrac);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kokoška i jaje";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TastaturaDugmeDole);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TastaturaDugmeGore);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.igrac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox igrac;
        private System.Windows.Forms.Label labelRezultat;
        private System.Windows.Forms.Label labelPromaseno;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Timer timer1;
    }
}

