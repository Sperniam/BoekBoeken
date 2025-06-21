namespace ConsoleApp1;

public class Boekenrek : IVoorwerpen
{
    public double Hoogte { get; set; }
    public double Breedte { get; set; }
    public double Aankoopprijs { get; set; }
    
    public double Winst
    {
        get { return Aankoopprijs*2;}  
         set { Aankoopprijs = value; }
    }
    
    public void Gegevens()
    {
        Console.WriteLine("Boekenrek");
        Console.WriteLine("---------");
        Console.WriteLine($"Breedte = {Breedte} cm");
        Console.WriteLine($"Hoogte = {Hoogte} cm");
        Console.WriteLine($"Aankoopprijs = {Aankoopprijs} euro");
        Console.WriteLine($"Winst = {Winst} euro");
        
    }

}