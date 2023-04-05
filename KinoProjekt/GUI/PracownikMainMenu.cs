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
    public partial class PracownikMainMenu : Form
    {
        public Pracownik pracownik;
        public PracownikMainMenu(Pracownik pracownik)
        {
            InitializeComponent();
            this.pracownik = pracownik;
        }

        private void EmployeeMainMenu_Load(object sender, EventArgs e)
        {
            using(AppDbContext db = new AppDbContext())
            {
                var pracownik = db.DbPracownik.Where(p => p.IdPracownik == this.pracownik.IdPracownik).FirstOrDefault();
                this.pracownik = pracownik;
            }

            label_employee_name.Text = "Witaj, " + pracownik.Imie + " " + pracownik.Nazwisko + "!";
            label_email.Text = "Masz podpiąty mail: " + pracownik.Email;
            label_stopien_uprawnienia.Text = "Masz stopień uprawnienia: " + pracownik.StopienUprawnienia;
        }

        private void button_dodaj_seans_Click(object sender, EventArgs e)
        {
            Hide();
            CreateSession createSession = new CreateSession(this);
            createSession.ShowDialog();
        }
    }
}
