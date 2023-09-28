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
        }


        private void timer1_Tick_1(object sender, EventArgs e)
        {
           
            Random random = new Random();
            
            progressBar1.Increment(random.Next(10,50));
            label1.Text = progressBar1.Value.ToString() + " %";

            if (progressBar1.Value== progressBar1.Maximum) 
            {
                timer1.Stop();
                this.Close();
            }

        }
    }
}
