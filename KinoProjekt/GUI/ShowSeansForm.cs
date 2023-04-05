using KinoProjekt.Logic;
using KinoProjekt.Model;
using LoginInterface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class ShowSeansForm : Form
    {
        Klient klient;
        Seans seans;
        public ShowSeansForm(Klient klient)
        {
            InitializeComponent();
            this.klient = klient;
        }
        public ShowSeansForm()
        {
            InitializeComponent();
        }
        private static int id = 1;
        private int page;
        private DateTime data;
        List<Seans> film = new List<Seans>();
        SerwisSeans kino = new SerwisSeans();

        public int GetPage()
        {
            page = Convert.ToInt32(label5.Text);
            return page;
        }

        public int GetCurrentId()
        {
            return id;
        }

        public int GetNextId()
        {
            int nextId = int.MaxValue;
            foreach (Seans seansy in kino.WyswietlSeans())
            {
                if (seansy.IdSeans > id && seansy.IdSeans < nextId)
                {
                    nextId = seansy.IdSeans;
                }
            }
            return nextId;
        }

        public int GetPreviosId()
        {
            int prevId = int.MinValue;
            foreach (Seans seansy in kino.WyswietlSeans())
            {
                if (seansy.IdSeans < id && seansy.IdSeans > prevId)
                {
                    prevId = seansy.IdSeans;
                }
            }
            return prevId;
        }
      
        private void ShowSeansForm_Load(object sender, EventArgs e)
        {
            // film = kino.WyswietlSeans();
            foreach (Seans seansy in kino.WyswietlSeans())
            {
                if ((seansy.IdSeans == null)||(seansy.Tytul==""))
                {
                    continue;
                }
                else
                {
                    if (seansy.IdSeans == GetCurrentId())
                    {
                   
                        try
                        {
                            Image zdjecie = (Bitmap)((new ImageConverter()).ConvertFrom(seansy.Zdjecie));
                            pictureBox1.Image = zdjecie;
                        }
                        catch 
                        {
                            Image zdjecie = null;
                            pictureBox1.Image = zdjecie;
                        }
                        

                        labelTytul.Text = "Tytuł: " + seansy.Tytul;
                        labelOpis.Text = "Opis: " + seansy.Opis;
                        labelData.Text = "Data: " + seansy.Data;
                        labelDlugosc.Text = "Długość: " + obliczGodziny(seansy.Dlugosc);                        
                        seans = seansy;
                    }
                }
            }
        }
        private string obliczGodziny(int minuty)
        {
            int minutyWynik = minuty;
            int godzinyWynik = 0;
            string wynik = "";

            while (minutyWynik >= 60)
            {
                minutyWynik = minutyWynik - 60;
                godzinyWynik++;
            }

            if (minutyWynik < 10)
            {
                wynik = godzinyWynik.ToString() + ":0" + minutyWynik.ToString();
                return wynik;
            }
            else
            {
                wynik = godzinyWynik.ToString() + ":" + minutyWynik.ToString();
                return wynik;
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int nextId = GetNextId();
            if (nextId != int.MaxValue)
            {
                id = nextId;
                page = GetPage() + 1;
                label5.Text = page.ToString();
                GetPage();
                ShowSeansForm_Load(sender, e);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int prevId = GetPreviosId();
            if (prevId != int.MinValue)
            {
                id = prevId;
                page = GetPage() - 1;
                label5.Text = page.ToString();
                GetPage();
                ShowSeansForm_Load(sender, e);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            LoginInterface.LoginInterface login = new LoginInterface.LoginInterface();
            login.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            UserMainMenu umm = new UserMainMenu(klient);
            umm.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Hide();
            TicketInterface ticketInterface = new TicketInterface(klient, seans);
            ticketInterface.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

 

        private void buttonFiltr_Click(object sender, EventArgs e)
        {
            
        }
    }
}
