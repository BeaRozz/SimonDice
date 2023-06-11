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
            this.Jugadores = new System.Windows.Forms.TextBox();
            this.lista_Jugadores = new System.Windows.Forms.ListBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Agregar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Jugador = new System.Windows.Forms.TextBox();
            this.Puntos_Jug = new System.Windows.Forms.TextBox();
            this.Puntaje_Lista = new System.Windows.Forms.ListBox();
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
            this.Puntaje.Location = new System.Drawing.Point(317, 57);
            this.Puntaje.Name = "Puntaje";
            this.Puntaje.Size = new System.Drawing.Size(15, 16);
            this.Puntaje.TabIndex = 0;
            this.Puntaje.Text = "--";
            // 
            // Inicio
            // 
            this.Inicio.Enabled = false;
            this.Inicio.Location = new System.Drawing.Point(190, 334);
            this.Inicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.p_1.Location = new System.Drawing.Point(131, 97);
            this.p_1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.p_1.Name = "p_1";
            this.p_1.Size = new System.Drawing.Size(85, 85);
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
            this.p_4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.p_4.Name = "p_4";
            this.p_4.Size = new System.Drawing.Size(85, 85);
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
            this.p_2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.p_2.Name = "p_2";
            this.p_2.Size = new System.Drawing.Size(85, 85);
            this.p_2.TabIndex = 8;
            this.p_2.TabStop = false;
            this.p_2.Click += new System.EventHandler(this.p_1_Click);
            this.p_2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.p_2_MouseDown);
            this.p_2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.p_2_MouseUp);
            // 
            // p_3
            // 
            this.p_3.BackColor = System.Drawing.Color.Yellow;
            this.p_3.Location = new System.Drawing.Point(131, 214);
            this.p_3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.p_3.Name = "p_3";
            this.p_3.Size = new System.Drawing.Size(85, 85);
            this.p_3.TabIndex = 9;
            this.p_3.TabStop = false;
            this.p_3.Click += new System.EventHandler(this.p_1_Click);
            this.p_3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.p_3_MouseDown);
            this.p_3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.p_3_MouseUp);
            // 
            // Jugadores
            // 
            this.Jugadores.Location = new System.Drawing.Point(629, 224);
            this.Jugadores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Jugadores.Name = "Jugadores";
            this.Jugadores.Size = new System.Drawing.Size(100, 22);
            this.Jugadores.TabIndex = 10;
            this.Jugadores.TextChanged += new System.EventHandler(this.Jugadores_TextChanged);
            // 
            // lista_Jugadores
            // 
            this.lista_Jugadores.FormattingEnabled = true;
            this.lista_Jugadores.ItemHeight = 16;
            this.lista_Jugadores.Location = new System.Drawing.Point(506, 92);
            this.lista_Jugadores.Margin = new System.Windows.Forms.Padding(4);
            this.lista_Jugadores.Name = "lista_Jugadores";
            this.lista_Jugadores.Size = new System.Drawing.Size(159, 116);
            this.lista_Jugadores.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(579, 48);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(75, 22);
            this.textBox2.TabIndex = 12;
            this.textBox2.Text = "Jugadores";
            this.textBox2.UseWaitCursor = true;
            // 
            // Agregar
            // 
            this.Agregar.Enabled = false;
            this.Agregar.Location = new System.Drawing.Point(629, 255);
            this.Agregar.Margin = new System.Windows.Forms.Padding(4);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(100, 28);
            this.Agregar.TabIndex = 13;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(143, 15);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(60, 22);
            this.textBox1.TabIndex = 14;
            this.textBox1.Text = "Jugador";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(296, 15);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(55, 22);
            this.textBox3.TabIndex = 15;
            this.textBox3.Text = "Puntaje";
            // 
            // Jugador
            // 
            this.Jugador.Location = new System.Drawing.Point(143, 53);
            this.Jugador.Margin = new System.Windows.Forms.Padding(4);
            this.Jugador.Name = "Jugador";
            this.Jugador.ReadOnly = true;
            this.Jugador.Size = new System.Drawing.Size(60, 22);
            this.Jugador.TabIndex = 16;
            // 
            // Puntos_Jug
            // 
            this.Puntos_Jug.Location = new System.Drawing.Point(699, 48);
            this.Puntos_Jug.Margin = new System.Windows.Forms.Padding(4);
            this.Puntos_Jug.Name = "Puntos_Jug";
            this.Puntos_Jug.ReadOnly = true;
            this.Puntos_Jug.Size = new System.Drawing.Size(75, 22);
            this.Puntos_Jug.TabIndex = 18;
            this.Puntos_Jug.Text = "Puntajes";
            this.Puntos_Jug.UseWaitCursor = true;
            // 
            // Puntaje_Lista
            // 
            this.Puntaje_Lista.FormattingEnabled = true;
            this.Puntaje_Lista.ItemHeight = 16;
            this.Puntaje_Lista.Location = new System.Drawing.Point(699, 92);
            this.Puntaje_Lista.Margin = new System.Windows.Forms.Padding(4);
            this.Puntaje_Lista.Name = "Puntaje_Lista";
            this.Puntaje_Lista.Size = new System.Drawing.Size(159, 116);
            this.Puntaje_Lista.TabIndex = 17;
            // 
            // SimonDice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(996, 454);
            this.Controls.Add(this.Puntos_Jug);
            this.Controls.Add(this.Puntaje_Lista);
            this.Controls.Add(this.Jugador);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Agregar);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lista_Jugadores);
            this.Controls.Add(this.Jugadores);
            this.Controls.Add(this.p_3);
            this.Controls.Add(this.p_2);
            this.Controls.Add(this.p_4);
            this.Controls.Add(this.p_1);
            this.Controls.Add(this.Inicio);
            this.Controls.Add(this.Puntaje);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.TextBox Jugadores;
        private System.Windows.Forms.ListBox lista_Jugadores;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Agregar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox Jugador;
        private System.Windows.Forms.TextBox Puntos_Jug;
        private System.Windows.Forms.ListBox Puntaje_Lista;
    }
}

