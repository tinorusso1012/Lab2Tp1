using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calabazos_Dragones.Clases
{
    internal class Experto : Intermedio
    {
        public Calabozo[] calabozo = new Calabozo[4];

        public Experto(int cantidadJugadores) : base(cantidadJugadores)
        {
        }

        public void CrearCalabozos()
        {
            for (int i = 0; i < 4; i++)
            {
                // Calabozo calabozonuevo = new Calabozo();
                //int posicion= new calabozonuevo.GenerarCalabozos();

            }

        }
    }
}
