using System;
public class Dizeldegviela : Degviela
{
    public Dizeldegviela()
    {
        nosaukums = "dīzelis";
        krasa = "oranžs";
        cenaParLitru = 1.68;
        // Dīzeļdegviela: tas pats.
    }
    
    public override void DemonstretEfektivitati()
    {
        
    }
    
    public override void ParbauditIespejuNobrauktVisuDistanci(int distanceMetros)
    {
        
    }
    
    public override double nobraucamieMetriParLitru()
    {
        return 0.0;
    }
}
