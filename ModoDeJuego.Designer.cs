namespace TpLab2
{
    partial class ModoDeJuego
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
            this.CantJug = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cbSelectMode = new System.Windows.Forms.ComboBox();
            this.btnJugar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CantJug)).BeginInit();
            this.SuspendLayout();
            // 
            // CantJug
            // 
            this.CantJug.Location = new System.Drawing.Point(156, 28);
            this.CantJug.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.CantJug.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.CantJug.Name = "CantJug";
            this.CantJug.Size = new System.Drawing.Size(120, 20);
            this.CantJug.TabIndex = 2;
            this.CantJug.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cantidad de Jugadores";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Modo de Juego:";
            // 
            // cbSelectMode
            // 
            this.cbSelectMode.FormattingEnabled = true;
            this.cbSelectMode.Items.AddRange(new object[] {
            "Basico",
            "Intermedio",
            "Experto"});
            this.cbSelectMode.Location = new System.Drawing.Point(155, 73);
            this.cbSelectMode.Name = "cbSelectMode";
            this.cbSelectMode.Size = new System.Drawing.Size(121, 21);
            this.cbSelectMode.TabIndex = 4;
            // 
            // btnJugar
            // 
            this.btnJugar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnJugar.Location = new System.Drawing.Point(126, 131);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(75, 23);
            this.btnJugar.TabIndex = 5;
            this.btnJugar.Text = "Jugar";
            this.btnJugar.UseVisualStyleBackColor = true;
            // 
            // ModoDeJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 177);
            this.Controls.Add(this.btnJugar);
            this.Controls.Add(this.cbSelectMode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CantJug);
            this.Name = "ModoDeJuego";
            this.Text = "ModoDeJuego";
            ((System.ComponentModel.ISupportInitialize)(this.CantJug)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        public System.Windows.Forms.ComboBox cbSelectMode;
        private System.Windows.Forms.Button btnJugar;
        public System.Windows.Forms.NumericUpDown CantJug;
    }
}