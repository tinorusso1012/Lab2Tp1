using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TpLab2
{
    public partial class Form1 : Form
    {
        Sistema sistema;
        Movimientos movimientos;
        JuegoNuevo nuevo;
        ListaGanadores listaGanadores;
        int CantJugadores = 0;

        public Form1()
        {
            sistema = new Sistema();
            InitializeComponent();
        }
        private void HardcodearJugadores()
        {
            if (nuevo.rb1J.Checked)
            {
                CantJugadores = 1;

            }
            else if (nuevo.rb2J.Checked)
            {
                CantJugadores = 2;

            }
            else
            {
                CantJugadores = 3;

            }
            for (int i = 1; i < CantJugadores + 1; i++)
            {
                bool resultado = sistema.AgregarJugador(i, "Prueba" + i);
                //if (resultado)
                //{
                //    MessageBox.Show("¡Jugador: " + "Prueba " + i + " agregado exitosamente!");
                //}
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Inicializar cargarJuego = new Inicializar(1);
            cargarJuego.ShowDialog();
            btnMover.Visible = false;
        }
        private void btnDemo_Click(object sender, EventArgs e)
        {
            nuevo = new JuegoNuevo();
            nuevo.ShowDialog();
            int dificultad = 0;
            string dif = "";
            HardcodearJugadores();
            

            if (sistema.ListaJugadores.Count > 3) //Evitamos que se puedan agregar jugadores si ya tenemos 4
            {
                //btnAgregar.Enabled = false;
            }
            if (nuevo.rbBasico.Checked)
            {
                dificultad = 1;
                dif = "Básico";
            }
            else if (nuevo.rbIntermedio.Checked)
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
                //movimientos.lbJuego.Items.Add("Se creó un tablero de dificultad: " + dif);
                MessageBox.Show("¡Se creó un tablero de dificultad:" + dif + " con " + CantJugadores + " jugadores!");
            }
            else
            {
                MessageBox.Show("¡Debe agregar al menos dos jugadores!");
            }
            if (nuevo.btnJugar.DialogResult == DialogResult.OK)
            {
                movimientos = new Movimientos();
                nuevo.Dispose();
                bool HayGanador=false;
                Jugador ganador = null;
                
                #region Juego Demo
                while (HayGanador != true) //Verifica ganador, pero todavia falta implementar el metodo
                {
                    //Cada jugador lanza un dado y mueve su caballero
                    //Habria que agregar un metodo para Verificar Ganador
                    int r = sistema.NuevaRonda();
                    movimientos.lbJuego.Items.Add("¡Empieza la ronda: " + (r) + "!");

                    for (int i = 0; i < sistema.ListaJugadores.Count; i++)
                    {
                        if (HayGanador == false)
                        {

                        Jugador j = (Jugador)sistema.ListaJugadores[i];

                        int dado = 0;
                       
                        if (j.VerificarTurno()) //Verificamos que pueda jugar
                        {
                            dado = j.Jugar(); //Tiramos el dado
                            movimientos.lbJuego.Items.Add("El jugador: " + j.Nombre + " lanzó: " + dado);

                        }
                        else
                        {
                            movimientos.lbJuego.Items.Add(j.Nombre + " no puede jugar este turno");
                        }
                            int posiciones = sistema.Jugar(j.Posicion, dado);
                        if (posiciones < 49)
                        {
                            movimientos.lbJuego.Items.Add("Se movió el caballero de: " + j.Nombre + " esta en la pos: " + posiciones);
                            MostrarTablero(j.Posicion);
                        } else
                        {
                            MessageBox.Show("El Jugador: " + j.Nombre + " Gano");
                                ganador = j;
                                HayGanador = true;
                        }
                        }

                        //if ()
                        //Console.Beep(37, 1000);
                    }
                  
                }
                movimientos.ShowDialog();

                movimientos.Dispose();
                #endregion
            }


        }
        private void MostrarTablero(int nroJugador)
        {
            //lbTablero.Items.Clear();    
            string tablero = sistema.ObtenerJugEnTablero(nroJugador);
            movimientos.lbJuego.Items.Add(tablero);

        }

        private void btJuego_Click(object sender, EventArgs e)
        {
            int r = sistema.NuevaRonda();
            movimientos.lbJuego.Items.Add("¡Empieza la ronda: " + r + "!");
            for (int i = 0; i < sistema.ListaJugadores.Count; i++)
            {
                Jugador j = (Jugador)sistema.ListaJugadores[i];

                int dado = 0;
                if (j.VerificarTurno()) //Verificamos que pueda jugar
                {
                    dado = j.Jugar(); //Tiramos el dado
                    movimientos.lbJuego.Items.Add("El jugador: " + j.Nombre + " lanzó: " + dado);
                    if (sistema.Jugar(j.Posicion, dado) < 49)
                    {
                        movimientos.lbJuego.Items.Add("Se movió el caballero de: " + j.Nombre);
                        MostrarTablero(j.Posicion);
                    } else
                    {
                        movimientos.lbJuego.Items.Add("El Jugador: " + j.Nombre + " Gano");
                    }
                }
                else
                {
                    movimientos.lbJuego.Items.Add(j.Nombre + " no puede jugar este turno");
                }
                //Console.Beep(37, 1000);
                movimientos.ShowDialog();
            }
            for (int i = 0;i<sistema.listaDragones.Count;i++) 
            {
            
            
            
            }
            
        }

        private void btnGanadores_Click(object sender, EventArgs e)
        {
            listaGanadores = new ListaGanadores();
                
            for (int i = 0; i < sistema.VerGanadores().Count; i++) 
            {
                listaGanadores.lbGanadores.Items.Add(sistema.VerGanadores()[i]);
            
            }
            listaGanadores.ShowDialog();
            if (listaGanadores.btnCerrar.DialogResult == DialogResult.OK) 
            {
                listaGanadores.Dispose();
            }

        }
    }
}
