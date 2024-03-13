using System;
public class Benzins : Degviela
{
    public Benzins()
    {
        nosaukums = "benzīns";
        krasa = "dzeltanīgs";
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
