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
        public Form1()
        {
            InitializeComponent();
            ElDrakoMalfoiRojo.Location = new Point(925,463);
            sistema = new Sistema();
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            ModoDeJuego nuevoJuego = new ModoDeJuego();

            if (nuevoJuego.ShowDialog() == DialogResult.OK)
            {
                int CantJug = Convert.ToInt32(nuevoJuego.CantJug.Value);
                switch (nuevoJuego.cbSelectMode.Text){
                    case "Basico":   
                        break;
                    case "Intermedio":
                        break;

                    case "Experto":
                        break;
                }

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        
        }
    }
}
