namespace TpLab2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btJuego = new System.Windows.Forms.Button();
            this.btnDemo = new System.Windows.Forms.Button();
            this.btnGanadores = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btJuego
            // 
            this.btJuego.Location = new System.Drawing.Point(1121, 94);
            this.btJuego.Name = "btJuego";
            this.btJuego.Size = new System.Drawing.Size(75, 23);
            this.btJuego.TabIndex = 1;
            this.btJuego.Text = "Jugar";
            this.btJuego.UseVisualStyleBackColor = true;
            this.btJuego.Click += new System.EventHandler(this.btJuego_Click);
            // 
            // btnDemo
            // 
            this.btnDemo.Location = new System.Drawing.Point(1121, 44);
            this.btnDemo.Name = "btnDemo";
            this.btnDemo.Size = new System.Drawing.Size(75, 23);
            this.btnDemo.TabIndex = 2;
            this.btnDemo.Text = "Demo";
            this.btnDemo.UseVisualStyleBackColor = true;
            this.btnDemo.Click += new System.EventHandler(this.btnDemo_Click);
            // 
            // btnGanadores
            // 
            this.btnGanadores.BackColor = System.Drawing.Color.White;
            this.btnGanadores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGanadores.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnGanadores.Location = new System.Drawing.Point(1121, 139);
            this.btnGanadores.Name = "btnGanadores";
            this.btnGanadores.Size = new System.Drawing.Size(75, 23);
            this.btnGanadores.TabIndex = 3;
            this.btnGanadores.Text = "Ganadores";
            this.btnGanadores.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::TpLab2.Properties.Resources.tablerojpg;
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1206, 570);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1208, 583);
            this.Controls.Add(this.btnGanadores);
            this.Controls.Add(this.btnDemo);
            this.Controls.Add(this.btJuego);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Caballeros, Calabozos y Dragones";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btJuego;
        private System.Windows.Forms.Button btnDemo;
        private System.Windows.Forms.Button btnGanadores;
    }
}

