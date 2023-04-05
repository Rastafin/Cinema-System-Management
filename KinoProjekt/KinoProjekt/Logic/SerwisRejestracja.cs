using KinoProjekt.Data;
using KinoProjekt.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinoProjekt.Logic
{
    public class SerwisRejestracja
    {
        public void Rejestracja(double stanKonta, string imie, string nazwisko, string dataUrodzenia, string plec, string haslo, string email, string nrTelefonu, Wojewodztwa wojewodztwo,
            string miasto, string ulica, string nrDomu, string nrMieszkania, string kodPocztowy, bool czyKlient, bool czyZarchiwizowany)
        {
            Klient klient = new Klient(stanKonta, imie, nazwisko, dataUrodzenia, plec, haslo, email, nrTelefonu, wojewodztwo, miasto, ulica, nrDomu, nrMieszkania, kodPocztowy, czyKlient, czyZarchiwizowany);

            using AppDbContext context = new AppDbContext();

            context.DbKlient.Add(klient);
            context.SaveChanges();
        }
    }
}
