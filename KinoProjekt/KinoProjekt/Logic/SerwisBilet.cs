using KinoProjekt.Data;
using KinoProjekt.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinoProjekt.Logic
{
    public class SerwisBilet
    {

        public void DodajBilet(Klient klient, Seans seans, string imie, string nazwisko, double cena, string siedzenie)
        {
            //Bilet bilet = new Bilet(seans.IdSeans ,klient.IdKlient, imie, nazwisko, cena, siedzenie);
            Bilet bilet = new Bilet(klient.IdKlient, seans.IdSeans, imie, nazwisko, cena, siedzenie);


            using AppDbContext context = new AppDbContext();

            context.DbBilet.Add(bilet);
            context.SaveChanges();

        }
    }
}
