﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calabazos_Dragones.Clases
{
    public abstract class Tablero
    {
        protected Casillero[] casilleros;                                 //Almacena los casilleros del tablero
        protected ArrayList piezas;                                       //Guarda las piezas que el tablero tiene segun su dificultad
        public abstract bool MoverPieza(int nroJuador, int movimiento); //Mueve las piezas segun el jugador y el movimiento que recibe
        public abstract string MostrarTablero(int nroJugador);                         //Devuelve un arreglo con el estado de los casilleros

    }
}