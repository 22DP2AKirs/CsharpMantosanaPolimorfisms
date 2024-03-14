using System;
public class Benzins : Degviela
{
    public Benzins(int autoDegvielasPaterinaEfektivitate)
    {
        nosaukums = "benzīns";
        krasa = "dzeltanīgs";
        cenaParLitru = 1.68;
        this.autoDegvielasPaterinaEfektivitate = autoDegvielasPaterinaEfektivitate;

    }
    
    /// Abstraktie override:
    public override void DemonstretEfektivitati(int distanceKilometros)
    {
        
    }
    
    public override double nobraucamieKilometriParLitruDegvielas()
    {
        return autoDegvielasPaterinaEfektivitate / 100.0;
    }
    
    public override double AprekinatCikLitrusVajadzesPrieksDotasDistances(int distanceKilometros)
    {
        Console.WriteLine(nobraucamieKilometriParLitruDegvielas() * distanceKilometros);
        return nobraucamieKilometriParLitruDegvielas() * distanceKilometros;
    }
    
    /// Virtuālie override:
    public override void Informacija()
    {
        base.Informacija();
        Console.WriteLine("litrs par kilometru: " + nobraucamieKilometriParLitruDegvielas());
        Console.WriteLine("Sastāvs: dažādi ogļūdeņraži 100%.");
    }
}
