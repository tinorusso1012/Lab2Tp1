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
    public partial class Inicializar : Form
    {
        public Inicializar(int segundos)
        {
            InitializeComponent();
            timer1.Interval = segundos * 1000;
            timer1.Start();
            lbcarga.Parent = pictureBox1;
            lbcarga.BackColor = Color.Transparent;
        }


        private void timer1_Tick_1(object sender, EventArgs e)
        {

            Random random = new Random();

            progressBar1.Increment(random.Next(10, 30));
            lbcarga.Text = MostrarMensaje(random.Next(1, 6));
            label1.Text = progressBar1.Value.ToString() + " %";


            if (progressBar1.Value == progressBar1.Maximum)
            {
                timer1.Stop();
                this.Close();
            }

        }
        public string MostrarMensaje(int pCarga)
        {
            string mensaje = "";
            switch (pCarga)
            {
                case 1:
                    {
                        mensaje = "Cargando Lista de ganadores";
                        break;
                    }

                case 2:
                    {
                        mensaje = "Afilando espadas";
                        break;
                    }

                case 3:
                    {
                        mensaje = "Preparando Caballeros";
                        break;
                    }
                case 4:
                    {
                        mensaje = "Preparando Dragones";
                        break;
                    }
                case 5:
                    {
                        mensaje = "Preparando Calabozos";
                        break;

                    }
            }
            return mensaje;

        }
    }
}

