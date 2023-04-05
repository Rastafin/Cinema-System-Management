using KinoProjekt.Data;
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

namespace GUI
{
    public partial class ChangePersonalData : Form
    {
        public Klient klient;
        public ChangePersonalData()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void ChangePersonalData_Load(object sender, EventArgs e)
        {
            foreach (Wojewodztwa w in Enum.GetValues(typeof(Wojewodztwa)))
            {
                comboBoxWoj.Items.Add(w);
            }

            textBoxImie.Text = klient.Imie;
            textBoxNazwisko.Text = klient.Nazwisko;
            textBoxData.Text = klient.DataUrodzenia;
            textBoxPlec.Text = klient.Plec;
            textBoxNumerTel.Text = klient.NrTelefonu;
            textBoxMiasto.Text = klient.Miasto;
            textBoxUlica.Text = klient.Ulica;
            textBoxNrDomu.Text = klient.NrDomu;
            textBoxNrMieszkania.Text = klient.NrMieszkania;
            textBoxKodPocztowy.Text = klient.KodPocztowy;
            comboBoxWoj.SelectedItem = klient.Wojewodztwo;
        }

        private void buttonPowrot_Click(object sender, EventArgs e)
        {
            Hide();
            UserMainMenu userMainMenu = new UserMainMenu(klient);
            userMainMenu.klient = klient;
            userMainMenu.ShowDialog();
        }

        private void buttonZapisz_Click(object sender, EventArgs e)
        {
            if(textBoxImie.Text!="" && textBoxNazwisko.Text!="" && textBoxData.Text!="" && textBoxPlec.Text!="" && textBoxNumerTel.Text!="" &&
                textBoxMiasto.Text!="" && textBoxUlica.Text!="" && textBoxNrDomu.Text!="" && textBoxNrMieszkania.Text!="" && textBoxKodPocztowy.Text!="" &&
                comboBoxWoj.SelectedItem!= null)
            {
                Wojewodztwa wojewodztwo = (Wojewodztwa)comboBoxWoj.SelectedItem;

                SerwisLogowanie serwisL = new SerwisLogowanie();
                serwisL.ChangePersonalData(klient, textBoxImie.Text, textBoxNazwisko.Text, textBoxData.Text, textBoxPlec.Text, textBoxNumerTel.Text,
                    textBoxMiasto.Text, textBoxUlica.Text, textBoxNrDomu.Text, textBoxNrMieszkania.Text, textBoxKodPocztowy.Text, wojewodztwo);

                MessageBox.Show("Dane zostały zmienione");

                Hide();
                UserMainMenu userMainMenu = new UserMainMenu(klient);
                userMainMenu.klient = klient;
                userMainMenu.ShowDialog();

            }
            else
            {
                MessageBox.Show("Podaj wszystkie dane");
            }
        }
    }
}
