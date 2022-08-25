using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_ke_zkoušce
{
    internal class Pojistovna
    {
        private KolekcePojistenych kolekcePojistenych;

        public Pojistovna()
        {
            kolekcePojistenych = new KolekcePojistenych();
        }

        //Výzva k zadaní dat
        private string ZjistiJmeno()
        {
            Console.WriteLine("Zadejte jméno pojištěného:");
            string jmeno;
            jmeno = Console.ReadLine();
            return jmeno;
        }
        private string ZjistiPrijmeni()
        {
            Console.WriteLine("Zadejte příjmení pojištěného:");
            string prijmeni;
            prijmeni = Console.ReadLine();
            return prijmeni;
        }
        private int ZjistiTelefon()
        {
            Console.WriteLine("Zadejte telefoní číslo:");
            int telefon;
            telefon = int.Parse(Console.ReadLine());
            return telefon;
        }
        private int ZjistiVek()
        {
            Console.WriteLine("Zadejte věk:");
            int vek;
            vek = int.Parse(Console.ReadLine());
            return vek;
        }
       

        public void PridejPojisteneho()
        {
            Console.WriteLine("\n");
            string jmeno = ZjistiJmeno();
            string prijmeni = ZjistiPrijmeni();
            int telefon = ZjistiTelefon();
            int vek = ZjistiVek();
            kolekcePojistenych.PridejPojisteneho(jmeno, prijmeni, telefon, vek);
        }
        // Vyhledá Pojištěného podle jména a příjmení
        public void VyhledejPojisteneho()
        {
            Console.WriteLine("\n");
            //Zadání jména uživatelem
            string jmeno = ZjistiJmeno();
            //Zadání příjmení uživatelem
            string prijmeni = ZjistiPrijmeni();
            //Vyhledání pojištěných
            List<Pojisteny> pojisteny = kolekcePojistenych.NajdiPojisteneho(jmeno, prijmeni);
            //Výpis Pojistěných
            if (pojisteny.Count() > 0)
            {
                Console.WriteLine("");
                foreach (Pojisteny p in pojisteny)
                    Console.WriteLine(p);
            }
            else
                //Nenalezeno
                Console.WriteLine("Pojištěný nenalezen");
        }
        //Vypíše všechny pojištěné v KolekciPojištěných
        public void VypisVsechnyPojistene()
        {
            kolekcePojistenych.VypisPojistenych();
        }

    }
}
