using System.Collections.Generic;

namespace JuegoMemoria
{
    static class GeneradorDeCartas
    {
        
        static public List<Carta> GenerarParesDeCartas(int cantidad)
        {
            List<Carta> naipes = new List<Carta>();

            for (int i = 0 ; i < cantidad; i++)
            {
                naipes.Add(new Carta(i));
                naipes.Add(new Carta(i));
            }
            
            return naipes;
        }
    }
}
