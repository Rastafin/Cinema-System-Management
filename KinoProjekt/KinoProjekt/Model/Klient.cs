using KinoProjekt.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinoProjekt.Model
{
    public class Klient: Konto
    {
        public Klient(double stanKonta, string imie, string nazwisko, string dataUrodzenia, string plec, string haslo, string email, string nrTelefonu, Wojewodztwa wojewodztwo,
            string miasto, string ulica, string nrDomu, string nrMieszkania, string kodPocztowy, bool czyKlient, bool czyZarchiwizowany)
            : base(imie, nazwisko, dataUrodzenia, plec, haslo, email, nrTelefonu, wojewodztwo, miasto, ulica, nrDomu, nrMieszkania, kodPocztowy, czyKlient, czyZarchiwizowany) 
        {
            StanKonta = stanKonta;
        }

        public Klient(int idKlient, List<Bilet> kupioneBilety, double stanKonta,
            string imie, string nazwisko, string dataUrodzenia, string plec, string haslo, string email, string nrTelefonu,
            Wojewodztwa wojewodztwo, string miasto, string ulica, string nrDomu, string nrMieszkania, string kodPocztowy,
            bool czyKlient, bool czyZarchiwizowany)

            :base (imie, nazwisko, dataUrodzenia, plec,haslo, email, nrTelefonu, wojewodztwo, miasto, ulica, nrDomu, nrMieszkania, kodPocztowy, czyKlient, czyZarchiwizowany)
        {
            
            IdKlient = idKlient;
            KupioneBilety = kupioneBilety;
            StanKonta = stanKonta;
        }


       

        

  

        [Key]
        public int IdKlient { get; set; }
        public double StanKonta { get; set; }

        //Relationships
        public List<Bilet> KupioneBilety { get; set; }
    }
}
