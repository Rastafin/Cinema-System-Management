using KinoProjekt.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinoProjekt.Model
{
    public class Konto
    {
        public Konto(string imie, string nazwisko, string dataUrodzenia, string plec, string haslo, string email, string nrTelefonu,
            Wojewodztwa wojewodztwo, string miasto, string ulica, string nrDomu,  string nrMieszkania, string kodPocztowy, 
            bool czyKlient, bool czyZarchiwizowany)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            DataUrodzenia = dataUrodzenia;
            Plec = plec;
            Haslo = haslo;
            Email = email;
            NrTelefonu = nrTelefonu;
            Wojewodztwo = wojewodztwo;
            Miasto = miasto;
            Ulica = ulica;
            NrDomu = nrDomu;
            NrMieszkania = nrMieszkania;
            KodPocztowy = kodPocztowy;
            CzyKlient = czyKlient;
            CzyZarchiwizowany = czyZarchiwizowany;
        }

        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string DataUrodzenia { get; set; }
        public string Plec { get; set; }
        public string Haslo { get; set; }
        public string Email { get; set; }
        public string NrTelefonu { get; set; }
        public Wojewodztwa Wojewodztwo { get; set; }
        public string Miasto { get; set; }
        public string Ulica { get; set; }
        public string NrDomu { get; set; }
        public string NrMieszkania { get; set; }
        public string KodPocztowy { get; set; }
        public bool CzyKlient { get; set; }
        public bool CzyZarchiwizowany { get; set; }
    }
}
