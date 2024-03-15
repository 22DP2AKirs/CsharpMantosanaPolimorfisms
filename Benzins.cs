using System;
public class Benzins : Degviela
{
    public Benzins(int autoDegvielasPaterinaEfektivitate, string dizeldegvielasTips)
    {
        /* Bendzīna varianti:  E95, E98*/
        nosaukums = "benzīns";
        dizeldegvielasTips.ToUpper();
        if (dizeldegvielasTips.Equals("E95"))
        {
            nosaukums = "Neste Futura 95";
            cenaParLitru = 1.68;
        }
        else if (dizeldegvielasTips.Equals("E98"))
        {
            nosaukums = "Neste Futura 98";
            cenaParLitru = 1.73;
        }
        else
        {
            nosaukums = "NoName";
            cenaParLitru = 0;
        }
        krasa = "dzeltanīgs";
        cenaParLitru = 2.04; // Dārgāks par dīzeli.
        this.autoDegvielasPaterinaEfektivitate = autoDegvielasPaterinaEfektivitate; // x litri par 100 km

    }
    
    /// Abstraktie override:
    public override double PateretaDegvielaParVienuKilometru()
    {
        /* Metode atgriež auto patēriņu (litros) par 1 kilometru
           Dīzeļdegviela ir par 20% efektīvāka par bendzīnu.  */
        return autoDegvielasPaterinaEfektivitate / 100.0;
    }
    
    public override void AprekinatDegvieluDistancei(int distanceKilometros)
    {
        /* Metode aprēķina un atgriež, cik daudz degvielas vajadzēs priekš 
           norādītās distances.                              */
        Console.WriteLine($"----------------Degviela priekš {distanceKilometros} km.-----------------");
        Console.WriteLine(PateretaDegvielaParVienuKilometru() * distanceKilometros + " Litri.");
    }
    
    /// Virtuālie override:
    public override void Informacija()
    {
        base.Informacija();
        Console.WriteLine("Degviela par 1 km.: " + PateretaDegvielaParVienuKilometru());
        Console.WriteLine("Sastāvs: dažādi ogļūdeņraži 100%.");
    }
}
