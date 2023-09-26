using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpLab2
{
    abstract class Tablero
    {
        private int[] casilleros =new int[10];
        private ArrayList Piezas = new ArrayList();
        public bool MoverPieza(int indice, int movimiento) 
        {
            bool a=true;
            return a;
        }
        public int  MostrarTablero() 
        {
            int a=0;
            return a;   
        }

    }
}
