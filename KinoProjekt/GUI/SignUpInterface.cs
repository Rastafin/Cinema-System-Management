using KinoProjekt.Data;
using KinoProjekt.Logic;
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
    public partial class SignUpInterface : Form
    {
        public SignUpInterface()
        {
            InitializeComponent();
        }

        private void textBoxUserName_Enter(object sender, EventArgs e)
        {
            if (textBoxPlec.Text == "Plec (Mezczyzna, Kobieta, Nie chce podawac")
            {
                textBoxPlec.Text = "";
            }
        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "Haslo")
            {
                textBoxPassword.Text = "";
            }
        }

        private void textBoxEmail_Enter(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "Email")
            {
                textBoxEmail.Text = "";
            }
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == "Numer tel")
            {
                textBox4.Text = "";
            }
        }

        private void SignUpInterface_Load(object sender, EventArgs e)
        {
            textBox4.TabStop = false;
            textBoxEmail.TabStop = false;
            textBoxPassword.TabStop = false;
            textBoxPlec.TabStop = false;

            foreach(Wojewodztwa w in Enum.GetValues(typeof(Wojewodztwa)))
            {
                comboBoxWoj.Items.Add(w);
            }
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxImie.Text != "Imie" && textBoxNazwisko.Text != "Nazwisko" && textBoxDataUr.Text != "Data urodzenia d d - m m - r r r r" && textBoxPlec.Text != "Plec (Mezczyzna, Kobieta, Nie chce podawac" 
                    && textBoxPassword.Text != "Haslo" && textBoxEmail.Text != "Email" && textBox4.Text != "Numer tel" && textBoxKodP.Text != "Kod Pocztowy XX-XXX" 
                    && textBoxNrMieszkania.Text != "Nr Mieszkania" && textBoxNrDomu.Text != "Nr domu" &&textBoxUlica.Text != "Ulica" && textBoxMiasto.Text != "Miasto" && comboBoxWoj.SelectedItem != null)
                {
                    

                    Wojewodztwa wojewodztwo = (Wojewodztwa)comboBoxWoj.SelectedItem;

                    SerwisRejestracja serwisR = new SerwisRejestracja();
                    serwisR.Rejestracja(0.0, textBoxImie.Text, textBoxNazwisko.Text, textBoxDataUr.Text, textBoxPlec.Text, textBoxPassword.Text, textBoxEmail.Text,
                        textBox4.Text, wojewodztwo, textBoxMiasto.Text, textBoxUlica.Text, textBoxNrDomu.Text, textBoxNrMieszkania.Text, textBoxKodP.Text, true, false);

                    MessageBox.Show("Zarejestrowano! Zaloguj się");

                    Hide();
                    LoginInterface login = new LoginInterface();
                    login.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Podaj wszystkie dane");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Podaj poprawna date");
            }
        }

        private void textBoxUserName_Leave(object sender, EventArgs e)
        {
            if (textBoxPlec.Text == "")
            {
                textBoxPlec.Text = "Plec (Mezczyzna, Kobieta, Nie chce podawac";
            }
        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "")
            {
                textBoxPassword.Text = "Haslo";
            }
        }

        private void textBoxEmail_Leave(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "")
            {
                textBoxEmail.Text = "Email";
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text = "Numer tel";
            }
        }

        private void textBoxUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxImie_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxImie_Enter(object sender, EventArgs e)
        {
            if (textBoxImie.Text == "Imie")
            {
                textBoxImie.Text = "";
            }
        }

        private void textBoxImie_Leave(object sender, EventArgs e)
        {
            if (textBoxImie.Text == "")
            {
                textBoxImie.Text = "Imie";
            }
        }

        private void textBoxNazwisko_Enter(object sender, EventArgs e)
        {
            if (textBoxNazwisko.Text == "Nazwisko")
            {
                textBoxNazwisko.Text = "";
            }
        }

        private void textBoxNazwisko_Leave(object sender, EventArgs e)
        {
            if (textBoxNazwisko.Text == "")
            {
                textBoxNazwisko.Text = "Nazwisko";
            }
        }

        private void textBoxDataUr_Enter(object sender, EventArgs e)
        {
            if (textBoxDataUr.Text == "Data urodzenia d d - m m - r r r r")
            {
                textBoxDataUr.Text = "";
            }
        }

        private void textBoxDataUr_Leave(object sender, EventArgs e)
        {
            if (textBoxDataUr.Text == "")
            {
                textBoxDataUr.Text = "Data urodzenia d d - m m - r r r r";
            }
        }

        private void textBoxMiasto_Enter(object sender, EventArgs e)
        {
            if (textBoxMiasto.Text == "Miasto")
            {
                textBoxMiasto.Text = "";
            }
        }

        private void textBoxMiasto_Leave(object sender, EventArgs e)
        {
            if (textBoxMiasto.Text == "")
            {
                textBoxMiasto.Text = "Miasto";
            }
        }

        private void textBoxUlica_Enter(object sender, EventArgs e)
        {
            if (textBoxUlica.Text == "Ulica")
            {
                textBoxUlica.Text = "";
            }
        }

        private void textBoxUlica_Leave(object sender, EventArgs e)
        {
            if (textBoxUlica.Text == "")
            {
                textBoxUlica.Text = "Ulica";
            }
        }

        private void textBoxNrDomu_Enter(object sender, EventArgs e)
        {
            if (textBoxNrDomu.Text == "Nr domu")
            {
                textBoxNrDomu.Text = "";
            }
        }

        private void textBoxNrDomu_Leave(object sender, EventArgs e)
        {
            if (textBoxNrDomu.Text == "")
            {
                textBoxNrDomu.Text = "Nr domu";
            }
        }

        private void textBoxNrMieszkania_Enter(object sender, EventArgs e)
        {
            if (textBoxNrMieszkania.Text == "Nr Mieszkania")
            {
                textBoxNrMieszkania.Text = "";
            }
        }

        private void textBoxNrMieszkania_Leave(object sender, EventArgs e)
        {
            if (textBoxNrMieszkania.Text == "")
            {
                textBoxNrMieszkania.Text = "Nr Mieszkania";
            }
        }

        private void textBoxKodP_Enter(object sender, EventArgs e)
        {
            if (textBoxKodP.Text == "Kod Pocztowy XX-XXX")
            {
                textBoxKodP.Text = "";
            }
        }

        private void textBoxKodP_Leave(object sender, EventArgs e)
        {
            if (textBoxKodP.Text == "")
            {
                textBoxKodP.Text = "Kod Pocztowy XX-XXX";
            }
        }

        private void buttonPowrot_Click(object sender, EventArgs e)
        {
            Hide();
            LoginInterface login = new LoginInterface();
            login.ShowDialog();
        }
    }
}
