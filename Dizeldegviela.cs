using System;
public class Dizeldegviela : Degviela
{
    public Dizeldegviela(int autoDegvielasPaterinaEfektivitate)
    {
        // 20% Labāka efektivitāte par bendzīnu.
        nosaukums = "dīzelis";
        krasa = "oranžs";
        cenaParLitru = 1.82; // Lētāks par bendzīnu.
        this.autoDegvielasPaterinaEfektivitate = autoDegvielasPaterinaEfektivitate; // x litri par 100 km
    }
    
    /// Abstraktie override:
    public override void AprekinatDegvieluDistancei(int distanceKilometros)
    {
        /* Metode aprēķina un izvada, cik daudz degvielas vajadzēs priekš 
           norādītās distances.                              */
        Console.WriteLine($"----------------Degviela priekš {distanceKilometros} km.-----------------");
        Console.WriteLine(PateretaDegvielaParVienuKilometru() * distanceKilometros + " Litri.");
    }
    
    
    public override double PateretaDegvielaParVienuKilometru()
    {
        /* Metode atgriež auto patēriņu (litros) par 1 kilometru
           Dīzeļdegviela ir par 20% efektīvāka par bendzīnu.  */
        double autoPaterinsParVienuKilometru = autoDegvielasPaterinaEfektivitate / 100.0;
        return autoPaterinsParVienuKilometru - autoPaterinsParVienuKilometru * 0.2; // Dīzeļdegvielai + 20% efektivitāte, tātad patērīņš - 20%
    }
    
    /// Virtuālie override:
    public override void Informacija()
    {
        base.Informacija();
        Console.WriteLine("Degviela par 1 km.: " + PateretaDegvielaParVienuKilometru());
        Console.WriteLine("Sastāvs: alkāni 75%, aromātiskie ogļūdeņraži 25%.");
    }
}
