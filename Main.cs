using System;
/* Tēma: Degviela un naftas produkti;
   Klase: Degviela; 
   Apakšklases: Benzīns, Dīzeļdegviela.*/
class HelloWorld {
  static void Main() {
    // Atsauce uz objektu.
    Degviela degviela;
    
    // Bendzīns:
    degviela = new Benzins(9); // Patēriņš par 100 km.
    degviela.Informacija();
    degviela.AprekinatDegvieluDistancei(460);
    degviela.AprekinatCenuBraucienam(460);
    
    // Dīzeļdegviela:
    degviela = new Dizeldegviela(9); // Patēriņš par 100 km.
    degviela.Informacija();
    degviela.AprekinatDegvieluDistancei(460);
    degviela.AprekinatCenuBraucienam(460);
  }
}
