using KinoProjekt.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinoProjekt.Model
{
    public class Pracownik : Konto
    {
        public Pracownik(int stopienUprawnienia,
            string imie, string nazwisko, string dataUrodzenia, string plec, string haslo, string email, string nrTelefonu,
            Wojewodztwa wojewodztwo, string miasto, string ulica, string nrDomu, string nrMieszkania, string kodPocztowy,
            bool czyKlient, bool czyZarchiwizowany)

            : base(imie, nazwisko, dataUrodzenia, plec, haslo, email, nrTelefonu, wojewodztwo, miasto, ulica, nrDomu, nrMieszkania, kodPocztowy, czyKlient, czyZarchiwizowany)
        {
            StopienUprawnienia = stopienUprawnienia;
        }

        public Pracownik(int idPracownik, int stopienUprawnienia,
            string imie, string nazwisko, string dataUrodzenia, string plec, string haslo, string email, string nrTelefonu,
            Wojewodztwa wojewodztwo, string miasto, string ulica, string nrDomu, string nrMieszkania, string kodPocztowy,
            bool czyKlient, bool czyZarchiwizowany)

            : base(imie, nazwisko, dataUrodzenia, plec, haslo, email, nrTelefonu, wojewodztwo, miasto, ulica, nrDomu, nrMieszkania, kodPocztowy, czyKlient, czyZarchiwizowany)
        {
            IdPracownik = idPracownik;
            StopienUprawnienia = stopienUprawnienia;
        }
        [Key]
        public int IdPracownik { get; set; }
        public int StopienUprawnienia { get; set; }
    }
}
