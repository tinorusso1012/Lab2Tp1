namespace TpLab2
{
    partial class JuegoNuevo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbExperto = new System.Windows.Forms.RadioButton();
            this.rbIntermedio = new System.Windows.Forms.RadioButton();
            this.rbBasico = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb3J = new System.Windows.Forms.RadioButton();
            this.rb2J = new System.Windows.Forms.RadioButton();
            this.rb1J = new System.Windows.Forms.RadioButton();
            this.btnJugar = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = global::TpLab2.Properties.Resources.fondito;
            this.groupBox2.Controls.Add(this.rbExperto);
            this.groupBox2.Controls.Add(this.rbIntermedio);
            this.groupBox2.Controls.Add(this.rbBasico);
            this.groupBox2.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Thistle;
            this.groupBox2.Location = new System.Drawing.Point(241, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(271, 229);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dificultad";
            // 
            // rbExperto
            // 
            this.rbExperto.AutoSize = true;
            this.rbExperto.BackgroundImage = global::TpLab2.Properties.Resources.fondito;
            this.rbExperto.Location = new System.Drawing.Point(6, 73);
            this.rbExperto.Name = "rbExperto";
            this.rbExperto.Size = new System.Drawing.Size(81, 20);
            this.rbExperto.TabIndex = 2;
            this.rbExperto.TabStop = true;
            this.rbExperto.Text = "Experto";
            this.rbExperto.UseVisualStyleBackColor = true;
            // 
            // rbIntermedio
            // 
            this.rbIntermedio.AutoSize = true;
            this.rbIntermedio.BackgroundImage = global::TpLab2.Properties.Resources.fondito;
            this.rbIntermedio.Location = new System.Drawing.Point(6, 47);
            this.rbIntermedio.Name = "rbIntermedio";
            this.rbIntermedio.Size = new System.Drawing.Size(105, 20);
            this.rbIntermedio.TabIndex = 1;
            this.rbIntermedio.TabStop = true;
            this.rbIntermedio.Text = "Intermedio";
            this.rbIntermedio.UseVisualStyleBackColor = true;
            // 
            // rbBasico
            // 
            this.rbBasico.AutoSize = true;
            this.rbBasico.BackgroundImage = global::TpLab2.Properties.Resources.fondito;
            this.rbBasico.Location = new System.Drawing.Point(6, 21);
            this.rbBasico.Name = "rbBasico";
            this.rbBasico.Size = new System.Drawing.Size(73, 20);
            this.rbBasico.TabIndex = 0;
            this.rbBasico.TabStop = true;
            this.rbBasico.Text = "Básico";
            this.rbBasico.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::TpLab2.Properties.Resources.fondito;
            this.groupBox1.Controls.Add(this.rb3J);
            this.groupBox1.Controls.Add(this.rb2J);
            this.groupBox1.Controls.Add(this.rb1J);
            this.groupBox1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Thistle;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(204, 229);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Jugadores";
            // 
            // rb3J
            // 
            this.rb3J.AutoSize = true;
            this.rb3J.BackgroundImage = global::TpLab2.Properties.Resources.fondito;
            this.rb3J.Location = new System.Drawing.Point(18, 87);
            this.rb3J.Name = "rb3J";
            this.rb3J.Size = new System.Drawing.Size(73, 20);
            this.rb3J.TabIndex = 4;
            this.rb3J.TabStop = true;
            this.rb3J.Text = "3 Bots";
            this.rb3J.UseVisualStyleBackColor = true;
            // 
            // rb2J
            // 
            this.rb2J.AutoSize = true;
            this.rb2J.BackgroundImage = global::TpLab2.Properties.Resources.fondito;
            this.rb2J.Location = new System.Drawing.Point(18, 61);
            this.rb2J.Name = "rb2J";
            this.rb2J.Size = new System.Drawing.Size(73, 20);
            this.rb2J.TabIndex = 3;
            this.rb2J.TabStop = true;
            this.rb2J.Text = "2 Bots";
            this.rb2J.UseVisualStyleBackColor = true;
            // 
            // rb1J
            // 
            this.rb1J.AutoSize = true;
            this.rb1J.BackgroundImage = global::TpLab2.Properties.Resources.fondito;
            this.rb1J.Location = new System.Drawing.Point(18, 35);
            this.rb1J.Name = "rb1J";
            this.rb1J.Size = new System.Drawing.Size(73, 20);
            this.rb1J.TabIndex = 1;
            this.rb1J.TabStop = true;
            this.rb1J.Text = "1 Bots";
            this.rb1J.UseVisualStyleBackColor = true;
            // 
            // btnJugar
            // 
            this.btnJugar.BackColor = System.Drawing.Color.Thistle;
            this.btnJugar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnJugar.Font = new System.Drawing.Font("Courier New", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJugar.Location = new System.Drawing.Point(109, 259);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(272, 62);
            this.btnJugar.TabIndex = 3;
            this.btnJugar.Text = "Jugar";
            this.btnJugar.UseVisualStyleBackColor = false;
            // 
            // JuegoNuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TpLab2.Properties.Resources.fondito;
            this.ClientSize = new System.Drawing.Size(537, 333);
            this.Controls.Add(this.btnJugar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "JuegoNuevo";
            this.Text = "Nueva Partida";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.RadioButton rbExperto;
        public System.Windows.Forms.RadioButton rbIntermedio;
        public System.Windows.Forms.RadioButton rbBasico;
        public System.Windows.Forms.RadioButton rb3J;
        public System.Windows.Forms.RadioButton rb2J;
        public System.Windows.Forms.RadioButton rb1J;
        public System.Windows.Forms.Button btnJugar;
    }
}