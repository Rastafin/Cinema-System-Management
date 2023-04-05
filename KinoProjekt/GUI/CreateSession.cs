using Microsoft.Data.Sqlite;
using KinoProjekt.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KinoProjekt.Logic;
using KinoProjekt.Data;

namespace GUI
{
    public partial class CreateSession : Form
    {
        SerwisSeans serwisS = new SerwisSeans();
        PracownikMainMenu menu;
        public CreateSession(PracownikMainMenu mainMenu)
        {
            InitializeComponent();
            menu = mainMenu;
        }

        private void button_add_seans_Click(object sender, EventArgs e)
        {
            try
            {
                Image image = pictureBox_seans_image.Image;
                MemoryStream memoryStream = new MemoryStream();
                image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png);


                SerwisSeans serwisS = new SerwisSeans();
               

                serwisS.DodajSeans(memoryStream.ToArray(), textBox_tytul.Text, textBox_opis.Text, Int16.Parse(textBox_czas_seansu.Text), dateTimePicker_data_seansu.Text, Convert.ToString(0));
                MessageBox.Show("Dodano seans");

            }
            catch {
                MessageBox.Show("Nie da się zapisać tych danych do bazy. Podaj poprawne dane!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CreateSession_Load(object sender, EventArgs e)
        {
            //pictureBox_seans_image.Image = Image.FromFile("../../../KinoProjekt/Data/Podstawowe zdjecie.png");

            label_pracownik.Text = menu.pracownik.Imie + " " + menu.pracownik.Nazwisko;
        }

        private void pictureBox_seans_image_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Image Files(*.BMP, *.JPG, *.GIF, *.PNG)|*.BMP; *.JPG; *.GIF; *.PNG|All files (*.*)|*.*";

            ofd.ShowDialog();

            try
            {
                pictureBox_seans_image.Image = new Bitmap(ofd.FileName);
            }
            catch
            {
                MessageBox.Show("Niemożliwie jest odtworzyć tego pliku!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            menu.Show();
            this.Hide();
        }
    }
}
