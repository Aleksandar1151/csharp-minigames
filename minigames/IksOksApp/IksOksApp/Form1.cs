using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IksOksApp
{
    /*
     x_na_potezu = !x_na_potezu;

            if(x_na_potezu)
                UcitajBojePozadina(gornjaBoja,neaktivnaBoja);
            else
                UcitajBojePozadina(neaktivnaBoja,donjaBoja);

            broj_poteza = 0;
            UkljuciDugmad(true);
            OcistiBojeDugmadi();
     */

    public partial class Form1 : Form
    {
        bool x_na_potezu = true; // Kada je true onda je igrač X na potezu, false = Oks na potezu
        int broj_poteza = 0;


        string gornjaBoja = "#A4243B"; // Crvena
        string donjaBoja = "#355070"; // Plava
        string neaktivnaBoja = "#d3d3d3"; // Siva
        public Form1()
        {
            InitializeComponent();
            UcitajBojePozadina(gornjaBoja,neaktivnaBoja);
        }

        private void UcitajBojePozadina(string gornjaBoja, string donjaBoja)
        {
            imeBox1.BackColor = ColorTranslator.FromHtml(gornjaBoja);
            label1.BackColor =  ColorTranslator.FromHtml(gornjaBoja);
            label1Pozadina.BackColor = ColorTranslator.FromHtml(gornjaBoja);           
            
            imeBox2.BackColor = ColorTranslator.FromHtml(donjaBoja);
            label2.BackColor =  ColorTranslator.FromHtml(donjaBoja);
            label2Pozadina.BackColor = ColorTranslator.FromHtml(donjaBoja);

            labelPozadina.BackColor = ColorTranslator.FromHtml("#333533");
        }

        private void NovaIgraKlik(object sender, EventArgs e)
        {
            x_na_potezu = !x_na_potezu;

            if(x_na_potezu)
                UcitajBojePozadina(gornjaBoja,neaktivnaBoja);
            else
                UcitajBojePozadina(neaktivnaBoja,donjaBoja);

            broj_poteza = 0;
            UkljuciDugmad(true);
            OcistiBojeDugmadi();

        }

        private void DugmeKlik(object sender, EventArgs e)
        {
            Button dugme = (Button)sender;

            if(x_na_potezu == true)
            {                
                dugme.Text = "X";
                dugme.BackColor = ColorTranslator.FromHtml("#D74761");
            }
            else
            {
                dugme.Text = "O";
                dugme.BackColor = ColorTranslator.FromHtml("#487384");
            }

            dugme.Enabled = false;

            x_na_potezu = !x_na_potezu;

            if(x_na_potezu==true)
                UcitajBojePozadina(gornjaBoja,neaktivnaBoja);
            else
                UcitajBojePozadina(neaktivnaBoja,donjaBoja);

            broj_poteza++;

            ProvjeriPobjednika();
        }

        private void ProvjeriPobjednika()
        {
            bool postoji_pobjednik = false;

            //horizontalno provjeravanje
            if(dugme1.Text == dugme2.Text && dugme2.Text == dugme3.Text && !dugme1.Enabled )
            {
                postoji_pobjednik = true;
                ObojiDugmadPobjednika(dugme1,dugme2,dugme3);
            }                
            if(dugme4.Text == dugme5.Text && dugme5.Text == dugme6.Text && !dugme4.Enabled )
            {
                postoji_pobjednik = true;
                ObojiDugmadPobjednika(dugme4,dugme5,dugme6);
            }
            if(dugme7.Text == dugme8.Text && dugme8.Text == dugme9.Text && !dugme7.Enabled)
            {
                postoji_pobjednik = true;
                ObojiDugmadPobjednika(dugme7,dugme8,dugme9);
            }

            //vertikalno provjeravanje
            if(dugme1.Text == dugme4.Text && dugme4.Text == dugme7.Text && !dugme1.Enabled )
            {
                postoji_pobjednik = true;
                ObojiDugmadPobjednika(dugme1,dugme4,dugme7);
            }
            if(dugme2.Text == dugme5.Text && dugme5.Text == dugme8.Text && !dugme2.Enabled )
            {
                postoji_pobjednik = true;
                ObojiDugmadPobjednika(dugme2,dugme5,dugme8);
            }
            if(dugme3.Text == dugme6.Text && dugme6.Text == dugme9.Text && !dugme3.Enabled)
            {
                postoji_pobjednik = true;
                ObojiDugmadPobjednika(dugme3,dugme6,dugme9);
            }

            //dijagonalno provjeravanje
            if(dugme1.Text == dugme5.Text && dugme5.Text == dugme9.Text && !dugme1.Enabled )
            {
                postoji_pobjednik = true;
                ObojiDugmadPobjednika(dugme1,dugme5,dugme9);
            }
            if(dugme3.Text == dugme5.Text && dugme5.Text == dugme7.Text && !dugme3.Enabled )
            {
                postoji_pobjednik = true;
                ObojiDugmadPobjednika(dugme3,dugme5,dugme7);
            }


            if(postoji_pobjednik)
            {
                string ime_pobjednika = "";

                if(x_na_potezu == true)
                    ime_pobjednika = imeBox2.Text;
                else
                    ime_pobjednika = imeBox1.Text;

                MessageBox.Show("Pobjednik je " + ime_pobjednika, "Kraj igre");
                UkljuciDugmad(false);
                
            }
            else
            {
                if(broj_poteza == 9)
                {
                     UcitajBojePozadina(neaktivnaBoja,neaktivnaBoja);
                    OcistiBojeDugmadi();
                    MessageBox.Show("Neriješeno", "Kraj igre"); 
                   
                }
            }

        }// kraj ProvjeriPobjednika

        private void ObojiDugmadPobjednika(Button pd1, Button pd2, Button pd3)
        {
            dugme1.BackColor = ColorTranslator.FromHtml(neaktivnaBoja);
            dugme2.BackColor = ColorTranslator.FromHtml(neaktivnaBoja);
            dugme3.BackColor = ColorTranslator.FromHtml(neaktivnaBoja);
            dugme4.BackColor = ColorTranslator.FromHtml(neaktivnaBoja);
            dugme5.BackColor = ColorTranslator.FromHtml(neaktivnaBoja);
            dugme6.BackColor = ColorTranslator.FromHtml(neaktivnaBoja);
            dugme7.BackColor = ColorTranslator.FromHtml(neaktivnaBoja);
            dugme8.BackColor = ColorTranslator.FromHtml(neaktivnaBoja);
            dugme9.BackColor = ColorTranslator.FromHtml(neaktivnaBoja);

            string pobjednickaBoja ="#abff4f" ;
            pd1.BackColor = ColorTranslator.FromHtml(pobjednickaBoja);
            pd2.BackColor = ColorTranslator.FromHtml(pobjednickaBoja);
            pd3.BackColor = ColorTranslator.FromHtml(pobjednickaBoja);

            if(x_na_potezu)
                UcitajBojePozadina(neaktivnaBoja,pobjednickaBoja);
            else
                UcitajBojePozadina(pobjednickaBoja,neaktivnaBoja);
        }

        private void UkljuciDugmad(bool ukljuceno)
        {
            dugme1.Enabled = ukljuceno;
            dugme2.Enabled = ukljuceno;
            dugme3.Enabled = ukljuceno;
            dugme4.Enabled = ukljuceno;
            dugme5.Enabled = ukljuceno;
            dugme6.Enabled = ukljuceno;
            dugme7.Enabled = ukljuceno;
            dugme8.Enabled = ukljuceno;
            dugme9.Enabled = ukljuceno;

            if(ukljuceno)
            {
                dugme1.Text = "";
                dugme2.Text = "";
                dugme3.Text = "";
                dugme4.Text = "";
                dugme5.Text = "";
                dugme6.Text = "";
                dugme7.Text = "";
                dugme8.Text = "";
                dugme9.Text = "";
            }
            
        }

        private void OcistiBojeDugmadi()
        {
            dugme1.BackColor = Color.White;
            dugme2.BackColor = Color.White;
            dugme3.BackColor = Color.White;
            dugme4.BackColor = Color.White;
            dugme5.BackColor = Color.White;
            dugme6.BackColor = Color.White;
            dugme7.BackColor = Color.White;
            dugme8.BackColor = Color.White;
            dugme9.BackColor = Color.White;
            
        }

        


    }
}
