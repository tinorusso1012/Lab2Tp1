namespace Calabazos_Dragones
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lbLog = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbBasico = new System.Windows.Forms.RadioButton();
            this.rbIntermedio = new System.Windows.Forms.RadioButton();
            this.rbExperto = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnTablero = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbTablero = new System.Windows.Forms.ListBox();
            this.btnJugar = new System.Windows.Forms.Button();
            this.btnRonda = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Courier New", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(6, 32);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(146, 62);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "+";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lbLog
            // 
            this.lbLog.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLog.FormattingEnabled = true;
            this.lbLog.ItemHeight = 16;
            this.lbLog.Location = new System.Drawing.Point(6, 21);
            this.lbLog.Name = "lbLog";
            this.lbLog.Size = new System.Drawing.Size(377, 228);
            this.lbLog.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTablero);
            this.groupBox1.Controls.Add(this.rbExperto);
            this.groupBox1.Controls.Add(this.rbIntermedio);
            this.groupBox1.Controls.Add(this.rbBasico);
            this.groupBox1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(176, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dificultad";
            // 
            // rbBasico
            // 
            this.rbBasico.AutoSize = true;
            this.rbBasico.Location = new System.Drawing.Point(6, 21);
            this.rbBasico.Name = "rbBasico";
            this.rbBasico.Size = new System.Drawing.Size(73, 20);
            this.rbBasico.TabIndex = 0;
            this.rbBasico.TabStop = true;
            this.rbBasico.Text = "Básico";
            this.rbBasico.UseVisualStyleBackColor = true;
            // 
            // rbIntermedio
            // 
            this.rbIntermedio.AutoSize = true;
            this.rbIntermedio.Location = new System.Drawing.Point(6, 47);
            this.rbIntermedio.Name = "rbIntermedio";
            this.rbIntermedio.Size = new System.Drawing.Size(105, 20);
            this.rbIntermedio.TabIndex = 1;
            this.rbIntermedio.TabStop = true;
            this.rbIntermedio.Text = "Intermedio";
            this.rbIntermedio.UseVisualStyleBackColor = true;
            // 
            // rbExperto
            // 
            this.rbExperto.AutoSize = true;
            this.rbExperto.Location = new System.Drawing.Point(6, 73);
            this.rbExperto.Name = "rbExperto";
            this.rbExperto.Size = new System.Drawing.Size(81, 20);
            this.rbExperto.TabIndex = 2;
            this.rbExperto.TabStop = true;
            this.rbExperto.Text = "Experto";
            this.rbExperto.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAgregar);
            this.groupBox2.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(158, 100);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Jugadores";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbLog);
            this.groupBox3.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 118);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(389, 254);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Log";
            // 
            // btnTablero
            // 
            this.btnTablero.Font = new System.Drawing.Font("Courier New", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTablero.Location = new System.Drawing.Point(117, 11);
            this.btnTablero.Name = "btnTablero";
            this.btnTablero.Size = new System.Drawing.Size(102, 83);
            this.btnTablero.TabIndex = 1;
            this.btnTablero.Text = "+";
            this.btnTablero.UseVisualStyleBackColor = true;
            this.btnTablero.Click += new System.EventHandler(this.btnTablero_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnRonda);
            this.groupBox4.Controls.Add(this.btnJugar);
            this.groupBox4.Controls.Add(this.lbTablero);
            this.groupBox4.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(407, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(902, 360);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tablero";
            // 
            // lbTablero
            // 
            this.lbTablero.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTablero.FormattingEnabled = true;
            this.lbTablero.ItemHeight = 16;
            this.lbTablero.Location = new System.Drawing.Point(6, 21);
            this.lbTablero.Name = "lbTablero";
            this.lbTablero.Size = new System.Drawing.Size(890, 292);
            this.lbTablero.TabIndex = 1;
            // 
            // btnJugar
            // 
            this.btnJugar.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJugar.Location = new System.Drawing.Point(6, 319);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(92, 35);
            this.btnJugar.TabIndex = 1;
            this.btnJugar.Text = "Jugar";
            this.btnJugar.UseVisualStyleBackColor = true;
            this.btnJugar.Click += new System.EventHandler(this.btnJugar_Click);
            // 
            // btnRonda
            // 
            this.btnRonda.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRonda.Location = new System.Drawing.Point(104, 319);
            this.btnRonda.Name = "btnRonda";
            this.btnRonda.Size = new System.Drawing.Size(92, 35);
            this.btnRonda.TabIndex = 2;
            this.btnRonda.Text = "Nueva Ronda";
            this.btnRonda.UseVisualStyleBackColor = true;
            this.btnRonda.Click += new System.EventHandler(this.btnRonda_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1321, 379);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Calabozos y dragones";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListBox lbLog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbBasico;
        private System.Windows.Forms.RadioButton rbExperto;
        private System.Windows.Forms.RadioButton rbIntermedio;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnTablero;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnJugar;
        private System.Windows.Forms.ListBox lbTablero;
        private System.Windows.Forms.Button btnRonda;
    }
}

