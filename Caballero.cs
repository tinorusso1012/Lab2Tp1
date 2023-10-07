using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpLab2
{
    internal class Caballero : Piezas
    {
        Form1 a;
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
        bool gano = false;
        bool Gano {get;set;}
    public Caballero(int posX, int posY, int nroJugador) : base(posX, posY, nroJugador)
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
