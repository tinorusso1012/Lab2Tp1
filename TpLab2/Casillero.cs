using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpLab2
{
    internal class Casillero
    {

        private int numeroCasillero;
        public int NroCasillero
        {
            get
            {
                return numeroCasillero;

            }
            private set
            {
                numeroCasillero = value;
            }
        }
        public ArrayList piezas { get; private set; }
        public EstadoCasillero Estado { get; private set; }
        public Casillero(int numeroCasillero)
        {
            this.numeroCasillero = numeroCasillero;
            piezas = new ArrayList();
            Estado = EstadoCasillero.Libre;
        }

        public void AgregarPieza(Piezas pieza)
        {
            piezas.Add(pieza);
            Estado = EstadoCasillero.Ocupado;
        }

        public void BorrarPieza(int indice)
        {
            Caballero caballero = BuscarCaballero(indice);

            piezas.Remove(caballero);

            ActualizarEstado();
        }

        public void ActualizarEstado()
        {
            if (piezas.Count < 0)
            {
                Estado = EstadoCasillero.Libre;
            }
        }

        private Caballero BuscarCaballero(int jugador)
        {
            Caballero caballero = null;
            foreach (var pieza in piezas)
            {
                if (pieza is Caballero && ((Caballero)pieza).NroJugador == jugador)
                {
                    caballero = (Caballero)pieza;
                    break; // Salimos del bucle una vez que encontramos la pieza
                }
            }

            return caballero;
        }


        public string MostrarPiezas()
        {
            string listaPiezas = "";

            foreach (Piezas pieza in piezas)
            {
                if (pieza is Caballero)
                {
                    Caballero caballero = (Caballero)pieza;
                    listaPiezas += "Caballero " + caballero.NroJugador + ", se movió al casillero: " + NroCasillero;
                }
                else if (pieza is Dragon)
                {
                    Dragon dragon = (Dragon)pieza;
                    listaPiezas += "Dragon " + dragon.NroJugador + ", se movió al casillero: " + NroCasillero;
                }
                else
                {
                    listaPiezas += "Ocupado por un calabozo";
                }
            }

            return listaPiezas;
        }
    }
}

