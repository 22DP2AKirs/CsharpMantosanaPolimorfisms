using System;
public abstract class Degviela
{
    // Mainīgie.
    protected string nosaukums;
    protected string krasa;
    protected double cenaParLitru;
    protected int autoDegvielasPaterinaEfektivitate; // Cik auto patērē par 100 km.
    // Metodes.
    /// Abstraktās:
    public abstract void DemonstretEfektivitati(int distanceKilometros); // Parāda cik lielu attālumu var nobraukt ar noteikto degvielu un tās daudzumu. /* 0 -------------::------ 100*/
    public abstract double AprekinatCikLitrusVajadzesPrieksDotasDistances(int distanceKilometros);
    public abstract double nobraucamieKilometriParLitruDegvielas();
    
    // Virtuālās:
    public virtual void Informacija() // Parāda informāciju par degvielu.
    {
        Console.WriteLine("--------------------Informācija-------------------------");
        Console.WriteLine("nosaukums: {0}, krasa: {1}, cena litrā: {2} EUR",
        nosaukums, krasa, cenaParLitru);
    }
}
