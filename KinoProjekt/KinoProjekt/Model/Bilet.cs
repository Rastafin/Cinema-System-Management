using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinoProjekt.Model
{
    public class Bilet
    {
        public Bilet(string imie, string nazwisko, double cena, string siedzenie)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            Cena = cena;
            Siedzenie = siedzenie;
        }


        public Bilet(int idKlient, int idSeans, string imie, string nazwisko, double cena, string siedzenie)
        {
            IdKlient = idKlient;
            IdSeans = idSeans;
            Imie = imie;
            Nazwisko = nazwisko;
            Cena = cena;
            Siedzenie = siedzenie;
        }


        public Bilet(int idBilet, int idKlient, int idSeans, string imie, string nazwisko, double cena, string siedzenie)
        {
            IdBilet = idBilet;
            IdKlient = idKlient;
            IdSeans = idSeans;
            Imie = imie;
            Nazwisko = nazwisko;
            Cena = cena;
            Siedzenie = siedzenie;
        }





        [Key]
        public int IdBilet { get; set; }

        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public double Cena { get; set; }
        public string Siedzenie { get; set; }

        //Relationships
        public int IdKlient { get; set; }
        [ForeignKey("IdKlient")]
        public Klient klient { get; set; }
        public int IdSeans { get; set; }
        [ForeignKey("IdSeans")]
        public Seans seans { get; set; }

    }
}
