using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinoProjekt.Model
{
    public class xTransakcjaNieaktywne
    {
        public xTransakcjaNieaktywne(int iD, DateTime data, double kwota, int wlasciciel, int iDBiletu, string tytul, string komentarz, bool wykonana)
        {
            ID = iD;
            Data = data;
            Kwota = kwota;
            Wlasciciel = wlasciciel;
            IDBiletu = iDBiletu;
            Tytul = tytul;
            Komentarz = komentarz;
            Wykonana = wykonana;
        }

        public int ID { get; set; }
        public DateTime Data { get; set; }
        public double Kwota { get; set; }
        public int Wlasciciel { get; set; }
        public int IDBiletu { get; set; }

        public string Tytul { get; set; }

        public string Komentarz { get; set; }
        public bool Wykonana { get; set; }
    }
}
