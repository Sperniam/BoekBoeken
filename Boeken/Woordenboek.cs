namespace ConsoleApp1;

public class Woordenboek : Boek
{
    
    public string Taal { get; set; }
    
    public override double Winst
    {
        get { return Aankoopprijs * 1.75;}
    }


    public override void Gegevens()
    {
        Console.WriteLine("Woordenboek");
        Console.WriteLine("-----------");
        base.Gegevens();
        Console.WriteLine($"Taal: {Taal}");
        Console.WriteLine();

    }

   

    
}