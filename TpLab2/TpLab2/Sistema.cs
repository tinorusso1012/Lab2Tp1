using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpLab2
{
    internal class Sistema
    {
        private string Nombre;
        private int cantidadJuegos;
        public int CantidadJuegos{ get; set; }
        private ArrayList Ganadores= new ArrayList();
        private ArrayList Jugadores = new ArrayList();
        private Tablero tableroActual;

        public void AgregarJugador(Jugador njugador) 
        {
            Jugadores.Add(njugador);
        }
        public void VerGanadores(Jugador listaGanadores) 
        {
        
        }
        public void CrearTablero(ArrayList jugadores, int dificultad) 
        {
            
        }
        public void AgregarNuevoJuego() 
        {

            cantidadJuegos++;
        }
    }
}
