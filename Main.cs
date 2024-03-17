using System;
/* Tēma: Degviela un naftas produkti;
   Klase: Degviela; 
   Apakšklases: Benzīns, Dīzeļdegviela.*/
class Project {
  public static Random rand = new Random();
  static void Main() {
    // Atsauce uz objektu.
    Degviela degviela;
    
    // Bendzīns:
    degviela = new Benzins("E95", 9); // Patēriņš par 100 km.
    degviela.Informacija();
    degviela.AprekinatDegvieluDistancei(460);
    degviela.AprekinatCenuBraucienam(460);
    degviela.PircejuTabula(5, 40);
    
    // Dīzeļdegviela:
    degviela = new Dizeldegviela("95", 9); // Patēriņš par 100 km.
    degviela.Informacija();
    degviela.AprekinatDegvieluDistancei(460);
    degviela.AprekinatCenuBraucienam(460);
    degviela.PircejuTabula(5, 40);
  }
}
