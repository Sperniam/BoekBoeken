namespace ConsoleApp1;

public abstract class Boek : IVoorwerpen
{
    public string Titel { get; set; }
    public string Auteur { get; set; }
    public static string Eigenaar { get;} = "VDAB";
    public double Aankoopprijs { get; set; }
    public Genre Genre { get; set; }
    public abstract double Winst { get; }
    
    public virtual void Gegevens()
    {
        Console.WriteLine($"Titel: {Titel}");
        Console.WriteLine($"Auteur: {Auteur}");
        Console.WriteLine($"Eigenaar: {Eigenaar}");
        Console.WriteLine($"Prijs: {Aankoopprijs} euro");
        Console.WriteLine($"Winst: {Winst.ToString("#.00")} euro");
        Console.WriteLine($"Genregegevens: \n Genrenaam: {Genre.Naam}\n Doelgroepgegevens: \n  Leeftijd: {Genre.Doelgroep.Leeftijd}\n  Categorie: {Genre.Doelgroep.Categorie}");
      
    }

}