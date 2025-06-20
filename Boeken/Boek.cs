namespace ConsoleApp1;

public class Boek : IVoorwerpen
{
    public string Titel { get; set; }
    public string Auteur { get; set; }
    public string Eigenaar { get;} = "VDAB";
    public double Aankoopprijs { get; set; }
    public Genre Genre { get; set; }
    public virtual double Winst { get; set; }
    
    public virtual void Gegevens()
    {
        Console.WriteLine($"Titel: {Titel}");
        Console.WriteLine($"Auteur: {Auteur}");
        Console.WriteLine($"Eigenaar: {Eigenaar}");
        Console.WriteLine($"Prijs: {Aankoopprijs} euro");
        Console.WriteLine($"Winst: {Winst.ToString("#.00")} euro");
        Console.WriteLine($"Genregegevens: {Genre.Naam}");
      
    }

}