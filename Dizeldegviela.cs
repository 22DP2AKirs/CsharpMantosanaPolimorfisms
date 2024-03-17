using System;
public class Dizeldegviela : Degviela
{
    public Dizeldegviela(string dizeldegvielasTips, int autoDegvielasPaterinaEfektivitate = 10)
    {
        /* Dīzeļdevielas varianti:  95, 98, DD*/
        // 20% Labāka efektivitāte par bendzīnu.
        nosaukums = "Dīzelis ";
        dizeldegvielasTips.ToUpper();
        if (dizeldegvielasTips.Equals("95"))
        {
            nosaukums += "Neste Futura 95";
            cenaParLitru = 1.68;
        }
        else if (dizeldegvielasTips.Equals("98"))
        {
            nosaukums += "Neste Futura 98";
            cenaParLitru = 1.73;
        }
        else if (dizeldegvielasTips.Equals("DD"))
        {
            nosaukums += "Neste Futura D";
            cenaParLitru = 1.66;
        }
        else if (dizeldegvielasTips.Equals("PRO"))
        {
            nosaukums += "Neste Pro Diesel";
            cenaParLitru = 1.77;
        }
        else
        {
            nosaukums += "NoName";
            cenaParLitru = 0;
        }
        krasa = "Oranžs";
        this.autoDegvielasPaterinaEfektivitate = autoDegvielasPaterinaEfektivitate; // x litri par 100 km
    }
    
    // Aprēķini bendzīntankam.
    public override void PircejuTabula(int maksimalaisPircejuSkKatramPumpim, int aptuvenieBakasIzmeri)
    {
        if (maksimalaisPircejuSkKatramPumpim > 0 && aptuvenieBakasIzmeri > 15)
        {
            // Izveido objektus, lai aprēķinos ņemtu to cenas:
            Dizeldegviela D95 = new Dizeldegviela("95");
            Dizeldegviela D98 = new Dizeldegviela("98");
            Dizeldegviela DD = new Dizeldegviela("DD");
            Dizeldegviela PRO = new Dizeldegviela("PRO");
            
            // Sāk izvadīt tabulu:
            Console.WriteLine("-------Paredzētā peļņa no dīzeļa-------");
            Console.WriteLine("| Diena | Neste Futura 95 | Neste Futura 98 | Neste Futura D | Neste Pro Diesel |");
            for(int i = 0 ; i < 7 ; i++)
            {
                Console.WriteLine($"|   {i + 1}.  | {D95.AprekinatTabulasCenas(16, maksimalaisPircejuSkKatramPumpim, aptuvenieBakasIzmeri)}| {D98.AprekinatTabulasCenas(16, maksimalaisPircejuSkKatramPumpim, aptuvenieBakasIzmeri)}| {DD.AprekinatTabulasCenas(15, maksimalaisPircejuSkKatramPumpim, aptuvenieBakasIzmeri)}| {PRO.AprekinatTabulasCenas(17, maksimalaisPircejuSkKatramPumpim, aptuvenieBakasIzmeri)}|");
            }
        }
        else
        {
            Console.WriteLine("Pārāk maz pircēju vai pārāk mazs bākas izmērs!");
        }
    }
    
    // Aprēķini mašīnai.
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
