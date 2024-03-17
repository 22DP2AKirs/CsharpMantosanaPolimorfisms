using System;
public class Benzins : Degviela
{
    public Benzins(string dizeldegvielasTips, int autoDegvielasPaterinaEfektivitate = 10)
    {
        /* Bendzīna varianti:  E95, E98*/
        // Dārgāks par dīzeli.
        nosaukums = "Benzīns ";
        dizeldegvielasTips.ToUpper();
        if (dizeldegvielasTips.Equals("E95"))
        {
            nosaukums += "E95";
            cenaParLitru = 1.92;
        }
        else if (dizeldegvielasTips.Equals("E98"))
        {
            nosaukums += "E98";
            cenaParLitru = 1.99;
        }
        else
        {
            nosaukums = "NoName";
            cenaParLitru = 0;
        }
        krasa = "Dzeltanīgs";
        this.autoDegvielasPaterinaEfektivitate = autoDegvielasPaterinaEfektivitate; // x litri par 100 km
    }
     
    // Aprēķini bendzīntankam.
    /// Abstraktie override:
    public override void PircejuTabula(int maksimalaisPircejuSkKatramPumpim, int aptuvenieBakasIzmeri)
    {
        if (maksimalaisPircejuSkKatramPumpim > 0 && aptuvenieBakasIzmeri > 15)
        {
            // Izveido objektus, lai aprēķinos ņemtu to cenas:
            Benzins E95 = new Benzins("E95");
            Benzins E98 = new Benzins("E98");
            
            // Sāk izvadīt tabulu:
            Console.WriteLine("-------Paredzētā peļņa no benzīna-------");
            Console.WriteLine("| Diena |   E95   |   E98   |");
            for(int i = 0 ; i < 7 ; i++)
            {
                Console.WriteLine($"|   {i + 1}.  | {E95.AprekinatTabulasCenas(8, maksimalaisPircejuSkKatramPumpim, aptuvenieBakasIzmeri)}| {E98.AprekinatTabulasCenas(8, maksimalaisPircejuSkKatramPumpim, aptuvenieBakasIzmeri)}|");
            }
        }
        else
        {
            Console.WriteLine("Pārāk maz pircēju vai pārāk mazs bākas izmērs!");
        }
    }
    
    // Aprēķini mašīnai.
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
    
    // Virtuālie override:
    public override void Informacija()
    {
        base.Informacija();
        Console.WriteLine("Degviela par 1 km.: " + PateretaDegvielaParVienuKilometru());
        Console.WriteLine("Sastāvs: dažādi ogļūdeņraži 100%.");
    }
}
