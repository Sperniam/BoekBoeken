namespace ConsoleApp1;

public class Doelgroep
{
    public int Leeftijd { get; set; }
    
    public string Categorie { get
    {
        if (Leeftijd <= 18)
        {
            return Categorie = "Jeugd";

        } else return Categorie = "Volwassen";
        
    }
    set {}
    }

  

    public Doelgroep(int leeftijd)
    {
        string categorie = Categorie;
        Leeftijd = leeftijd;
        Categorie = categorie;
        
    }

}