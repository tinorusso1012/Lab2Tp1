using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpLab2
{
    internal class Calabozo:Piezas
    {
        public Calabozo(int posX, int posY, int nroJugador) : base(posX, posY, nroJugador)
        {
        }
        public int GenerarCalabozos() 
        {
            Random random = new Random();
            int posicion = random.Next(0, 49);
            return posicion;
        }
        public override void MoverPieza(int x, int y)
        {
           
        }
    }
}
