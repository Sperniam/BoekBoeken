namespace ConsoleApp1;

public class Doelgroep
{
    public int Leeftijd { get; set; }
    
    public string Categorie { get
    {
        if (Leeftijd <= 18)
        {
            return "Jeugd";

        } else return "Volwassen";
        
    }
    
    }

  

    public Doelgroep(int leeftijd)
    {
        Leeftijd = leeftijd;
    }

}