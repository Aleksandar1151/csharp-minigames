using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AvioniApp
{
    public partial class Form1 : Form
    {
        bool idiLijevo, idiDesno, pucanje, igraGotova;
        int rezultat;
        int brzinaIgraca = 15;
        int brzinaNeprijatelja;
        int brzinaMetka = 20;
        Random rnd = new Random();

        int crvena;
        int zelena;
        int plava;
        

        public Form1()
        {
            InitializeComponent();
            RestartujIgru();
        }

        private void TimerEvent(object sender, EventArgs e)
        {
            labelRezultat.Text = rezultat.ToString();

            neprijatelj1.Top += brzinaNeprijatelja;
            neprijatelj2.Top += brzinaNeprijatelja;
            neprijatelj3.Top += brzinaNeprijatelja;


            if(neprijatelj1.Top > 530 || neprijatelj2.Top > 530 || neprijatelj3.Top > 530)
            {
                IgraZavrsena();
            }

            if(idiLijevo == true && igrac.Left > 23)
            {
                igrac.Left -= brzinaIgraca;
            }

            if(idiDesno == true && igrac.Left < 550)
            {
                igrac.Left += brzinaIgraca;
            }

            if(pucanje == true)
            {
               
                metak.Top -= brzinaMetka;
            }
            else
            {
                metak.Left = -300;
               
            }

            if(metak.Top < 0)
            {
                pucanje = false;
            }

            if(metak.Bounds.IntersectsWith(neprijatelj1.Bounds))
            {
                rezultat += 1;
                neprijatelj1.Top = -450;
                neprijatelj1.Left = rnd.Next(20,600);
                pucanje = false;

               PromjenaBrzineIgre();
            }

            if(metak.Bounds.IntersectsWith(neprijatelj2.Bounds))
            {
                rezultat += 1;
                neprijatelj2.Top = -650;
                neprijatelj2.Left = rnd.Next(20,600);
                pucanje = false;

                PromjenaBrzineIgre();
            }

            if(metak.Bounds.IntersectsWith(neprijatelj3.Bounds))
            {
                rezultat += 1;
                neprijatelj3.Top = -750;
                neprijatelj3.Left = rnd.Next(20,600);
                pucanje = false;
                PromjenaBrzineIgre();
               
            }

            
        }

        private void PromjenaBrzineIgre()
        {
             if(rezultat != 0 && rezultat % 5 == 0)
             {
                brzinaNeprijatelja += 1;
                brzinaMetka+=5;
                brzinaIgraca+=3;


                
                crvena -= 20;
                zelena -= 20;
                plava -=  20;

                if(crvena<0) crvena = 0;
                if(zelena<0) zelena = 0;
                if(plava<0) plava = 0;

                if(plava<120) labelRezultat.ForeColor = Color.Yellow;

                BackColor = Color.FromArgb(crvena,zelena,plava);
             }
             
        }

        private void TastaturaDugmeDole(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left )
            {
                idiLijevo = true;
            }
            if(e.KeyCode == Keys.Right )
            {
                idiDesno = true;
            }
        }

        private void TastaturaDugmeGore(object sender, KeyEventArgs e)
        {
             if(e.KeyCode == Keys.Left )
            {
                idiLijevo = false;
            }
            if(e.KeyCode == Keys.Right )
            {
                idiDesno = false;
            }
            if(e.KeyCode == Keys.Space && pucanje == false)
            {
                pucanje = true;

                metak.Top = igrac.Top +30;
                metak.Left = igrac.Left + (igrac.Width/2);
            }

            if(e.KeyCode == Keys.Enter && igraGotova == true)
            {
                RestartujIgru();
            }
        }

        private void RestartujIgru()
        {
            timer1.Start();
            brzinaNeprijatelja = 5;
            brzinaIgraca =12;

            neprijatelj1.Left = rnd.Next(20,500);
            neprijatelj2.Left = rnd.Next(20,500);
            neprijatelj3.Left = rnd.Next(20,500);

            neprijatelj1.Top = rnd.Next(20,200) * -1 ;
            neprijatelj2.Top = rnd.Next(20,500) * -1 ;
            neprijatelj3.Top = rnd.Next(20,900) * -1;

            rezultat = 0;
            brzinaMetka = 20;
            metak.Left = -300;

            labelRezultat.Text = rezultat.ToString();
            pucanje = false;

            crvena =  113;
            zelena = 188;
            plava =228;
            BackColor = Color.FromArgb(crvena,zelena,plava);
        }

        private void IgraZavrsena()
        {
            igraGotova = true;
            timer1.Stop();
            labelRezultat.Text += Environment.NewLine + "Igra je završena!" + Environment.NewLine + "Pritisnite Enter da započnete novu igru.";
        }
    }
}
