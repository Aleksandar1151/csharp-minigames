using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsocijacijeApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PostaviBoje();
        }

       private void PostaviBoje()
        {
            string bojaAkolona = "#2A9D8F";
            string bojaBkolona = "#E2B33C";
            string bojaCkolona = "#F0852D";
            string bojaDkolona = "#E76F51";
            string bojaA = "#1A6158";
            string bojaB = "#C3941D";
            string bojaC = "#AC540C";
            string bojaD = "#902C14";
            string bojaKonacno = "#264653";

            da1.BackColor = ColorTranslator.FromHtml(bojaAkolona);
            da2.BackColor = ColorTranslator.FromHtml(bojaAkolona);
            da3.BackColor = ColorTranslator.FromHtml(bojaAkolona);
            da4.BackColor = ColorTranslator.FromHtml(bojaAkolona);
            da.BackColor = ColorTranslator.FromHtml(bojaA);

            db1.BackColor = ColorTranslator.FromHtml(bojaBkolona);
            db2.BackColor = ColorTranslator.FromHtml(bojaBkolona);
            db3.BackColor = ColorTranslator.FromHtml(bojaBkolona);
            db4.BackColor = ColorTranslator.FromHtml(bojaBkolona);
            db.BackColor = ColorTranslator.FromHtml(bojaB);

            dc1.BackColor = ColorTranslator.FromHtml(bojaCkolona);
            dc2.BackColor = ColorTranslator.FromHtml(bojaCkolona);
            dc3.BackColor = ColorTranslator.FromHtml(bojaCkolona);
            dc4.BackColor = ColorTranslator.FromHtml(bojaCkolona);
            dc.BackColor = ColorTranslator.FromHtml(bojaC);

            dd1.BackColor = ColorTranslator.FromHtml(bojaDkolona);
            dd2.BackColor = ColorTranslator.FromHtml(bojaDkolona);
            dd3.BackColor = ColorTranslator.FromHtml(bojaDkolona);
            dd4.BackColor = ColorTranslator.FromHtml(bojaDkolona);
            dd.BackColor = ColorTranslator.FromHtml(bojaD);

            drkonacno.BackColor = ColorTranslator.FromHtml(bojaKonacno);


        }


        private void OtvoriKarticuKlik(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;
            string dugmeTag = Convert.ToString(senderObject.Tag);
            
            senderObject.ForeColor = Color.Black;

            switch(dugmeTag)
            {
                case "a1":
                    {
                        senderObject.BackColor = ColorTranslator.FromHtml("#BFEDE8");
                        senderObject.Text = "Kuhinja";
                        break;
                    }
                case "a2":
                    {
                        senderObject.BackColor = ColorTranslator.FromHtml("#BFEDE8");
                        senderObject.Text = "Slano";
                        break;
                    }
                case "a3":
                    {
                        senderObject.BackColor = ColorTranslator.FromHtml("#BFEDE8");
                        senderObject.Text = "Natrijum";
                        break;
                    }
                case "a4":
                    {
                        senderObject.BackColor = ColorTranslator.FromHtml("#BFEDE8");
                        senderObject.Text = "Hlor";
                        break;
                    }
                case "a":
                    {
                        senderObject.BackColor = ColorTranslator.FromHtml("#80DBD0");                        
                        senderObject.Text = "So";
                        break;
                    }

                case "b1":
                    {
                        senderObject.BackColor = ColorTranslator.FromHtml("#F4E3B8");
                        senderObject.Text = "Kiseonik";
                        break;
                    }
                case "b2":
                    {
                        senderObject.BackColor = ColorTranslator.FromHtml("#F4E3B8");
                        senderObject.Text = "Vodonik";
                        break;
                    }
                case "b3":
                    {
                        senderObject.BackColor = ColorTranslator.FromHtml("#F4E3B8");
                        senderObject.Text = "Žeđ";
                        break;
                    }
                case "b4":
                    {
                        senderObject.BackColor = ColorTranslator.FromHtml("#F4E3B8");
                        senderObject.Text = "Čaša";
                        break;
                    }
                case "b":
                    {
                        senderObject.BackColor = ColorTranslator.FromHtml("#ECCE83");
                       
                        senderObject.Text = "Voda";
                        break;
                    }

                case "c1":
                    {
                        senderObject.BackColor = ColorTranslator.FromHtml("#FAD3B3");
                        senderObject.Text = "Humor";
                        break;
                    }
                case "c2":
                    {
                        senderObject.BackColor = ColorTranslator.FromHtml("#FAD3B3");
                        senderObject.Text = "Zlato";
                        break;
                    }
                case "c3":
                    {
                        senderObject.BackColor = ColorTranslator.FromHtml("#FAD3B3");
                        senderObject.Text = "Udovica";
                        break;
                    }
                case "c4":
                    {
                        senderObject.BackColor = ColorTranslator.FromHtml("#FAD3B3");
                        senderObject.Text = "Noć";
                        break;
                    }
                case "c":
                    {
                        senderObject.BackColor = ColorTranslator.FromHtml("#F8BC8C");
                        
                        senderObject.Text = "Crno";
                        break;
                    }
                case "d1":
                    {
                        senderObject.BackColor = ColorTranslator.FromHtml("#F3B5A5");
                        senderObject.Text = "Odbojka";
                        break;
                    }
                case "d2":
                    {
                        senderObject.BackColor = ColorTranslator.FromHtml("#F3B5A5");
                        senderObject.Text = "Obala";
                        break;
                    }
                case "d3":
                    {
                        senderObject.BackColor = ColorTranslator.FromHtml("#F3B5A5");
                        senderObject.Text = "Suncobran";
                        break;
                    }
                case "d4":
                    {
                        senderObject.BackColor = ColorTranslator.FromHtml("#F3B5A5");
                        senderObject.Text = "Pjesak";
                        break;
                    }

                case "d":
                    {
                        senderObject.BackColor = ColorTranslator.FromHtml("#EE9781");
                        
                        senderObject.Text = "Plaža";
                        break;
                    }
                case "k":
                    {
                        senderObject.BackColor = ColorTranslator.FromHtml("#65A1B8");
                        senderObject.ForeColor = Color.White;
                        senderObject.Text = "MORE";
                        break;
                    }
                    
            }
            
        }

       
    }
}
