using KinoProjekt.Data;
using KinoProjekt.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinoProjekt.Logic
{
    public class SerwisLogowanie
    {
        public List<Klient> ListaKlientow = new List<Klient>();
        public int LiczbaKont()
        {
            return ListaKlientow.Count();
        }

        public void WypelnijListe()
        {
            ListaKlientow.Clear();
            using AppDbContext context = new AppDbContext();
            string test = context.TestString();
            ListaKlientow = context.DbKlient.ToList<Klient>();
        }

        public bool CheckIfCorrectLogin(string email, string haslo, out Klient client)
        {
            WypelnijListe();

            foreach (Klient klient in ListaKlientow)
            {
                if (klient.Haslo == haslo && klient.Email == email)
                {
                    client = klient;
                    return true;
                }
            }

            client = null;
            return false;
        }

        public void ChangePassword(Klient klient, string noweHaslo)
        {
            using (var db = new AppDbContext())
            {
                var client = db.DbKlient.Where(u => u.IdKlient == klient.IdKlient).FirstOrDefault();

                client.Haslo = noweHaslo;

                db.SaveChanges();
            }
            
        }

        public void ChangePersonalData(Klient klient, string imie, string nazwisko, string dataUrodzenia, string plec, string numerTel, string miasto,
            string ulica, string nrDomu, string nrMieszkania, string kodPocztowy, Wojewodztwa wojewodztwo)
        {
            using (var db = new AppDbContext())
            {
                var client = db.DbKlient.Where(u => u.IdKlient == klient.IdKlient).FirstOrDefault();

                client.Imie = imie;
                client.Nazwisko = nazwisko;
                client.DataUrodzenia = dataUrodzenia;
                client.Plec = plec;
                client.NrTelefonu = numerTel;
                client.Miasto = miasto;
                client.Ulica = ulica;
                client.NrDomu = nrDomu;
                client.NrMieszkania = nrMieszkania;
                client.KodPocztowy = kodPocztowy;
                client.Wojewodztwo = wojewodztwo;

                db.SaveChanges();
            }
        }
    }
}
