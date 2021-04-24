using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlockBreaker___Jogo
{
    public partial class frm_Jogo : Form
    {
        public int eixoX = 2, eixoY = 2, pontos = 0;
        public int aux1 = 0, aux2 = 0;

        bool jogando = true;

        public frm_Jogo(bool voltou, int velocidade)
        {
            InitializeComponent();
            timer1.Enabled = voltou;

            Random randNum = new Random();
            img_Bola.Top = randNum.Next(0,350);
            img_Bola.Left = randNum.Next(0,350);

            eixoX = eixoY = velocidade;
            if (eixoY == 1)
            {
                timer1.Interval = 10;
            }
            else if (eixoY == 5)
            {
                timer1.Interval = 5;
            }
            else if (eixoY == 10)
            {
                timer1.Interval = 1;
            }
            else if (eixoY == 17)
            {
                timer1.Interval = 1;
            }
        }

        private void btn_Pausar_Click(object sender, EventArgs e)
        {
            pan_JOGO.Focus();

            this.Hide();

            lbl_Placar.Text = "Enter para continuar";
            jogando = !jogando;
            Form5 f5 = new Form5("Jogo Pausado", eixoX);
            f5.ShowDialog();

        }

        private void click_continuar(object sender, EventArgs e)
        {
            if (!jogando)
            {
                jogando = !jogando;
                timer1.Enabled = jogando;
                lbl_Placar.Text = pontos.ToString() + " pts";
            }
        }

        private void tecla_pressionada(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Hide();
                jogando = !jogando;
                lbl_Placar.Text = "Enter para continuar";
                Form5 f5 = new Form5("Jogo Pausado", eixoX);
                f5.ShowDialog();
            }
            if (e.KeyCode == Keys.Enter)
            {
                if (!jogando)
                {
                    jogando = !jogando;
                    timer1.Enabled = jogando;
                }
            }
        }

        private void frm_Jogo_Load(object sender, EventArgs e)
        {
            pan_JOGO.BackColor = Color.Transparent;
            img_Plataforma.BackColor = Color.Transparent;
            img_Bola.BackColor = Color.Transparent;
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {


            img_Plataforma.Left = Cursor.Position.X - 5*(img_Plataforma.Size.Width);

            img_Bola.Left += eixoX;
            img_Bola.Top += eixoY;

            if (jogando) {
                
                if ((img_Bola.Bottom >= (lbl_Morte.Top - (eixoY+1))) && (img_Bola.Left >= img_Plataforma.Left) && (img_Bola.Right <= img_Plataforma.Right)) {

                    if (eixoX <= 20)
                    {
                        eixoX += 1;
                        eixoY += 1;
                    }

                    eixoY = -eixoY;

                    if ((img_Bola.Left <= (img_Plataforma.Right + img_Plataforma.Size.Width/2))&&(eixoX > 0)) {
                        eixoX = -eixoX;
                    }
                    if ((img_Bola.Left >= (img_Plataforma.Right - img_Plataforma.Size.Width / 2)) && (eixoX < 0))
                    {
                        eixoX = -eixoX;
                    }


                    pontos += 1;

                    lbl_Placar.Text = pontos.ToString() +" pts";
                }

                if (img_Bola.Left <= pan_JOGO.Left)
                {
                    eixoX = -eixoX;
                }
                if (img_Bola.Right >= pan_JOGO.Right)
                {
                    eixoX = -eixoX;
                }
                if (img_Bola.Top <= 0)
                {
                    eixoY = -eixoY;
                }
                if (img_Bola.Bottom >= lbl_Morte.Top)
                {
                    jogando = !jogando;
                    Form5 f5 = new Form5("Você Perdeu!", eixoX);
                    f5.ShowDialog();

                }

                if ((eixoX == 0)&&(eixoY == 0))
                {
                    eixoX = aux1;
                    eixoY = aux2;
                }
            }
            else
            {
                aux1 = eixoX;
                aux2 = eixoY;
                eixoX = 0;
                eixoY = 0;
                timer1.Enabled = jogando;
                jogando = !jogando;

            }
        }
    }
}
