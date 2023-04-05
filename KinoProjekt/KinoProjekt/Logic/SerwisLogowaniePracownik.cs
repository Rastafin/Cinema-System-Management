using KinoProjekt.Data;
using KinoProjekt.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinoProjekt.Logic
{
    public class SerwisLogowaniePracownik
    {
        public List<Pracownik> ListaPracowników = new List<Pracownik>();
        public int LiczbaKontPracowników()
        {
            return ListaPracowników.Count();
        }

        public void WypelnijListe()
        {
            ListaPracowników.Clear();
            using AppDbContext context = new AppDbContext();
            string test = context.TestString();
            ListaPracowników = context.DbPracownik.ToList();
        }

        public bool CheckIfCorrectLoginPracownik(string email, string haslo, out Pracownik pracownik)
        {
            WypelnijListe();

            foreach (Pracownik pracownikFromList in ListaPracowników)
            {
                if (pracownikFromList.Haslo == haslo && pracownikFromList.Email == email)
                {
                    pracownik = pracownikFromList;
                    return true;
                }
            }

            pracownik = null;
            return false;
        }



        //to jeszcze będzie możliwo tylko dla uprawnionego pracownika
        public void ChangePassword(Pracownik pracownik, string noweHaslo)
        {
            //using (AppDbContext db = new AppDbContext())
            //{
            //    var pracownikFromDb = db.DbPracownik.Where(p => p.IdPracownik == pracownik.IdPracownik).FirstOrDefault();
            //    pracownikFromDb.Haslo = noweHaslo;
            //    db.SaveChanges();
            //}
        }
        public void ChangePersonalData(Pracownik pracownik, int stopienUprawnienia,string imie, string nazwisko, string dataUrodzenia, string plec, 
            string haslo, string email, string nrTelefonu, Wojewodztwa wojewodztwo, string miasto, string ulica, string nrDomu, string nrMieszkania, 
            string kodPocztowy, bool czyKlient, bool czyZarchiwizowany)
        {

        }

    }
}
