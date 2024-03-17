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
    public abstract void PircejuTabula(int maksimalaisPircejuSkDiena, int aptuvenieBakasIzmeri);
    public abstract void AprekinatDegvieluDistancei(int distanceKilometros);
    public abstract double PateretaDegvielaParVienuKilometru();
    
    /// Virtuālās:
    public virtual void Informacija() // Parāda informāciju par degvielu.
    {
        Console.WriteLine("--------------------Informācija-------------------------");
        Console.WriteLine("nosaukums: {0}, krasa: {1}, cena litrā: {2} EUR",
        nosaukums, krasa, cenaParLitru);
    }
    
    /// Parastās metodes:
    public void AprekinatCenuBraucienam(int distance)
    {
        Console.WriteLine($"-----------Cena priekš brauciena ({distance} km.)-------------");
        Console.WriteLine("Cena: " + Math.Round(cenaParLitru * (distance * PateretaDegvielaParVienuKilometru()), 2) + " Eiro.");
    }
    
    /// Palīgmetodes, kuras strādā tikai starp 'bērniem'.
    protected string PieliktAtstarpesPieTekstaBeigam(int maksimalaisSimboluSK, double vertiba)
    {
        string vertibaStr = vertiba.ToString();
        while (vertibaStr.Length < maksimalaisSimboluSK)
        {
            vertibaStr += " ";
        }
        return vertibaStr;
    }
    
    protected string AprekinatTabulasCenas(int tekstaIzmers, int maksimalaisPircejuSkDiena, int aptuvenieBakasIzmeri)
    {
        //         Metode(teksta izmērs  ; objekta cena par litru  ; cik pircēju būs tanī dienā  ; aptuvenais bākas izmērs, kas būs atnākušajiem pircējiem);
        return PieliktAtstarpesPieTekstaBeigam(tekstaIzmers, cenaParLitru * Project.rand.Next(maksimalaisPircejuSkDiena) * Project.rand.Next(aptuvenieBakasIzmeri - 10, aptuvenieBakasIzmeri + 1));
    }
}
