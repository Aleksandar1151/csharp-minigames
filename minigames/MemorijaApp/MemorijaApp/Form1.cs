using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemorijaApp
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        Label prviKlik, drugiKlik;

        List<string> icons = new List<string>()
        {
            "b","b","o","o","N","N","O","O",
            "!","!","$","$","%","%","~","~"
        };


        public Form1()
        {
            InitializeComponent();
           DodijeliIkonice();

            //tableLayoutPanel1.BackColor = ColorTranslator.FromHtml("#6f1d1b");
        }

        private void PoljeKlik(object sender, EventArgs e)
        {
            if(prviKlik != null && drugiKlik != null)
                return;


            Label kliknutoPolje = sender as Label;

            if(kliknutoPolje == null) return;
            if(kliknutoPolje.ForeColor == Color.White) return;

            if(prviKlik == null)
            {
                prviKlik = kliknutoPolje;
                prviKlik.ForeColor = Color.White;
                return;
            }

            drugiKlik = kliknutoPolje;
            drugiKlik.ForeColor = Color.White;

            ProvjeriPobjednika();

            if(prviKlik.Text == drugiKlik.Text)
            {
                prviKlik = null;
                drugiKlik = null;

            }
            else
                timer1.Start();
        }

        private void ProvjeriPobjednika()
        {
            Label label;
            for(int i = 0; i< tableLayoutPanel1.Controls.Count; i++)
            {
                label = tableLayoutPanel1.Controls[i] as Label;

                if(label != null && label.ForeColor == Color.DarkGreen )
                    return;
            }

            MessageBox.Show("Završili ste igru! Bravo!");
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            prviKlik.ForeColor = Color.DarkGreen;
            drugiKlik.ForeColor = Color.DarkGreen;

            prviKlik = null;
            drugiKlik = null;
        }

        private void DodijeliIkonice()
        {
            Label label;
            int randomBroj;

            for(int i = 0; i< tableLayoutPanel1.Controls.Count; i++)
            {
                if(tableLayoutPanel1.Controls[i] is Label)
                    label = (Label)tableLayoutPanel1.Controls[i];
                else continue;

                randomBroj = random.Next(0,icons.Count);
                label.Text = icons[randomBroj];

                icons.RemoveAt(randomBroj);

            }
        }

      
    }
}
