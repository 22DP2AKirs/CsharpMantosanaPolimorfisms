using System;
public abstract class Degviela
{
    // Mainīgie (lauki):
    protected string nosaukums;
    protected string krasa;
    protected double cenaParLitru;
    protected int autoDegvielasPaterinaEfektivitate; // Cik auto patērē par 100 km.
    
    // Īpašības:
    public string Nosaukums { get => nosaukums; set => nosaukums = value; }
    public string Krasa { get => krasa; set => krasa = value; }
    public double CenaParLitru { get => cenaParLitru; set => cenaParLitru = value; }
    public int AutoDegvielasPaterinaEfektivitate { get => autoDegvielasPaterinaEfektivitate; set => autoDegvielasPaterinaEfektivitate = value; }
    
    // Metodes:
    /// Abstraktās:
    public abstract void AprekinatDegvieluDistancei(int distanceKilometros);
    public abstract double PateretaDegvielaParVienuKilometru();
    
    /// Virtuālās:
    public virtual void Informacija() // Parāda informāciju par degvielu.
    {
        Console.WriteLine("--------------------Informācija-------------------------");
        Console.WriteLine("nosaukums: {0}, krasa: {1}, cena litrā: {2} EUR",
        nosaukums, krasa, cenaParLitru);
    }
    
    /// Parastā metode:
    public void AprekinatCenuBraucienam(int distance)
    {
        Console.WriteLine($"-----------Cena priekš brauciena ({distance} km.)-------------");
        Console.WriteLine("Cena: " + Math.Round(cenaParLitru * (distance * PateretaDegvielaParVienuKilometru()), 2) + " Eiro.");
    }
}
