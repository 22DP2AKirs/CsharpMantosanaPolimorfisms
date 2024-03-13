using System;
public abstract class Degviela
{
    // Mainīgie.
    protected string nosaukums;
    protected string krasa;
    protected double cenaParLitru;
    // Metodes.
    /// Abstraktās:
    // public abstract void IzvaditDegvielasSastavu(); // Procentuāli izvada no kā ir veidota degviela kā recepte.
    public abstract void DemonstretEfektivitati(); // Parāda cik lielu attālumu var nobraukt ar noteikto degvielu un tās daudzumu. /* 0 -------------::------ 100*/
    public abstract void ParbauditIespejuNobrauktVisuDistanci(int distanceMetros);
    public abstract double nobraucamieMetriParLitru();
    // Virtuālās:
    public virtual void Informacija() // Parāda informāciju par degvielu.
    {
        Console.WriteLine("nosaukums: {0}, krasa: {1}, cena litrā: {2} EUR",
        nosaukums, krasa, cenaParLitru);
    }
}
