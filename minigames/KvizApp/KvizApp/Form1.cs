using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KvizApp
{
    public partial class Form1 : Form
    {
        int tacanOdgovor;
        int brojPitanja = 1;
        int rezultat = 0;
        int ukupanBrojPitanja = 3;

        string bojaDugmadi = "#e9c46a";
        public Form1()
        {
            InitializeComponent();
            PostavljanjeBoja();

            PostaviPitanje(brojPitanja);
        }
        private void PostavljanjeBoja()
        {
            dugme1.BackColor = ColorTranslator.FromHtml(bojaDugmadi);
            dugme2.BackColor = ColorTranslator.FromHtml(bojaDugmadi);
            dugme3.BackColor = ColorTranslator.FromHtml(bojaDugmadi);
            dugme4.BackColor = ColorTranslator.FromHtml(bojaDugmadi);
        }

        private async void ProvjeriOdgovorKlikAsync(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;

            int dugmeBroj = Convert.ToInt32(senderObject.Tag);
           
            IskljuciDugmad();
            if(dugmeBroj == tacanOdgovor)
            {              
                senderObject.BackColor = ColorTranslator.FromHtml("#6a994e");
                rezultat++;               
            }
            else
            {                
                senderObject.BackColor = ColorTranslator.FromHtml("#bc4749");
            }

            await Task.Delay(2000);

            UkljuciDugmad();

            senderObject.BackColor = ColorTranslator.FromHtml(bojaDugmadi);

            brojPitanja++;

            PostaviPitanje(brojPitanja);
        }

        private void IskljuciDugmad()
        {
            dugme1.Enabled = false;
            dugme2.Enabled = false;
            dugme3.Enabled = false;
            dugme4.Enabled = false;

            labelPitanje.Focus();
        }

        private void UkljuciDugmad()
        {
            dugme1.Enabled = true;
            dugme2.Enabled = true;
            dugme3.Enabled = true;
            dugme4.Enabled = true;
        }
     

        private void PostaviPitanje(int brojPitanja)
        {
            switch(brojPitanja)
            {
                case 1:
                    {
                        pictureBox1.Image = Properties.Resources.nikolajokic;
                        labelPitanje.Text= "Kako se zove košarkaš sa slike?";

                        dugme1.Text = "Aleksej Pokuševski";
                        dugme2.Text = "Nikola Jokić";
                        dugme3.Text = "Bogdan Bogdanović";
                        dugme4.Text = "Nemanja Bjelica";

                        tacanOdgovor = 2;
                        break;
                    }
                     case 2:
                    {
                        pictureBox1.Image = Properties.Resources.spiderman;
                        labelPitanje.Text= "Kako se zove superheroj sa slike?";

                        dugme1.Text = "Batman";
                        dugme2.Text = "Iron man";
                        dugme3.Text = "Green Arrow";
                        dugme4.Text = "Spider-man";

                        tacanOdgovor = 4;
                        break;
                    }
                     case 3:
                    {
                        pictureBox1.Image = Properties.Resources.messi;
                        labelPitanje.Text= "Kako se zove fudbaler sa slike?";

                        dugme1.Text = "Cristiano Ronaldo";
                        dugme2.Text = "Kevin De Bruyne";
                        dugme3.Text = "Lionel Messi";
                        dugme4.Text = "Kylian Mbappe";
                        tacanOdgovor = 3;
                        break;
                    }
                    default: MessageBox.Show("Kraj kviza!" + Environment.NewLine + "Broj tačnih odgovora:" + rezultat+"/"+ukupanBrojPitanja); Close();break;
            }
        }

       
    }
}
