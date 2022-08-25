using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_ke_zkoušce
{
    internal class Uvod
    {
        public void VyvolejUvodniObrazovku()
        {
            Console.Clear();
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Evidence pojištěných");
            Console.WriteLine("----------------------------- \n");
            Console.WriteLine("Vyberte si akci:");
            Console.WriteLine("1 - Přidat nového pojištěného");
            Console.WriteLine("2 - Vypsat všechny pojištěné");
            Console.WriteLine("3 - Vyhledat pojištěného");
            Console.WriteLine("4 - Konec");
        }
    }
}
