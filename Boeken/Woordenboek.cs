namespace ConsoleApp1;

public class Woordenboek : Boek
{
    
    public string Taal { get; set; }
    
    public double Winst { get; set; }


    public override void Gegevens()
    {
        Console.WriteLine("Woordenboek");
        Console.WriteLine("-----------");
        base.Gegevens();
        Console.WriteLine($"Taal: {Taal}");
        Console.WriteLine();

    }

   

    
}