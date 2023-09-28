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
        public int Posicion
        {
            get { return posicion; }
            private set { posicion = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            private set { nombre = value; }
        }
        private bool turno = true;
        public int CantidadGanadas { get; set; }
        private Random dado;

        public Jugador(int posicion, string nombre)
        {
            Nombre = nombre;     //Cada jugador es inicializado con un nombre.
            Posicion = posicion; //Tambien se le atribuye una posicion del 1 al 4 dependiendo la cantidad que se eligió en el principio
                                 //con este numero de posicion despues se le asignan las piezas.
            CantidadGanadas = 0; //Iniciamos el contador de victorias.
            //dado = new Random(); //Iniciamos un dado para el jugador.
            this.turno = true;  //Iniciamos el turno en true.
        }
        public bool VerificarTurno() //Analiza el estado de la variable turno para determinar si el jugador puede jugar o no
        {
            bool puedeJugar = false;
            if (turno)
            {
                puedeJugar = true;
            }
            return puedeJugar;
        }
        public int Jugar()
        {
            dado = new Random();
            int resultado = 0;
            if (turno)
            {
                resultado = dado.Next(1, 7); //El jugador lanza el dado y devolvemos el resultado.
                turno = false;//Como ya lanzó el dado, su turno terminó
            }
            return resultado;
        }

        public bool PerderTurno() //En caso de perder el turno, cambiamos el valor a false
        {
            turno = false;
            return turno;
        }

        public bool NuevaRonda() //Empieza una nueva ronda, cambiamos el valor a true
        {
            turno = true;
            return turno;
        }
    }
}
