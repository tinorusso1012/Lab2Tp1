using Calabazos_Dragones.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calabazos_Dragones
{
    public partial class Form1 : Form
    {
        Sistema sistema;
        public Form1()
        {
            sistema = new Sistema();
            InitializeComponent();
            lbLog.Items.Add("¡Bienvenido a Calabozos y dragones!");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            //*************************************
            //Crear formulario para crear jugadores
            //*************************************

            //Hardcodeamos jugadores
            HardcodearJugadores();

            if(sistema.ListaJugadores.Count > 3) //Evitamos que se puedan agregar jugadores si ya tenemos 4
            { 
                btnAgregar.Enabled = false; 
            }
        }

        private void HardcodearJugadores()
        {
            for (int i = 1; i < 5; i++)
            {
                bool resultado = sistema.AgregarJugador(i, "Prueba" + i);
                if (resultado)
                {
                    lbLog.Items.Add("¡Jugador: " + "Prueba " + i + " agregado exitosamente!");
                }
            }
        }

        private void btnTablero_Click(object sender, EventArgs e)
        {
            int dificultad = 0;
            string dif = "";

            if(rbBasico.Checked)
            {
                dificultad = 1;
                dif = "Básico";
            }
            else if(rbIntermedio.Checked)
            {
                dificultad = 2;
                dif = "Intermedio";
            }
            else
            {
                dificultad = 3;
                dif = "Experto";
            }

            if (sistema.ListaJugadores.Count > 1)
            {
                sistema.CrearTablero(dificultad);
                lbLog.Items.Add("Se creó un tablero de dificultad: " + dif);
                btnTablero.Enabled = false; //Bloqueamos el botón para crear tablero
                
            }
            else
            {
                MessageBox.Show("¡Debe agregar al menos dos jugadores!");
            }
            
        }

        private void MostrarTablero(int nroJugador)
        {
            //lbTablero.Items.Clear();    
            string tablero = sistema.ObtenerTablero(nroJugador);
            lbTablero.Items.Add(tablero);
            
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            //Cada jugador lanza un dado y mueve su caballero

            for (int i = 0; i < sistema.ListaJugadores.Count; i++)
            {
                Jugador j = (Jugador)sistema.ListaJugadores[i];

                int dado = 0;
                if (j.VerificarTurno()) //Verificamos que pueda jugar
                {
                    dado = j.Jugar(); //Tiramos el dado
                    lbLog.Items.Add("El jugador: " + j.Nombre + " lanzó: " + dado);
                    if(sistema.Jugar(j.Posicion, dado))
                    {
                        lbLog.Items.Add("Se movió el caballero de: " + j.Nombre);
                        MostrarTablero(j.Posicion);
                    }
                }
                else
                {
                    lbLog.Items.Add(j.Nombre + " no puede jugar este turno");
                }

                if (sistema.Jugar(j.Posicion, dado))
                {
                    lbLog.Items.Add("Se movió el caballero de: " + j.Nombre);
                    MostrarTablero(j.Posicion);
                }
                Console.Beep(37,1000);
                
            }
            
        }

        private void btnRonda_Click(object sender, EventArgs e)
        {
            int r = sistema.NuevaRonda();
            lbLog.Items.Add("¡Empieza la ronda: " + r +"!");
            
        }
    }
}
