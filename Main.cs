using System;
/* Tēma: Degviela un naftas produkti;
   Klase: Degviela; 
   Apakšklases: Benzīns, Dīzeļdegviela.*/
class HelloWorld {
  static void Main() {
    // Atsauce uz objektu.
    Degviela degviela;
    
    degviela = new Benzins();
    degviela.Informacija();
    
    degviela = new Dizeldegviela();
    degviela.Informacija();
  }
}
