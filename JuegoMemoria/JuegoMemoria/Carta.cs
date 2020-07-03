namespace JuegoMemoria
{
    class Carta
    {
        int valor;
        const char Dorso = '█';
        public bool estaBocaArriba;

        public  void DarVuelta()
        {
            estaBocaArriba = !estaBocaArriba;
        } 
        public  Carta (int valor_)
        {
            valor = valor_;

        }
    }
}
