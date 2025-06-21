using ConsoleApp1;

IVoorwerpen[] voorwerpen = new IVoorwerpen[3];

voorwerpen[0] = new Leesboek
{
    Titel = "Harry Potter",
    Auteur = "J.K Rowling",
    Aankoopprijs = 20,
    Genre = new Genre("fictie",new Doelgroep(15)),
    Onderwerp = "toveren"
};


voorwerpen[1] = new Woordenboek
{
    Titel = "Vandale",
    Auteur = "Kramers",
    Aankoopprijs = 100,
    Genre = new Genre("vreemd",new Doelgroep(20)),
    Taal = "NL-E"
};

voorwerpen[2] = new Boekenrek
{
    Hoogte = 3,
    Breedte = 2.5,
    Aankoopprijs = 200
};

double winstberekening = 0;

foreach (var voorwerp in voorwerpen)
{
    voorwerp.Gegevens();
    winstberekening += voorwerp.Winst;
}

Console.WriteLine();
Console.WriteLine("-------------------------------------");
Console.WriteLine($"Totale winst: {winstberekening} euro");
