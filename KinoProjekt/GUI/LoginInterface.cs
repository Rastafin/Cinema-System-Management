using GUI;
using KinoProjekt.Logic;
using KinoProjekt.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginInterface
{
    public partial class LoginInterface : Form
    {
        SerwisLogowanie serwisL = new SerwisLogowanie();
        SerwisLogowaniePracownik serwisLP = new SerwisLogowaniePracownik();
        public LoginInterface()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxEmail.TabStop = false;
            textBoxHaslo.TabStop = false;

            serwisL.WypelnijListe();
            serwisLP.WypelnijListe();
        }

        private void textBoxEmail_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void textBoxEmail_Enter(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "Email")
            {
                textBoxEmail.Text = "";
            }
        }

        private void textBoxHaslo_Enter(object sender, EventArgs e)
        {
            if (textBoxHaslo.Text == "Haslo")
            {
                textBoxHaslo.Text = "";
            }
        }

        private void textBoxEmail_Leave(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "")
            {
                textBoxEmail.Text = "Email";
            }
        }

        private void textBoxHaslo_Leave(object sender, EventArgs e)
        {
            if (textBoxHaslo.Text == "")
            {
                textBoxHaslo.Text = "Haslo";
            }
        }

        private void buttonZaloguj_Click(object sender, EventArgs e)
        {
            Klient klient;

            if(serwisL.CheckIfCorrectLogin(textBoxEmail.Text, textBoxHaslo.Text, out klient) == true)
            {
                Hide();
                ShowSeansForm showSeansForm = new ShowSeansForm(klient);
                showSeansForm.ShowDialog();

            }
            else
            {
                MessageBox.Show("Niepoprawny email lub haslo");
            }
        }

        private void buttonZarejestruj_Click(object sender, EventArgs e)
        {
            Hide();
            SignUpInterface rejestracja = new SignUpInterface();
            rejestracja.ShowDialog();
        }

        private void buttonPrzypomnijHaslo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To by bylo zbyt proste ;)");
            serwisLP.WypelnijListe();
            foreach(Pracownik pracownik in serwisLP.ListaPracowników)
            {
                MessageBox.Show(pracownik.Imie);
            }
        }

        private void button_add_session_Click(object sender, EventArgs e)
        {


            Pracownik pracownik;

            if (serwisLP.CheckIfCorrectLoginPracownik(textBoxEmail.Text, textBoxHaslo.Text, out pracownik) == true)
            {
                Hide();
                PracownikMainMenu mainMenu = new PracownikMainMenu(pracownik);
                mainMenu.ShowDialog();
            }
            else
            {
                MessageBox.Show("Niepoprawny email lub haslo");
            }
           

        }
    }
}
