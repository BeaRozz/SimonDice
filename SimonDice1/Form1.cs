using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SimonDice1
{
    public partial class SimonDice : Form
    {
        int CtrlSec = 0;
        Random NumeroAleatorio;
        int tiempo = 300;
        List<int> SD = new List<int>();
        bool Hablando = false;
        int J_Act = 0;

        public SimonDice()
        {
            InitializeComponent();
            NumeroAleatorio= new Random();
        }

        private void Inicio_Click(object sender, EventArgs e)
        {
            Agregar.Enabled = false;
            Inicio.Enabled = false;
            SD.Add(NumeroAleatorio.Next(1,5));
            new Thread(Iniciar_Juego).Start();
            Jugador.Text = lista_Jugadores.Items[J_Act].ToString();
            Puntaje.Text = Puntaje_Lista.Items[J_Act].ToString();
        }

        public void Iniciar_Juego()
        {
            Thread.Sleep(tiempo);
            Hablando= true;
            foreach(int i in SD)
            {
                Iluminado(i);
                Thread.Sleep(tiempo);
            }
            Hablando= false;
        }

        public void Iluminado(int i)
        {
            switch (i)
            {
                case 1:
                    p_1.BackColor = Color.Salmon;
                    Thread.Sleep(tiempo);
                    p_1.BackColor = Color.Red;
                    break;
                case 2:
                    p_2.BackColor = Color.SpringGreen;
                    Thread.Sleep(tiempo);
                    p_2.BackColor = Color.Green;
                    break;
                case 3:
                    p_3.BackColor = Color.LightGoldenrodYellow;
                    Thread.Sleep(tiempo);
                    p_3.BackColor = Color.Yellow;
                    break;
                case 4:
                    p_4.BackColor = Color.LightCyan;
                    Thread.Sleep(tiempo);
                    p_4.BackColor = Color.DarkCyan;
                    break;
            }
        }

        public void Verificar_Btn(int val)
        {
            if (Hablando || SD.Count == 0) return;
            if (SD[CtrlSec] == val) CtrlSec++;
            else
            {
                MessageBox.Show($"{lista_Jugadores.Items[J_Act]} eliminado, su puntuación es: {Puntaje_Lista.Items[J_Act]}");
                lista_Jugadores.Items.RemoveAt(J_Act);
                Puntaje_Lista.Items.RemoveAt(J_Act);
                CtrlSec = 0;

                if (lista_Jugadores.Items.Count == 0) ResetGame();
                else
                {
                    if (J_Act == lista_Jugadores.Items.Count) J_Act = 0;
                    Jugador.Text = lista_Jugadores.Items[J_Act].ToString();
                    Puntaje.Text = Puntaje_Lista.Items[J_Act].ToString();
                    new Thread(Iniciar_Juego).Start();
                }

            }
            
            if(CtrlSec >= SD.Count && lista_Jugadores.Items.Count != 0)
            {
                Thread.Sleep(tiempo);
                int number = int.Parse(Puntaje_Lista.Items[J_Act].ToString());
                Puntaje_Lista.Items[J_Act] = (number + 1).ToString();
                CtrlSec = 0;
                SD.Add(NumeroAleatorio.Next(1, 5));
                if (J_Act == lista_Jugadores.Items.Count - 1) J_Act = 0;
                else J_Act++;
                Jugador.Text = lista_Jugadores.Items[J_Act].ToString();
                Puntaje.Text = Puntaje_Lista.Items[J_Act].ToString();
                new Thread(Iniciar_Juego).Start();
            }
        }

        private void p_1_Click(object sender, EventArgs e)
        {
            if(Hablando == false)
            {
                String Presionado = ((PictureBox)sender).Name;
                string[] NBtn = Presionado.Split('_');
                Verificar_Btn(Convert.ToInt32(NBtn[1]));
            }
        }

        private void ResetGame()
        {
            CtrlSec = 0;
            SD = new List<int>();
            J_Act = 0;
            Puntaje.Text = "0";
            lista_Jugadores.Items.Clear();
            Puntaje_Lista.Items.Clear();
            Jugador.Text = "";
            /*p_1.BackColor = Color.Red;
            p_2.BackColor = Color.Green;
            p_3.BackColor = Color.Yellow;
            p_4.BackColor = Color.DarkCyan;*/
        }

        private void p_1_MouseDown(object sender, MouseEventArgs e)
        {
            if (Hablando == false) p_1.BackColor = Color.Salmon;
        }

        private void p_1_MouseUp(object sender, MouseEventArgs e)
        {
            if (Hablando == false) p_1.BackColor = Color.Red;
        }

        private void p_2_MouseDown(object sender, MouseEventArgs e)
        {
            if (Hablando == false) p_2.BackColor = Color.SpringGreen;
        }

        private void p_2_MouseUp(object sender, MouseEventArgs e)
        {
            if (Hablando == false) p_2.BackColor = Color.Green;
        }

        private void p_3_MouseDown(object sender, MouseEventArgs e)
        {
            if (Hablando == false) p_3.BackColor = Color.LightGoldenrodYellow;
        }

        private void p_3_MouseUp(object sender, MouseEventArgs e)
        {
            if (Hablando == false) p_3.BackColor = Color.Yellow;
        }

        private void p_4_MouseDown(object sender, MouseEventArgs e)
        {
            if (Hablando == false) p_4.BackColor = Color.LightCyan;
        }

        private void p_4_MouseUp(object sender, MouseEventArgs e)
        {
            if (Hablando == false) p_4.BackColor = Color.DarkCyan;
        }
        private void Agregar_Click(object sender, EventArgs e)
        {
            Inicio.Enabled = true; 
            if (lista_Jugadores.Items.Count < 4)
            {
                lista_Jugadores.Items.Add(Jugadores.Text);
                Puntaje_Lista.Items.Add("0");
                Jugadores.Text = "";
            }
            else
            {
                Jugadores.Text = "";
                MessageBox.Show("Maximo de jugadores es 4");               
            }
        }

        private void Jugadores_TextChanged(object sender, EventArgs e)
        {
            if(Jugadores.Text != "") Agregar.Enabled = true;
            else Agregar.Enabled = false;
        }
    }
}
