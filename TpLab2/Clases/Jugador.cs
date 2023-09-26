using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpLab2
{
    internal class Jugador
    {
        private string nombre;
        private int posicion;
        public int Posicion { get; private set; };
        private bool turno = true;
        public string Nombre { get; private set; }
        public int CantidadGanadas { get; set; }
        public Jugador() 
        {
            
        }
        public bool VerificarTurno() 
        {
            if (turno != false)
            {

            }
            return turno;
        }
        public void Jugar() 
        {
    
        
        }
    }
}
