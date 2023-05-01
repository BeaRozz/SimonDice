using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimonDice1
{
    public partial class SimonDice : Form
    {
        int CtrlSec = 0;
        Random NumeroAleatorio;
        int tiempo = 500;
        List<int> SD = new List<int>();
        bool Hablando = false;

        public SimonDice()
        {
            InitializeComponent();
            NumeroAleatorio= new Random();
        }

        private void Inicio_Click(object sender, EventArgs e)
        {
            SD.Add(NumeroAleatorio.Next(1,5));
            new Thread(Iniciar_Juego).Start();
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
                MessageBox.Show($"Tu Record final es: {SD.Count - 1}");
                CtrlSec = 0;
                SD = new List<int>();
            }
            
            if(CtrlSec >= SD.Count)
            {
                CtrlSec = 0;
                SD.Add(NumeroAleatorio.Next(1, 5));
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
    }
}
