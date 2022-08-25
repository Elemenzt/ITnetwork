using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_ke_zkoušce
{
    internal class KolekcePojistenych
    {
        //kolekce Pojistenych
        private List<Pojisteny> pojisteny;

        //Vytvoří novou instanci kolekciPojistenych
        public KolekcePojistenych()
        {
            pojisteny = new List<Pojisteny>();
        }

        //Přidá nového pojištěnýho do databáze
        public void PridejPojisteneho(string jmeno, string prijmeni, int telefon, int vek)
        {
            pojisteny.Add(new Pojisteny(jmeno, prijmeni, telefon, vek));
        }

        //vyhledá pojištěného
        public List<Pojisteny> NajdiPojisteneho(string jmeno, string prijmeni)
        {
            List<Pojisteny> nelezeny = new List<Pojisteny>();
            foreach(Pojisteny p in pojisteny)
            {
                if ((p.Prijmeni == prijmeni) && (p.Jmeno == jmeno))
                    nelezeny.Add(p);
            }
            return nelezeny;
        }

        //Vyhledá všechny pojištěné
        public void VypisPojistenych()
        {
            Console.WriteLine("\n");
            foreach (Pojisteny p in pojisteny)
            {
                Console.WriteLine("{0} {1} {2} {3}", p.Jmeno.PadRight(10), p.Prijmeni.PadRight(10), p.Vek.ToString().PadRight(5).PadLeft(5), p.Telefon);
                //Console.WriteLine(p.Jmeno + " " + p.Prijmeni + " " + p.Telefon + " " + p.Vek);
            }
        }
    }
}
