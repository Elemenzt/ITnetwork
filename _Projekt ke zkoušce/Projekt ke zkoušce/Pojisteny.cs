using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_ke_zkoušce
{
    internal class Pojisteny
    {
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public int Telefon { get; set; }
        public int Vek { get; set; }

        public Pojisteny(string jmeno, string prijmeni, int telefon, int vek)
        {
            this.Jmeno = jmeno;
            this.Prijmeni = prijmeni;
            this.Telefon = telefon;
            this.Vek = vek;
        }

        public override string ToString()
        {
            return String.Format("{0} {1} {2} {3}", Jmeno.PadRight(10), Prijmeni.PadRight(10), Vek.ToString().PadRight(5).PadLeft(5), Telefon);
                
        }
    }
}
