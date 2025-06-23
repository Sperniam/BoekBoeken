namespace ConsoleApp1;

public class Genre
{
    public string Naam { get; set; }
    
    public Doelgroep Doelgroep { get; }

    public Genre(string naam, Doelgroep doelgroep)
    {
        Naam = naam;
        Doelgroep = doelgroep;
    }
    
}