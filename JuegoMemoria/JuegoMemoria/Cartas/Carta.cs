using System;

namespace JuegoMemoria
{
    class Carta
    {
        int valor;
        const char Dorso = '█';
        public bool estaBocaArriba;

        public void DarVuelta()
        {
            estaBocaArriba = !estaBocaArriba;
        }
        public Carta(int valor_)
        {
            valor = valor_;

        }
        public char ObtenerRepresentacionVisual()
        {
            if (estaBocaArriba)
            {

                return char.Parse(valor.ToString());
            }
            else
            {
                return Dorso;
            }
        }
    }
}
