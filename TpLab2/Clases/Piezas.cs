using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpLab2
{
    internal class Piezas
    {
        public int PosicionX { get; set; }
        public int PosicionY { get; set; }
        public Piezas(int posX, int posY) 
        {
            this.PosicionX = posX;
            this.PosicionY = posY;
        }
        public virtual void MoverPieza(int x, int y) 
        {
        
        }

    }
}
