namespace TpLab2
{
    partial class Movimientos
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
            this.lbJuego = new System.Windows.Forms.ListBox();
            this.lab1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbJuego
            // 
            this.lbJuego.BackColor = System.Drawing.Color.Thistle;
            this.lbJuego.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbJuego.FormattingEnabled = true;
            this.lbJuego.Location = new System.Drawing.Point(69, 70);
            this.lbJuego.Name = "lbJuego";
            this.lbJuego.Size = new System.Drawing.Size(266, 364);
            this.lbJuego.TabIndex = 0;
            // 
            // lab1
            // 
            this.lab1.AutoSize = true;
            this.lab1.BackColor = System.Drawing.Color.Thistle;
            this.lab1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lab1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab1.ForeColor = System.Drawing.Color.Black;
            this.lab1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lab1.Location = new System.Drawing.Point(95, 36);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(208, 18);
            this.lab1.TabIndex = 1;
            this.lab1.Text = "Movimiento de Piezas";
            // 
            // Movimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackgroundImage = global::TpLab2.Properties.Resources.calabozo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(402, 450);
            this.Controls.Add(this.lab1);
            this.Controls.Add(this.lbJuego);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Movimientos";
            this.ShowInTaskbar = false;
            this.Text = "Movimientos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lab1;
        public System.Windows.Forms.ListBox lbJuego;
    }
}