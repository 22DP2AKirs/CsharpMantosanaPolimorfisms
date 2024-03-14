using System;
/* Tēma: Degviela un naftas produkti;
   Klase: Degviela; 
   Apakšklases: Benzīns, Dīzeļdegviela.*/
class HelloWorld {
  static void Main() {
    // Atsauce uz objektu.
    Degviela degviela;
    
    degviela = new Benzins(5);
    degviela.Informacija();
    degviela.DemonstretEfektivitati(100);
    
    degviela = new Dizeldegviela(50);
    degviela.Informacija();
    degviela.DemonstretEfektivitati(500);
  }
}
