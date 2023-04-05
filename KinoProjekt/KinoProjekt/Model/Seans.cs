using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinoProjekt.Model
{
    public class Seans
    {
        public Seans(byte[] zdjecie, string tytul, string opis, int dlugosc, string data, string zajeteMiejsca)
        {
            Zdjecie = zdjecie;
            Tytul = tytul;
            Opis = opis;
            Dlugosc = dlugosc;
            Data = data;
            ZajeteMiejsca = zajeteMiejsca;
        }

        public Seans(int idSeans, byte[] zdjecie, string tytul, string opis, int dlugosc, string data, string zajeteMiejsca)
        {
            IdSeans = idSeans;
            Zdjecie = zdjecie;
            Tytul = tytul;
            Opis = opis;
            Dlugosc = dlugosc;
            Data = data;
            ZajeteMiejsca = zajeteMiejsca;
        }
        public Seans(int idSeans, List<Bilet> wykupioneBilety, List<Opinia> posiadaneOpinie, byte[] zdjecie, string tytul, string opis, int dlugosc, string data, string zajeteMiejsca, bool czyZarchowizowany)
        {
            IdSeans = idSeans;
            WykupioneBilety = wykupioneBilety;
            PosiadaneOpinie = posiadaneOpinie;
            Zdjecie = zdjecie;
            Tytul = tytul;
            Opis = opis;
            Dlugosc = dlugosc;
            Data = data;
            ZajeteMiejsca = zajeteMiejsca;
            CzyZarchiwizowany = czyZarchowizowany;
        }

        [Key]
        public int IdSeans { get; set; }
        public byte[]? Zdjecie { get; set; }
        public string Tytul { get; set; }
        public string Opis { get; set; }
        public int Dlugosc { get; set; } 
        public string Data { get; set; }
        public string ZajeteMiejsca { get; set; }
        public bool CzyZarchiwizowany { get; set; }

        //Relationships
        public List<Bilet> WykupioneBilety { get; set; }
        public List<Opinia> PosiadaneOpinie { get; set; }


    }
}
