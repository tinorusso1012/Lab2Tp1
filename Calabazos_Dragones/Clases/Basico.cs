using Calabazos_Dragones.Clases;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calabazos_Dragones.Clases
{
    public class Basico : Tablero
    {
        //public Caballero[] caballero;
        public Basico(int cantidadJugadores) //Inicializamos el tablero en modo basico segun la cantidad de jugadores
        {
            piezas = new ArrayList(cantidadJugadores);
            CrearCaballeros(cantidadJugadores);
            IniciarCasilleros(cantidadJugadores);
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
                caballero.Casillero += movimiento;
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

        public void IniciarCasilleros(int cantidadJugadores) //Le mandamos la cantidad de jugadores
        {
            casilleros = new Casillero[50]; //Iniciamos la variable con las 50 posiciones
            for (int i = 0; i < casilleros.Length; i++)
            {
                casilleros[i] = new Casillero(i);
            }

            for (int i = 0; i < cantidadJugadores; i++) //Recorremos el arreglo de piezas
            {
                Caballero caballero = (Caballero)piezas[i]; //Casteamos las piezas a Caballero

                casilleros[0].AgregarPieza(caballero); //En la primer posición agregamos los caballeros
            }

        }

        public bool ModificarCasilleros(Piezas pieza, int movimiento) //Le mandamos la pieza y el movimiento que va a ejecutar
        {
            bool modificacion = false;
            Caballero caballero = (Caballero)pieza; //Casteamos la pieza a caballero

            foreach (Casillero casillero in casilleros) //Recorremos los casilleros
            {
                if (!modificacion)
                {
                    foreach (Piezas p in casillero.piezas) //Recorremos las piezas del casillero
                    {
                            if (p is Caballero) //Si es un caballero
                            {
                                Caballero caballero_casillero = (Caballero)p;

                                if (caballero_casillero.NroJugador == caballero.NroJugador) //Comparamos si el nro de Jugador es el mismo que el que hizo la jugada
                                {
                                    int numeroCasillero = casillero.NroCasillero; //Guardamos el numero de casillero
                                    int proximoCasillero = numeroCasillero + movimiento; //Le sumamos el movimiento
                                    casilleros[proximoCasillero].AgregarPieza(caballero); //Lo guardamos en el casillero que sigue segun su movimiento
                                    casillero.BorrarPieza(caballero.NroJugador);
                                    modificacion = true;
                                    break;
                                }
                            }
                        
                    }
                }
            }
            return modificacion;
        }

        
        public override string MostrarTablero(int nroJugador)
        {
            string datos = "";

            foreach(Piezas p in piezas)
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
