using KinoProjekt.Data;
using KinoProjekt.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinoProjekt.Logic
{
    public class SerwisSeans
    {
        private readonly AppDbContext context;
        public SerwisSeans()
        {

        }
        public SerwisSeans(AppDbContext context)
        {
            this.context = context;
        }
        public void DodajSeans(byte[] zdjecie, string tytul, string opis, int dlugosc, string data, string zajeteMiejsca)
        {
            Seans seans = new Seans(zdjecie, tytul, opis, dlugosc, data, zajeteMiejsca);

            using AppDbContext context = new AppDbContext();

            context.DbSeans.Add(seans);
            context.SaveChanges();
        }

        public List<Seans> WyswietlSeans()
        {
            using (var conext = new AppDbContext())
            {
                var seans = conext.DbSeans.ToList();
                List<Seans> entity = new List<Seans>();
                foreach (var seanse in seans)
                {
                    entity.Add(seanse);
                }
                return entity;
            }
        }

        public int IloscSeans()
        {
            using (var conext = new AppDbContext())
            {
                var seans = conext.DbSeans.ToList();
                List<Seans> entity = new List<Seans>();
                foreach (var seansy in seans)
                {
                    entity.Add(seansy);

                }
                return entity.Count;

            }
        }
    }
}
