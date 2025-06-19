namespace ConsoleApp1;

public class Boekenrek : IVoorwerpen
{
    public double Hoogte { get; set; }
    public double Breedte { get; set; }
    public double Aankoopprijs { get; set; }
    
    
    
    public void Gegevens()
    {
        Console.WriteLine("Boekenrek");
        Console.WriteLine("---------");
        Console.WriteLine($"Breedte = {Breedte} cm");
        Console.WriteLine($"Boekenrek: Hoogte = {Hoogte} cm,");
        Console.WriteLine($"Aankoopprijs = {Aankoopprijs}");
        
    }

    public double Winst { get; set; }
}