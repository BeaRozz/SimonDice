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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimonDice));
            this.Puntaje = new System.Windows.Forms.Label();
            this.Inicio = new System.Windows.Forms.Button();
            this.Jugadores = new System.Windows.Forms.TextBox();
            this.lista_Jugadores = new System.Windows.Forms.ListBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Agregar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Jugador = new System.Windows.Forms.TextBox();
            this.Puntos_Jug = new System.Windows.Forms.TextBox();
            this.Puntaje_Lista = new System.Windows.Forms.ListBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.p_9 = new System.Windows.Forms.PictureBox();
            this.p_8 = new System.Windows.Forms.PictureBox();
            this.p_7 = new System.Windows.Forms.PictureBox();
            this.p_6 = new System.Windows.Forms.PictureBox();
            this.p_5 = new System.Windows.Forms.PictureBox();
            this.p_3 = new System.Windows.Forms.PictureBox();
            this.p_2 = new System.Windows.Forms.PictureBox();
            this.p_4 = new System.Windows.Forms.PictureBox();
            this.p_1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.p_9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Puntaje
            // 
            this.Puntaje.AutoSize = true;
            this.Puntaje.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Puntaje.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Puntaje.Location = new System.Drawing.Point(1037, 149);
            this.Puntaje.Name = "Puntaje";
            this.Puntaje.Size = new System.Drawing.Size(18, 18);
            this.Puntaje.TabIndex = 0;
            this.Puntaje.Text = "--";
            // 
            // Inicio
            // 
            this.Inicio.Enabled = false;
            this.Inicio.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inicio.Location = new System.Drawing.Point(417, 510);
            this.Inicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Inicio.Name = "Inicio";
            this.Inicio.Size = new System.Drawing.Size(191, 45);
            this.Inicio.TabIndex = 5;
            this.Inicio.Text = "Iniciar juego";
            this.Inicio.UseVisualStyleBackColor = true;
            this.Inicio.Click += new System.EventHandler(this.Inicio_Click);
            // 
            // Jugadores
            // 
            this.Jugadores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Jugadores.Location = new System.Drawing.Point(1248, 353);
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
            this.lista_Jugadores.Location = new System.Drawing.Point(1177, 169);
            this.lista_Jugadores.Margin = new System.Windows.Forms.Padding(4);
            this.lista_Jugadores.Name = "lista_Jugadores";
            this.lista_Jugadores.Size = new System.Drawing.Size(102, 116);
            this.lista_Jugadores.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1177, 120);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(102, 22);
            this.textBox2.TabIndex = 12;
            this.textBox2.Text = "Jugadores";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.UseWaitCursor = true;
            // 
            // Agregar
            // 
            this.Agregar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Agregar.Enabled = false;
            this.Agregar.Location = new System.Drawing.Point(1248, 402);
            this.Agregar.Margin = new System.Windows.Forms.Padding(4);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(100, 28);
            this.Agregar.TabIndex = 13;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = false;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(398, 89);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(85, 23);
            this.textBox1.TabIndex = 14;
            this.textBox1.Text = "Jugador:";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(1007, 98);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(82, 23);
            this.textBox3.TabIndex = 15;
            this.textBox3.Text = "Puntaje";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Jugador
            // 
            this.Jugador.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Jugador.Location = new System.Drawing.Point(609, 89);
            this.Jugador.Margin = new System.Windows.Forms.Padding(4);
            this.Jugador.Name = "Jugador";
            this.Jugador.ReadOnly = true;
            this.Jugador.Size = new System.Drawing.Size(83, 23);
            this.Jugador.TabIndex = 16;
            this.Jugador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Puntos_Jug
            // 
            this.Puntos_Jug.Location = new System.Drawing.Point(1309, 120);
            this.Puntos_Jug.Margin = new System.Windows.Forms.Padding(4);
            this.Puntos_Jug.Name = "Puntos_Jug";
            this.Puntos_Jug.ReadOnly = true;
            this.Puntos_Jug.Size = new System.Drawing.Size(96, 22);
            this.Puntos_Jug.TabIndex = 18;
            this.Puntos_Jug.Text = "Puntajes";
            this.Puntos_Jug.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Puntos_Jug.UseWaitCursor = true;
            // 
            // Puntaje_Lista
            // 
            this.Puntaje_Lista.FormattingEnabled = true;
            this.Puntaje_Lista.ItemHeight = 16;
            this.Puntaje_Lista.Location = new System.Drawing.Point(1309, 169);
            this.Puntaje_Lista.Margin = new System.Windows.Forms.Padding(4);
            this.Puntaje_Lista.Name = "Puntaje_Lista";
            this.Puntaje_Lista.Size = new System.Drawing.Size(96, 116);
            this.Puntaje_Lista.TabIndex = 17;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(83, 13);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(913, 47);
            this.textBox4.TabIndex = 19;
            this.textBox4.Text = "1. Sigue las instrucciones de \"Simón\": Repite la secuencia de prendido que Simón " +
    "muestra.\r\n2. No te equivoques: Si te equivocas en la secuencia, pierdes. ¡Sé ráp" +
    "ido y preciso!";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // p_9
            // 
            this.p_9.BackColor = System.Drawing.Color.Transparent;
            this.p_9.Image = global::SimonDice1.Properties.Resources.idk_1;
            this.p_9.Location = new System.Drawing.Point(827, 149);
            this.p_9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.p_9.Name = "p_9";
            this.p_9.Size = new System.Drawing.Size(136, 136);
            this.p_9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.p_9.TabIndex = 24;
            this.p_9.TabStop = false;
            this.p_9.Click += new System.EventHandler(this.p_1_Click);
            this.p_9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.p_9_MouseDown);
            this.p_9.MouseUp += new System.Windows.Forms.MouseEventHandler(this.p_9_MouseUp);
            // 
            // p_8
            // 
            this.p_8.BackColor = System.Drawing.Color.Transparent;
            this.p_8.Image = global::SimonDice1.Properties.Resources.badt_1;
            this.p_8.Location = new System.Drawing.Point(755, 326);
            this.p_8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.p_8.Name = "p_8";
            this.p_8.Size = new System.Drawing.Size(117, 117);
            this.p_8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.p_8.TabIndex = 23;
            this.p_8.TabStop = false;
            this.p_8.Click += new System.EventHandler(this.p_1_Click);
            this.p_8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.p_8_MouseDown);
            this.p_8.MouseUp += new System.Windows.Forms.MouseEventHandler(this.p_8_MouseUp);
            // 
            // p_7
            // 
            this.p_7.BackColor = System.Drawing.Color.Transparent;
            this.p_7.Image = global::SimonDice1.Properties.Resources.choco_1;
            this.p_7.Location = new System.Drawing.Point(641, 136);
            this.p_7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.p_7.Name = "p_7";
            this.p_7.Size = new System.Drawing.Size(150, 150);
            this.p_7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.p_7.TabIndex = 22;
            this.p_7.TabStop = false;
            this.p_7.Click += new System.EventHandler(this.p_1_Click);
            this.p_7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.p_7_MouseDown);
            this.p_7.MouseUp += new System.Windows.Forms.MouseEventHandler(this.p_7_MouseUp);
            // 
            // p_6
            // 
            this.p_6.BackColor = System.Drawing.Color.Transparent;
            this.p_6.Image = global::SimonDice1.Properties.Resources.kepo_1;
            this.p_6.Location = new System.Drawing.Point(566, 326);
            this.p_6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.p_6.Name = "p_6";
            this.p_6.Size = new System.Drawing.Size(117, 117);
            this.p_6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.p_6.TabIndex = 21;
            this.p_6.TabStop = false;
            this.p_6.Click += new System.EventHandler(this.p_1_Click);
            this.p_6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.p_6_MouseDown);
            this.p_6.MouseUp += new System.Windows.Forms.MouseEventHandler(this.p_6_MouseUp);
            // 
            // p_5
            // 
            this.p_5.BackColor = System.Drawing.Color.Transparent;
            this.p_5.Image = global::SimonDice1.Properties.Resources.kitty_1;
            this.p_5.Location = new System.Drawing.Point(460, 164);
            this.p_5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.p_5.Name = "p_5";
            this.p_5.Size = new System.Drawing.Size(138, 138);
            this.p_5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.p_5.TabIndex = 20;
            this.p_5.TabStop = false;
            this.p_5.Click += new System.EventHandler(this.p_1_Click);
            this.p_5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.p_5_MouseDown);
            this.p_5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.p_5_MouseUp);
            // 
            // p_3
            // 
            this.p_3.BackColor = System.Drawing.Color.Transparent;
            this.p_3.Image = global::SimonDice1.Properties.Resources.pochaco_1;
            this.p_3.Location = new System.Drawing.Point(147, 323);
            this.p_3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.p_3.Name = "p_3";
            this.p_3.Size = new System.Drawing.Size(120, 120);
            this.p_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.p_3.TabIndex = 9;
            this.p_3.TabStop = false;
            this.p_3.Click += new System.EventHandler(this.p_1_Click);
            this.p_3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.p_3_MouseDown);
            this.p_3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.p_3_MouseUp);
            // 
            // p_2
            // 
            this.p_2.BackColor = System.Drawing.Color.Transparent;
            this.p_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.p_2.Image = global::SimonDice1.Properties.Resources.my_melody_1;
            this.p_2.Location = new System.Drawing.Point(259, 157);
            this.p_2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.p_2.Name = "p_2";
            this.p_2.Size = new System.Drawing.Size(145, 145);
            this.p_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.p_2.TabIndex = 8;
            this.p_2.TabStop = false;
            this.p_2.Click += new System.EventHandler(this.p_1_Click);
            this.p_2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.p_2_MouseDown);
            this.p_2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.p_2_MouseUp);
            // 
            // p_4
            // 
            this.p_4.BackColor = System.Drawing.Color.Transparent;
            this.p_4.Image = global::SimonDice1.Properties.Resources.pom_1;
            this.p_4.Location = new System.Drawing.Point(359, 326);
            this.p_4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.p_4.Name = "p_4";
            this.p_4.Size = new System.Drawing.Size(117, 117);
            this.p_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.p_4.TabIndex = 7;
            this.p_4.TabStop = false;
            this.p_4.Click += new System.EventHandler(this.p_1_Click);
            this.p_4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.p_4_MouseDown);
            this.p_4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.p_4_MouseUp);
            // 
            // p_1
            // 
            this.p_1.BackColor = System.Drawing.Color.Transparent;
            this.p_1.Image = global::SimonDice1.Properties.Resources.kuromi_1;
            this.p_1.Location = new System.Drawing.Point(110, 169);
            this.p_1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.p_1.Name = "p_1";
            this.p_1.Size = new System.Drawing.Size(117, 117);
            this.p_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.p_1.TabIndex = 6;
            this.p_1.TabStop = false;
            this.p_1.Click += new System.EventHandler(this.p_1_Click);
            this.p_1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.p_1_MouseDown);
            this.p_1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.p_1_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1132, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(315, 647);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(300, 466);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(153, 89);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // SimonDice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1441, 577);
            this.Controls.Add(this.p_9);
            this.Controls.Add(this.p_8);
            this.Controls.Add(this.p_7);
            this.Controls.Add(this.p_6);
            this.Controls.Add(this.p_5);
            this.Controls.Add(this.textBox4);
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
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SimonDice";
            this.Text = "Simón Dice";
            ((System.ComponentModel.ISupportInitialize)(this.p_9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.PictureBox p_5;
        private System.Windows.Forms.PictureBox p_6;
        private System.Windows.Forms.PictureBox p_7;
        private System.Windows.Forms.PictureBox p_8;
        private System.Windows.Forms.PictureBox p_9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

