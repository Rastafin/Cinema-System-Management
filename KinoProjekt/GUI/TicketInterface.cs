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
    public partial class TicketInterface : Form
    {
        Klient klient;
        Seans seans;
        public TicketInterface()
        {
            InitializeComponent();
        }
        public TicketInterface(Klient klient, Seans seans)
        {
            InitializeComponent();
            this.klient = klient;
            this.seans = seans;

        }

        private void TicketInterface_Load(object sender, EventArgs e)
        {
            //TODO: wyświetlanie tylko dostępnych miejsc
            foreach (Miejsca m in Enum.GetValues(typeof(Miejsca)))
            {
                miejscaComboBox.Items.Add(m);
            }
            
            // Ładowanie danych z sesji logowania
            //nazwaFilmuLabel.Text = 
            //czasFilmuLabel.Text = 
        }

        private void nazwaFilmuLabel_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void kupBiletButton_Click(object sender, EventArgs e)
        {
                if (imieTextBox.Text != "" && nazwiskoTextBox.Text != "" && miejscaComboBox.Text != "")
                {
                    Miejsca miejsce = (Miejsca)miejscaComboBox.SelectedItem;
                    int miejsceInt = (int)miejsce;

                    string imie = imieTextBox.Text;
                    string nazwisko = nazwiskoTextBox.Text;


                    // Dodać funkcję obliczającą cenę na podstawie wybranego miejsca, póki co każdy bilet po 23 zł
                    SerwisBilet bilet = new SerwisBilet();
                    bilet.DodajBilet(klient, seans, imie, nazwisko, 23, miejsceInt.ToString());
                    MessageBox.Show("Zakupiono Bilet!");
            }
                else
                {
                    MessageBox.Show("Niewypełnione dane!");
                }
        }
            

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            ShowSeansForm showSeansForm = new ShowSeansForm(klient);
            showSeansForm.ShowDialog();
        }
    }
}
