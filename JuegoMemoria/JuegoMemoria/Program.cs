﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoMemoria
{
    class Program
    {
        static void Main(string[] args)
        {
            Juego juego = new Juego();

            juego.GameLoop();
        }
    }
}
