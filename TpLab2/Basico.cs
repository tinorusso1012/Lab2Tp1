using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace TpLab2
{
    internal class Basico:Tablero
    {
        public Basico(int cantidadJugadores) //Inicializamos el tablero en modo basico segun la cantidad de jugadores
        {
            piezas = new ArrayList(cantidadJugadores);
            CrearCaballeros(cantidadJugadores);
        }
        public void CrearCaballeros(int cantidadJugadores)
        {
            Caballero nuevo; //Reservamos espacio para un caballero

            for (int i = 0; i < cantidadJugadores; i++) //Creamos caballeros segun la cantidad de jugadores
            {
                nuevo = new Caballero(0, 0, i + 1); //Como i arranca en 0, le sumamos 1 y se asigna ese numero de jugador al primer caballero.
                piezas.Add(nuevo);              //Guardamos el caballero en el arreglo de piezas.
            }
        }
        public override bool MoverPieza(int jugador, int movimiento) //Buscamos las piezas del jugador y las movemos
        {
            bool piezaMovida = false;
            Caballero caballero = null;

            //Buscamos el caballero del jugador
            caballero = BuscarCaballero(jugador);

            if (caballero != null) //Si existe un caballero para ese jugador
            {
                //piezaMovida = ModificarCasilleros(caballero, movimiento);
                if (caballero.Casillero < 50 && caballero.Casillero >= 0)
                {
                    caballero.Casillero += movimiento;
                }
                else 
                {
                    //caballero.Ganador(caballero);
                }
                piezaMovida = true;
            }
            return piezaMovida;
        }

        private Caballero BuscarCaballero(int jugador)
        {
            Caballero caballero = null;
            foreach (var pieza in piezas)
            {
                if (pieza is Caballero && ((Caballero)pieza).NroJugador == jugador)
                {
                    caballero = (Caballero)pieza;

                }
            }

            return caballero;
        }

        public override string MostrarTablero(int nroJugador)
        {
            string datos = "";

            foreach (Piezas p in piezas)
            {
                Caballero c = (Caballero)p;

                if (c.NroJugador == nroJugador)
                {
                    datos = "Caballero Nº" + c.NroJugador + " \nEn la posición: " + c.Casillero.ToString() + "\n";
                }
            }
            return datos;
        }
    }

}

