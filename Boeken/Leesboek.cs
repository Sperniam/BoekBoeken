namespace ConsoleApp1;

public class Leesboek : Boek
{
    
    public string Onderwerp { get; set; }

    public override double Winst { get { return Aankoopprijs * 1.5; } }
    
    

    public override void Gegevens()
    {
        Console.WriteLine();
        Console.WriteLine("Leesboek");
        Console.WriteLine("--------");
        base.Gegevens();
        Console.WriteLine($"Onderwerp: {Onderwerp}");
        Console.WriteLine();
        
    }
}