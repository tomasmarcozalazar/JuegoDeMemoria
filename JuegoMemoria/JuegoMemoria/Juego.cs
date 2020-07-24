using System;
using System.Collections.Generic;

namespace JuegoMemoria
{
    class Juego
    {
        public void GameLoop()
        {
            bool noTermina = true;
            List<Carta> naipes = GeneradorDeCartas.GenerarParesDeCartas(8);
            int indice = 0;

            for(int i=0; i < 4; i++)
            {
                
                for(int j = 0; j<4; j++)
                {
                    Console.Write(naipes[indice].ObtenerRepresentacionVisual());
                    Console.Write(" ");
                    indice++;

                }
                Console.WriteLine();
                Console.WriteLine();
            }
            Console.WriteLine("eliga Una carta");
            int Usuario = int.Parse(Console.ReadLine());
            naipes[Usuario].DarVuelta();

            Console.WriteLine(naipes[Usuario].ObtenerRepresentacionVisual());
            




        }
        
    }
}
