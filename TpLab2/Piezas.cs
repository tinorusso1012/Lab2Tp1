using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpLab2
{
    abstract class Piezas
    {
        public int PosicionX { get; set; } //Ubicacion de la imagen en X
        public int PosicionY { get; set; } //Ubicacion de la imagen en Y

        public int Casillero { get; set; }

        private int nroJugador;
        public int NroJugador
        {
            get
            {
                return nroJugador;
            }
            private set
            {
                nroJugador = value;
            }
        }
        public Piezas(int posX, int posY, int nroJugador)
        {
            this.PosicionX = posX;        //Ubica la pieza
            this.PosicionY = posY;        //en el plano de juego
            this.Casillero = 0;
            this.nroJugador = nroJugador;
        }
        public abstract void MoverPieza(int x, int y); //Modifica las coordenadas de la pieza en el plano de juego

    }
}
