// See https://aka.ms/new-console-template for more information

using System.Text;
using Diary;

Zaznam zaznam = new Zaznam();

void VytiskniMenu()
{
    Console.Clear();

    Console.WriteLine("-------------------------------------------------------");
    Console.WriteLine("Deník se ovládá následujícími příkazy:");
    Console.WriteLine("- predchozi: Přesunutí na předchozí záznam");
    Console.WriteLine("- dalsi: Přesunutí na další záznam");
    Console.WriteLine("- novy: Vytvoření nového záznamu");
    Console.WriteLine("- uloz: Uložení vytvořeného záznamu");
    Console.WriteLine("- smaz: Odstranění záznamu");
    Console.WriteLine("- zavri: Zavření deníku");
    Console.WriteLine("-------------------------------------------------------\n");
}


string prechozi = "predchozi";
string dalsi = "dalsi";
string novy = "novy";
string uloz = "uloz";
string smaz = "smaz";
string zavri = "zavri";
int pocetZaznamu = 0;
bool ukazZaznam = false;

while (true)
{
    VytiskniMenu();
    Console.WriteLine($"Počet záznamů: {pocetZaznamu}");
    Console.WriteLine();
    if (ukazZaznam)
    {
        if (zaznam != null)
        {
            zaznam.ZobrazAktualniZaznam();
            Console.WriteLine("-------------------------------------------------------\n");
        }
    }
    Console.Write("Zadej příkaz:");
    string vstup = Console.ReadLine().Trim().ToLower();


    if (vstup == zavri)
    {
        Console.WriteLine("Dekujeme za pouzivani aplikace.");
        break;
    }

    if (vstup == prechozi)
    {
        zaznam.PredchoziZaznam();
    }

    else if (vstup == dalsi)
    {
        zaznam.DalsiZaznam();
    }

    else if (vstup == novy)
    {
        Console.Clear();
        VytiskniMenu();
        DateTime datum;
        Console.Write($"Zadej datum: ");
        while (!DateTime.TryParse(Console.ReadLine(), out datum))
            Console.Write("Zadal jste spatny format.");

        StringBuilder text = new StringBuilder();
        Console.WriteLine($"Text:");
        while (true)
        {
            string line = Console.ReadLine();
            // pokud uzivatel zada uloz ukonci smycku
            if (line.Trim().ToLower() == uloz) break;

            // prida text do promene text
            text.Append(line + "\n");
        }

        zaznam.PridejZaznam(datum, text.ToString());
        pocetZaznamu++;

        if (vstup == uloz)
        {
            zaznam.PridejZaznam(datum, text.ToString());
        }

        ukazZaznam = true;
    }

    if (vstup == smaz)
    {
        Console.Clear();
        VytiskniMenu();
        zaznam.ZobrazAktualniZaznam();
        Console.WriteLine("-------------------------------------------------------\n");
        Console.WriteLine($"\nPro odstranění tohoto záznamu stiskni \"a\", pro zrušení jiný znak.");
        char znakProPotvrzeni = Console.ReadKey().KeyChar;
        if (znakProPotvrzeni == 'a')
        {
            zaznam.VymazZaznam();
            if (pocetZaznamu > 0)
            {
                pocetZaznamu--;
            }
        }
        else
            continue;
    }
}