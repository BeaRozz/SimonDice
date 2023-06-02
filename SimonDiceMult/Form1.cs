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
        int tiempo = 500;
        List<int> SD = new List<int>();
        bool Hablando = false;
        int elementosAgregados = 0;
        int restantes = 0;
        int J_Act = 0;
        bool keep = true;

        public SimonDice()
        {
            InitializeComponent();
            NumeroAleatorio= new Random();
        }

        private void Inicio_Click(object sender, EventArgs e)
        {
            SD.Add(NumeroAleatorio.Next(1,5));
            new Thread(Iniciar_Juego).Start();
            Jugador.Text = lista_Jugadores.Items[J_Act].ToString();
            restantes = elementosAgregados;
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
                restantes = restantes - 1;
                if (restantes == 0)
                {
                    MessageBox.Show($"Tu récord final es: {SD.Count - 1}");
                    keep = false;
                }
                else
                {
                    MessageBox.Show($"{lista_Jugadores.Items[J_Act]} eliminado");
                    lista_Jugadores.Items.RemoveAt(J_Act);
                    Jugador.Text = lista_Jugadores.Items[J_Act].ToString();
                    if (restantes == 1)
                    {
                        MessageBox.Show($"{lista_Jugadores.Items[J_Act]} es el ganador");
                        //CtrlSec = 0;
                        //SD = new List<int>();
                        keep = false;
                        lista_Jugadores.Items.RemoveAt(J_Act);
                    }
                    else
                    {
                        new Thread(Iniciar_Juego).Start();
                    }
                }

            }
            
            if(CtrlSec >= SD.Count && keep)
            {
                CtrlSec = 0;
                SD.Add(NumeroAleatorio.Next(1, 5));
                if (J_Act == restantes - 1) J_Act = 0;
                else J_Act++;
                Jugador.Text = lista_Jugadores.Items[J_Act].ToString();
                new Thread(Iniciar_Juego).Start();
            }
            Puntaje.Text = (SD.Count-1).ToString();
        }

        private void p_1_Click(object sender, EventArgs e)
        {
            String Presionado = ((PictureBox)sender).Name;
            string[] NBtn = Presionado.Split('_');
            Verificar_Btn(Convert.ToInt32(NBtn[1]));
        }

        private void p_1_MouseDown(object sender, MouseEventArgs e)
        {
            p_1.BackColor = Color.Salmon;
        }

        private void p_1_MouseUp(object sender, MouseEventArgs e)
        {
            p_1.BackColor = Color.Red;
        }

        private void p_2_MouseDown(object sender, MouseEventArgs e)
        {
            p_2.BackColor = Color.SpringGreen;
        }

        private void p_2_MouseUp(object sender, MouseEventArgs e)
        {
            p_2.BackColor = Color.Green;
        }

        private void p_3_MouseDown(object sender, MouseEventArgs e)
        {
            p_3.BackColor = Color.LightGoldenrodYellow;
        }

        private void p_3_MouseUp(object sender, MouseEventArgs e)
        {
            p_3.BackColor = Color.Yellow;
        }

        private void p_4_MouseDown(object sender, MouseEventArgs e)
        {
            p_4.BackColor = Color.LightCyan;
        }

        private void p_4_MouseUp(object sender, MouseEventArgs e)
        {
            p_4.BackColor = Color.DarkCyan;
        }
        private void Agregar_Click(object sender, EventArgs e)
        {
             if (elementosAgregados < 4)
            {
                string nuevoElemento = Jugadores.Text;
                lista_Jugadores.Items.Add(nuevoElemento);
                Jugadores.Text = "";
                elementosAgregados++;
            }
            else
            {
                Jugadores.Text = "";
                MessageBox.Show("Maximo de jugadores es 4");               
            }
        }
    }
}
