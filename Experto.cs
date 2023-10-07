using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpLab2
{
    internal class Experto:Intermedio
    {
        public Calabozo[] calabozo = new Calabozo[4];
        public Experto(int cantidadJugadores) : base(cantidadJugadores) 
        {
        }
        public void CrearCalabozos() 
        {
            for (int i = 0; i < 4; i++) 
            {

            
            }

        }
    }
}
