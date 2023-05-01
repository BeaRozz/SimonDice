namespace SimonDice1
{
    partial class SimonDice
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
            this.Puntaje = new System.Windows.Forms.Label();
            this.Inicio = new System.Windows.Forms.Button();
            this.p_1 = new System.Windows.Forms.PictureBox();
            this.p_4 = new System.Windows.Forms.PictureBox();
            this.p_2 = new System.Windows.Forms.PictureBox();
            this.p_3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.p_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_3)).BeginInit();
            this.SuspendLayout();
            // 
            // Puntaje
            // 
            this.Puntaje.AutoSize = true;
            this.Puntaje.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Puntaje.Location = new System.Drawing.Point(280, 57);
            this.Puntaje.Name = "Puntaje";
            this.Puntaje.Size = new System.Drawing.Size(15, 16);
            this.Puntaje.TabIndex = 0;
            this.Puntaje.Text = "--";
            // 
            // Inicio
            // 
            this.Inicio.Location = new System.Drawing.Point(265, 387);
            this.Inicio.Name = "Inicio";
            this.Inicio.Size = new System.Drawing.Size(123, 36);
            this.Inicio.TabIndex = 5;
            this.Inicio.Text = "Iniciar juego";
            this.Inicio.UseVisualStyleBackColor = true;
            this.Inicio.Click += new System.EventHandler(this.Inicio_Click);
            // 
            // p_1
            // 
            this.p_1.BackColor = System.Drawing.Color.Red;
            this.p_1.Location = new System.Drawing.Point(130, 97);
            this.p_1.Name = "p_1";
            this.p_1.Size = new System.Drawing.Size(86, 85);
            this.p_1.TabIndex = 6;
            this.p_1.TabStop = false;
            this.p_1.Click += new System.EventHandler(this.p_1_Click);
            this.p_1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.p_1_MouseDown);
            this.p_1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.p_1_MouseUp);
            // 
            // p_4
            // 
            this.p_4.BackColor = System.Drawing.Color.DarkCyan;
            this.p_4.Location = new System.Drawing.Point(283, 214);
            this.p_4.Name = "p_4";
            this.p_4.Size = new System.Drawing.Size(86, 85);
            this.p_4.TabIndex = 7;
            this.p_4.TabStop = false;
            this.p_4.Click += new System.EventHandler(this.p_1_Click);
            this.p_4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.p_4_MouseDown);
            this.p_4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.p_4_MouseUp);
            // 
            // p_2
            // 
            this.p_2.BackColor = System.Drawing.Color.Lime;
            this.p_2.Location = new System.Drawing.Point(283, 97);
            this.p_2.Name = "p_2";
            this.p_2.Size = new System.Drawing.Size(86, 85);
            this.p_2.TabIndex = 8;
            this.p_2.TabStop = false;
            this.p_2.Click += new System.EventHandler(this.p_1_Click);
            this.p_2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.p_2_MouseDown);
            this.p_2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.p_2_MouseUp);
            // 
            // p_3
            // 
            this.p_3.BackColor = System.Drawing.Color.Yellow;
            this.p_3.Location = new System.Drawing.Point(130, 214);
            this.p_3.Name = "p_3";
            this.p_3.Size = new System.Drawing.Size(86, 85);
            this.p_3.TabIndex = 9;
            this.p_3.TabStop = false;
            this.p_3.Click += new System.EventHandler(this.p_1_Click);
            this.p_3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.p_3_MouseDown);
            this.p_3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.p_3_MouseUp);
            // 
            // SimonDice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(801, 512);
            this.Controls.Add(this.p_3);
            this.Controls.Add(this.p_2);
            this.Controls.Add(this.p_4);
            this.Controls.Add(this.p_1);
            this.Controls.Add(this.Inicio);
            this.Controls.Add(this.Puntaje);
            this.Name = "SimonDice";
            this.Text = "Simón Dice";
            ((System.ComponentModel.ISupportInitialize)(this.p_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Puntaje;
        private System.Windows.Forms.Button Inicio;
        private System.Windows.Forms.PictureBox p_1;
        private System.Windows.Forms.PictureBox p_4;
        private System.Windows.Forms.PictureBox p_2;
        private System.Windows.Forms.PictureBox p_3;
    }
}

