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
    public partial class ChangePassword : Form
    {
        public Klient klient;
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            textBoxStareHaslo.TabStop = false;
            textBoxNoweHaslo.TabStop = false;
        }

        private void buttonZapisz_Click(object sender, EventArgs e)
        {
            if (textBoxStareHaslo.Text == klient.Haslo && textBoxNoweHaslo.Text != "" && textBoxStareHaslo.Text != textBoxNoweHaslo.Text) 
            {
                SerwisLogowanie serwisL = new SerwisLogowanie();
                serwisL.ChangePassword(klient, textBoxNoweHaslo.Text);
                MessageBox.Show("Haslo zostalo zmienione");
                Hide();
                UserMainMenu userMainMenu = new UserMainMenu(klient);
                userMainMenu.klient = klient;
                userMainMenu.ShowDialog();
            }
            else
            {
                MessageBox.Show("Podano bledne dane");
            }
        }

        private void buttonPowrot_Click(object sender, EventArgs e)
        {
            Hide();
            UserMainMenu userMainMenu = new UserMainMenu(klient);
            userMainMenu.klient = klient;
            userMainMenu.ShowDialog();
        }
    }
}
