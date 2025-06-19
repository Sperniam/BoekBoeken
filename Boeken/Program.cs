using ConsoleApp1;

IVoorwerpen[] voorwerpen = new IVoorwerpen[3];

voorwerpen[0] = new Leesboek
{
    Titel = "Harry Potter",
    Auteur = "J.K Rowling",
    Aankoopprijs = 20,
    Genre = new Genre("fictie"),
    Onderwerp = "toveren"
};

voorwerpen[1] = new Woordenboek
{
    Titel = "Vandale",
    Auteur = "Kramers",
    Aankoopprijs = 30,
    Genre = new Genre("Taal"),
    Taal = "Nederlands - Engels"
};

voorwerpen[2] = new Boekenrek
{
    Hoogte = 120,
    Breedte = 80,
    Aankoopprijs = 50
};



foreach (var item in voorwerpen)
{
    item.Gegevens();
    
}