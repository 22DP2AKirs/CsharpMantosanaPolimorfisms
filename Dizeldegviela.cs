using System;
public class Dizeldegviela : Degviela
{
    public Dizeldegviela(int autoDegvielasPaterinaEfektivitate)
    {
        // 20% Labāka efektivitāte.
        nosaukums = "dīzelis";
        krasa = "oranžs";
        cenaParLitru = 1.68;
        this.autoDegvielasPaterinaEfektivitate = autoDegvielasPaterinaEfektivitate;
    }
    
    /// Abstraktie override:
    public override void DemonstretEfektivitati(int distanceKilometros, int litriBaka)
    {
        Console.WriteLine($"----------- Efektivitāte uz {distanceKilometros} kilometriem -----------");
        Console.WriteLine($"0           {distanceKilometros * 0.25}           {distanceKilometros * 0.5}           {distanceKilometros * 0.75}           {distanceKilometros}");
        // 100%  --->  X %, tagad 100 - > 1 %
        // Dotie dati:
        /* 
        Distance,
        Litri auto bākā.
        
        */
        // 
        for (
        double i = AprekinatCikLitrusVajadzesPrieksDotasDistances(distanceKilometros) ; i > 0 ; i -= AprekinatCikLitrusVajadzesPrieksDotasDistances(distanceKilometros) * 0.1 * nobraucamieKilometriParLitruDegvielas()
        )
        {
            Console.Write("-");
        }
        
    }
    
    public override double AprekinatCikLitrusVajadzesPrieksDotasDistances(int distanceKilometros)
    {
        return nobraucamieKilometriParLitruDegvielas() * distanceKilometros;
    }
    
    
    public override double nobraucamieKilometriParLitruDegvielas()
    {
        // 20% efektīvāks par bendzīnu.
        double nobraucamieKilometriParLitruDegvielas = autoDegvielasPaterinaEfektivitate / 100.0;
        return nobraucamieKilometriParLitruDegvielas + nobraucamieKilometriParLitruDegvielas * 0.2;
    }
    
    /// Virtuālie override:
    public override void Informacija()
    {
        base.Informacija();
        Console.WriteLine("litrs par kilometru: " + nobraucamieKilometriParLitruDegvielas());
        Console.WriteLine("Sastāvs: alkāni 75%, aromātiskie ogļūdeņraži 25%.");
    }
}
