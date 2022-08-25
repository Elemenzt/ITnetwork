using Projekt_ke_zkoušce;

Uvod uvod = new Uvod();
Pojistovna pojistovna = new Pojistovna();

char volba = '0';

//hlavní cyklus
while (volba != '4')
{
    uvod.VyvolejUvodniObrazovku();
    volba = Console.ReadKey().KeyChar;
    //reakce na volbu
    switch (volba)
    {
        case '1':
            pojistovna.PridejPojisteneho();
            Console.WriteLine("\nData byla uložena .Pokračujte libovolnou klávesou... ");
            Console.ReadKey();
            break;
        case '2':
            pojistovna.VypisVsechnyPojistene();
            Console.WriteLine("\nPokračujte libovolnou klávesou... ");
            Console.ReadKey();
            break;
        case '3':
            pojistovna.VyhledejPojisteneho();
            Console.WriteLine("\nPokračujte libovolnou klávesou... ");
            Console.ReadKey();
            break;
        case '4':
            Console.WriteLine("\nLibovolnou klávesou ukončíte program...");
            Console.ReadKey();
            break;
        default:
            Console.WriteLine("\nNeplatná volba, stiskněte libovolnou klávesu a opakujte volbu.");
            Console.ReadKey();
            break;
    }
}

    Console.ReadKey();
