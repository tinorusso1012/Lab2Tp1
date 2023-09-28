using Calabazos_Dragones.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calabazos_Dragones.Clases
{
    public class Caballero : Piezas
    {
        //private int nroJugador;
        //public int NroJugador
        //{
        //    get
        //    {
        //        return nroJugador;
        //    }
        //    private set
        //    {
        //        nroJugador = value;
        //    }
        //}
        public Caballero(int posX, int posY, int nroJugador) : base(posX, posY,nroJugador)
        {
            //nroJugador = NroJugador; //Asigna el numero del jugador a la pieza
        }

        public override void MoverPieza(int x, int y)
        {
            PosicionX = x;
            PosicionY = y;
        }
    }
}
