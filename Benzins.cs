using System;
public class Benzins : Degviela
{
    public Benzins(int autoDegvielasPaterinaEfektivitate)
    {
        nosaukums = "benzīns";
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
