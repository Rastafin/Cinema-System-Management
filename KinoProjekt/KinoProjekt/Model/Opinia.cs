using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinoProjekt.Model
{
    public class Opinia
    {
        public Opinia(string tytul, string komentarz, DateTime data, int ocena, bool czyZarchiwizowany)
        {
            Tytul = tytul;
            Komentarz = komentarz;
            Data = data;
            Ocena = ocena;
            CzyZarchiwizowany = czyZarchiwizowany;
        }

        public Opinia(int idOpinia, string tytul, string komentarz, DateTime data, int ocena, bool czyZarchiwizowany)
        {
            IdOpinia = idOpinia;
            Tytul = tytul;
            Komentarz = komentarz;
            Data = data;
            Ocena = ocena;
            CzyZarchiwizowany = czyZarchiwizowany;
        }
        public Opinia(int idOpinia, Klient idKlient, Seans idSeans, string tytul, string komentarz, DateTime data, int ocena, bool czyZarchiwizowany)
        {
            IdOpinia = idOpinia;
            IdKlient = idKlient;
            IdSeans = idSeans;
            Tytul = tytul;
            Komentarz = komentarz;
            Data = data;
            Ocena = ocena;
            CzyZarchiwizowany = czyZarchiwizowany;
        } 

        [Key]
        public int IdOpinia { get; set; }


        public string Tytul { get; set; }
        public string Komentarz { get; set; }
        public DateTime Data { get; set;}
        public int Ocena { get; set; }
        public bool CzyZarchiwizowany { get; set; }

        //Relationships
        public Klient IdKlient { get; set; }
        public Seans IdSeans { get; set; }
    }
}
