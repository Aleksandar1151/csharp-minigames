using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LavirintApp
{
    public partial class Form1 : Form
    {
        Point pocetnaPozicija;
        public Form1()
        {
            InitializeComponent();
            pocetnaPozicija = panel2.Location;
            pocetnaPozicija.X += 20;
            pocetnaPozicija.Y += 20;
            Cursor.Position = PointToScreen(pocetnaPozicija);

            labelStart.BackColor = ColorTranslator.FromHtml("#0496FF");
            labelKraj.BackColor = ColorTranslator.FromHtml("#97CC04");
        }

       

        private async void MisDodir(object sender, EventArgs e)
        {
            panel2.BackColor = ColorTranslator.FromHtml("#E88D67");         
            Cursor.Hide();
            await Task.Delay(1000);

            Cursor.Position = PointToScreen(pocetnaPozicija);
            panel2.BackColor = Color.WhiteSmoke;    
            Cursor.Show();

        }

        private async void MisKraj(object sender, EventArgs e)
        {
            panel2.BackColor = ColorTranslator.FromHtml("#97CC04"); 
            
            MessageBox.Show("POBJEDA!!!");
                    
            
            await Task.Delay(1000);
            Cursor.Position = PointToScreen(pocetnaPozicija);
            panel2.BackColor = Color.WhiteSmoke;    
            Cursor.Show();

           
        }

      
    }
}
