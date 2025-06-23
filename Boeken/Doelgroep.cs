namespace ConsoleApp1;

public class Doelgroep
{
    public int Leeftijd {get; set;}

    public Categorie Categorie
    {
        get
        {
            if (Leeftijd <= 18)
                return Categorie.Jeugd;
            else
                return Categorie.Volwassen;
        }
    }

    public Doelgroep(int leeftijd)
    {
        Leeftijd = leeftijd;
    }

}