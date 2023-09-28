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
        private int cantidadJuegos;
        public int CantidadJuegos
        {
            get
            {
                return cantidadJuegos;
            }
            private set
            {
                cantidadJuegos = value;
            }
        }
        private ArrayList listaGanadores;
        private ArrayList listaJugadores;
        public ArrayList listaDragones;
        public ArrayList ListaJugadores
        {
            get
            {
                return listaJugadores;
            }
            private set
            {
                listaJugadores = value;
            }
        }
        private Tablero tableroActual;

        private int cantidadJugadores;
        private int nroRondas;

        public Sistema() //Inicializa las variables de clase
        {
            cantidadJuegos = 0;
            listaGanadores = new ArrayList();
            listaJugadores = new ArrayList();
            listaDragones= new ArrayList();
            tableroActual = null;
            cantidadJugadores = 0;
            nroRondas = 1;
        }

        public bool AgregarJugador(int nroJugador, string nombreJugador) //Recibe los parametros necesarios para crear un jugador y lo agrega al arraylist
        {
            bool agregado = false;
            if (listaJugadores.Count < 5)
            {
                Jugador jugador = new Jugador(nroJugador, nombreJugador);
                listaJugadores.Add(jugador);
                agregado = true;
            }
            return agregado;
        }
        public bool AgregarDragon(int nroDragon,  string nombreDragon) 
        {
            bool agregado = false;
            if (listaJugadores.Count < 5)
            {
                //Dragon dragon = new Piezas(posX,posY,nroDragon);
                //listaJugadores.Add(dragon);
                agregado = true;
            }
            return agregado;
        }
        public ArrayList VerGanadores() //Mostramos un listado de los ganadores
        {
            return listaGanadores;
        }
        public void CrearTablero(int dificultad) //Segun la dificultad elegida creamos un tablero
        {
            cantidadJugadores = listaJugadores.Count;
            switch (dificultad)
            {
                case 1:
                    tableroActual = new Basico(cantidadJugadores);
                    break;
                case 2:
                    tableroActual = new Intermedio(cantidadJugadores);
                    break;
                default:
                    tableroActual = new Experto(cantidadJugadores);
                    break;
            }
        }
        public void AgregarNuevoJuego()
        {
            cantidadJuegos++;
        }

        public string ObtenerTablero(int nroJugador)
        {
            //string[] tablero = tableroActual.MostrarTablero();
            string tablero = tableroActual.MostrarTablero(nroJugador);

            return tablero;
        }

        //Jugada

        //En una ronda cada jugador lanza su dado
        public bool Jugar(int nroJugador, int movimiento)
        {
            bool jugada = tableroActual.MoverPieza(nroJugador, movimiento);
            return jugada;
        }

        public int NuevaRonda()
        {
            nroRondas++;

            foreach (Jugador j in listaJugadores)
            {
                j.NuevaRonda();
            }

            return nroRondas;
        }
    }
}
