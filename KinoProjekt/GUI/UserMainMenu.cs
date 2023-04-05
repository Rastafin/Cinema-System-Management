using KinoProjekt.Data;
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
    public partial class UserMainMenu : Form
    {
        public Klient klient;

        public UserMainMenu(Klient klient)
        {
            InitializeComponent();
            this.klient = klient;
        }

        private void UserMainMenu_Load(object sender, EventArgs e)
        {
            using(var db = new AppDbContext())
            {
                var client = db.DbKlient.Where(u => u.IdKlient == klient.IdKlient).FirstOrDefault();
                klient = client;
            }

            label_user_name.Text = "Witaj, " + klient.Imie + " " + klient.Nazwisko + "!";
            label_email.Text = "Masz podpiąty mail: " + klient.Email;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            ChangePassword changePassword = new ChangePassword();
            changePassword.klient = klient;
            changePassword.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            ChangePersonalData changePersonalData = new ChangePersonalData();
            changePersonalData.klient = klient;
            changePersonalData.ShowDialog();
        }

        private void buttonPowrot_Click(object sender, EventArgs e)
        {
            Hide();
            ShowSeansForm showSeansForm = new ShowSeansForm(klient);
            showSeansForm.ShowDialog();
        }
    }
}
