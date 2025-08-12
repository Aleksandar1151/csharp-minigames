using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpojniceApp
{
    public partial class Form1 : Form
    {
        Button kliknutoLijevoDugme = null;
        Button kliknutoDesnoDugme = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void LijevaDugmadKlik(object sender, EventArgs e)
        {
            if(kliknutoLijevoDugme == null)
            {
                var kliknutoDugme = (Button)sender;
                kliknutoLijevoDugme = kliknutoDugme;
            
                kliknutoDugme.BackColor = ColorTranslator.FromHtml("#98BBD7");

            }
        }

        private void DesnaDugmadKlik(object sender, EventArgs e)
        {
            if(kliknutoLijevoDugme != null)
            {
                var kliknutoDugme = (Button)sender;
                kliknutoDesnoDugme = kliknutoDugme;

                int rtag = Convert.ToInt32( kliknutoDesnoDugme.Tag);
                int ltag = Convert.ToInt32( kliknutoLijevoDugme.Tag);

            switch(rtag)
            {
                case 11:
                        if(ltag == 6)                        
                            tacanOdgovor();                        
                        else                        
                            pogresanOdgovor(); 
                        break;
                case 12:
                        if(ltag == 5)                        
                            tacanOdgovor();                        
                        else                        
                            pogresanOdgovor(); 
                        break;
                case 13:
                        if(ltag == 1)                        
                            tacanOdgovor();                        
                        else                        
                            pogresanOdgovor(); 
                        break;
                case 14:
                        if(ltag == 4)                        
                            tacanOdgovor();                        
                        else                        
                            pogresanOdgovor(); 
                        break;
                case 15:
                        if(ltag == 2)                        
                            tacanOdgovor();                        
                        else                        
                            pogresanOdgovor(); 
                        break;
                case 16:
                        if(ltag == 8)                        
                            tacanOdgovor();                        
                        else                        
                            pogresanOdgovor(); 
                        break;
                case 17:
                        if(ltag == 3)                        
                            tacanOdgovor();                        
                        else                        
                            pogresanOdgovor(); 
                        break;
                case 18:
                        if(ltag == 7)                        
                            tacanOdgovor();                        
                        else                        
                            pogresanOdgovor(); 
                        break;
            }

                 kliknutoLijevoDugme = null;
                 kliknutoDesnoDugme = null;

            }
        }

        private void tacanOdgovor()
        {
            kliknutoLijevoDugme.BackColor = ColorTranslator.FromHtml("#76c893");
            kliknutoDesnoDugme.BackColor = ColorTranslator.FromHtml("#76c893");
            kliknutoLijevoDugme.Enabled = false;
            kliknutoDesnoDugme.Enabled = false;
        }

        private void pogresanOdgovor()
        {
            kliknutoLijevoDugme.BackColor = ColorTranslator.FromHtml("#bc4749");
           // kliknutoDesnoDugme.BackColor = ColorTranslator.FromHtml("#bc4749");
            kliknutoLijevoDugme.Enabled = false;
          //  kliknutoDesnoDugme.Enabled = false;

        }

    }
}
