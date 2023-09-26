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
            this.btnJugar = new System.Windows.Forms.Button();
            this.btnDemo = new System.Windows.Forms.Button();
            this.btnGanadores = new System.Windows.Forms.Button();
            this.DrakoMalfoiVerde = new System.Windows.Forms.PictureBox();
            this.ElDrakoMalfoiRojo = new System.Windows.Forms.PictureBox();
            this.Tablero = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DrakoMalfoiVerde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ElDrakoMalfoiRojo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tablero)).BeginInit();
            this.SuspendLayout();
            // 
            // btnJugar
            // 
            this.btnJugar.Location = new System.Drawing.Point(1121, 94);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(75, 23);
            this.btnJugar.TabIndex = 1;
            this.btnJugar.Text = "Jugar";
            this.btnJugar.UseVisualStyleBackColor = true;
            this.btnJugar.Click += new System.EventHandler(this.btnJugar_Click);
            // 
            // btnDemo
            // 
            this.btnDemo.Location = new System.Drawing.Point(1121, 44);
            this.btnDemo.Name = "btnDemo";
            this.btnDemo.Size = new System.Drawing.Size(75, 23);
            this.btnDemo.TabIndex = 2;
            this.btnDemo.Text = "Demo";
            this.btnDemo.UseVisualStyleBackColor = true;
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
            // DrakoMalfoiVerde
            // 
            this.DrakoMalfoiVerde.BackColor = System.Drawing.Color.White;
            this.DrakoMalfoiVerde.ErrorImage = null;
            this.DrakoMalfoiVerde.Location = new System.Drawing.Point(415, 470);
            this.DrakoMalfoiVerde.Name = "DrakoMalfoiVerde";
            this.DrakoMalfoiVerde.Size = new System.Drawing.Size(61, 55);
            this.DrakoMalfoiVerde.TabIndex = 5;
            this.DrakoMalfoiVerde.TabStop = false;
            // 
            // ElDrakoMalfoiRojo
            // 
            this.ElDrakoMalfoiRojo.BackColor = System.Drawing.Color.White;
            this.ElDrakoMalfoiRojo.Image = ((System.Drawing.Image)(resources.GetObject("ElDrakoMalfoiRojo.Image")));
            this.ElDrakoMalfoiRojo.Location = new System.Drawing.Point(319, 468);
            this.ElDrakoMalfoiRojo.Name = "ElDrakoMalfoiRojo";
            this.ElDrakoMalfoiRojo.Size = new System.Drawing.Size(61, 57);
            this.ElDrakoMalfoiRojo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ElDrakoMalfoiRojo.TabIndex = 4;
            this.ElDrakoMalfoiRojo.TabStop = false;
            // 
            // Tablero
            // 
            this.Tablero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Tablero.Image = ((System.Drawing.Image)(resources.GetObject("Tablero.Image")));
            this.Tablero.InitialImage = null;
            this.Tablero.Location = new System.Drawing.Point(0, -1);
            this.Tablero.Name = "Tablero";
            this.Tablero.Size = new System.Drawing.Size(1206, 570);
            this.Tablero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Tablero.TabIndex = 0;
            this.Tablero.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1208, 572);
            this.Controls.Add(this.DrakoMalfoiVerde);
            this.Controls.Add(this.ElDrakoMalfoiRojo);
            this.Controls.Add(this.btnGanadores);
            this.Controls.Add(this.btnDemo);
            this.Controls.Add(this.btnJugar);
            this.Controls.Add(this.Tablero);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DrakoMalfoiVerde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ElDrakoMalfoiRojo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tablero)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Tablero;
        private System.Windows.Forms.Button btnJugar;
        private System.Windows.Forms.Button btnDemo;
        private System.Windows.Forms.Button btnGanadores;
        private System.Windows.Forms.PictureBox ElDrakoMalfoiRojo;
        private System.Windows.Forms.PictureBox DrakoMalfoiVerde;
    }
}

