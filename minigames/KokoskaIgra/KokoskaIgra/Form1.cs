using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KokoskaIgra
{
    public partial class Form1 : Form
    {

        bool idiLijevo, idiDesno;

        int brzina = 8;
        int rezultat = 0;
        int broj_promasenih = 0;

        Random rndX = new Random();
        Random rndY = new Random();

        PictureBox razbijenoSlika = new PictureBox();

        public Form1()
        {
            InitializeComponent();
            RestartujIgru();
        }

        private void TimerEvent(object sender, EventArgs e)
        {
            labelRezultat.Text = "Rezultat: " + rezultat;
            labelPromaseno.Text = "Promašeno: " + broj_promasenih;

            if(idiLijevo == true && igrac.Left > 0)
            {
                igrac.Left -= 12;
                igrac.Image = Properties.Resources.chicken_normal2;
            }

            if(idiDesno == true && igrac.Left + igrac.Width < ClientSize.Width)
            {
                igrac.Left += 12;
                igrac.Image = Properties.Resources.chicken_normal;
            }

            foreach( Control X in this.Controls )
            {
                 if (X is PictureBox && (string)X.Tag == "eggs") 
                {
                   
                    X.Top += brzina;
 
                   
                    if (X.Top + X.Height > this.ClientSize.Height)
                    {
                       
                        razbijenoSlika.Image = Properties.Resources.splash; 
                        razbijenoSlika.Location = X.Location;
                        razbijenoSlika.Height = 59;
                        razbijenoSlika.Width = 60; 
                        razbijenoSlika.BackColor = System.Drawing.Color.Transparent;
 
                        this.Controls.Add(razbijenoSlika);
 
                        X.Top = rndY.Next(80, 300) * -1;
                        X.Left = rndX.Next(5, this.ClientSize.Width - X.Width);
                        broj_promasenih++; 
                        igrac.Image = Properties.Resources.chicken_hurt;
                    }
 
                   
                    if (X.Bounds.IntersectsWith(igrac.Bounds))
                    {
                        X.Top = rndY.Next(100, 300) * -1; 
                        X.Left = rndX.Next(5, this.ClientSize.Width - X.Width); 
                        rezultat++; 
                    }
 
                  
                    if (rezultat >= 20)
                    {
                        brzina = 16;
                    }
 
                  
                    if (broj_promasenih > 5)
                    {
                        timer1.Stop();
                        MessageBox.Show("Igra je gotova!!" + "\r\n" + "Klikni OK za novu igru.");
                        
                       RestartujIgru();
                    }
 
                }

            }

        }

        private void TastaturaDugmeDole(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                idiLijevo = true;
            }
            
            if(e.KeyCode == Keys.Right)
            {
                idiDesno = true;
            }
        }

        private void TastaturaDugmeGore(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                idiLijevo = false;
            }
            
            if(e.KeyCode == Keys.Right)
            {
                idiDesno = false;
            }

        }

        private void RestartujIgru()
        {
            foreach(Control x in this.Controls)
            {
                if(x is PictureBox && (string)x.Tag == "eggs")
                {
                    x.Top = rndY.Next(80,300) * -1;
                    x.Left = rndX.Next(5, this.ClientSize.Width - x.Width);
                }

            }

            igrac.Left = this.ClientSize.Width/2;
            igrac.Image = Properties.Resources.chicken_normal;

            rezultat = 0;
            broj_promasenih = 0;
            brzina = 8;

            idiLijevo = false;
            idiDesno = false;
            timer1.Start();
            
        }


    }
}
