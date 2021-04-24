using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Jogo_da_Velha
{
    public partial class frm_Principal : Form
    {
        bool turno = true;
        int cont_turno = 0;
        bool modo_PC = false;

        public frm_Principal()
        {
            InitializeComponent();
        }

        public static void Set_Nomes(string n1, string n2) {
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desenvolvido por Adriel Ricardo", "Sobre", MessageBoxButtons.OK);
        }

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            bool nome_OK = false;
            
            if (!modo_PC)
            {
                if (txt_P1.Text == txt_P2.Text | txt_P1.Text == "" | txt_P2.Text == "")
                {
                    if (txt_P1.Text == txt_P2.Text) {
                        MessageBox.Show("Use um Nome Diferente.", "Nomes Iguais", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_P2.Visible = true;
                        txt_P2.Focus();
                        txt_P2.Select();
                    }
                    else
                    {
                        MessageBox.Show("Nomes inválidos.", "Nome Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (txt_P1.Text == "")
                        {
                            txt_P1.Visible = true;
                            txt_P1.Focus();
                            txt_P1.Select();
                        }

                        else
                        {
                            txt_P2.Visible = true;
                            txt_P2.Focus();
                            txt_P2.Select();
                        }
                    }
                    
                    
                }

                else { 
                    nome_OK = true;
                }
            }

            else {

                if (txt_P1.Text.ToUpper() == "COMPUTADOR" | txt_P1.Text.ToUpper() == "VERSUS PC" | txt_P1.Text == "")
                {
                    if (txt_P1.Text.ToUpper() == "COMPUTADOR" | txt_P1.Text.ToUpper() == "VERSUS PC")
                    {
                        MessageBox.Show("Use um Nome Diferente.", "Nome Inválido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (txt_P1.Text == "") {
                        MessageBox.Show("Nome inválido.", "Nome Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    txt_P1.Visible = true;
                    txt_P1.Focus();
                    txt_P1.Select();

                }

                else
                {
                    nome_OK = true;
                }
            }

            if (nome_OK) {

                if (turno)
                {
                    b.Text = "X";
                }
                else
                {
                    b.Text = "O";
                }

                turno = !turno;
                cont_turno++;

                b.Enabled = false;

                Check_Vencedor();

                if ((!turno) && (modo_PC))
                {
                    mov_PC();
                }

                if (txt_P1.Visible)
                {
                    txt_P2.Visible = txt_P1.Visible = false;
                    lbl_P2.Text = txt_P2.Text;
                    lbl_P1.Text = txt_P1.Text;
                    lbl_P1.Visible = lbl_P2.Visible = true;
                }
            }

        }

        private void mov_PC()
        {
            try
            {
                Button move = null;

                move = Pega_Vencedor_ou_Posicao("O");

                if (move == null)
                {
                    move = Pega_Vencedor_ou_Posicao("X");
                    if (move == null)
                    {
                        move = Pega_Lateral();
                        if (move == null)
                        {
                            move = Pega_Vazio();
                        }
                    }
                }

                int n = 0;
                Random rnd = new Random(DateTime.Now.Millisecond);

                n = rnd.Next(500, 2000);
                Thread.Sleep(n);


                if (move != null) {
                    move.PerformClick();
                }
                else
                {
                    MessageBox.Show("Deu esse erro...","Erro..");
                }
                
            }
            catch { }
        }

        private Button Pega_Vazio()
        {

            Console.WriteLine("Pegando Espaço Vazio");

            Button b = null;

            foreach (Control c in Controls)
            {
                b = c as Button;
                if (b != null)
                {
                    if (b.Text == "")
                        return b;
                }
            }

            return null;
        }

        private Button Pega_Lateral()
        {

            Console.WriteLine("Pegando Letra Lateral");

            if (btn_A1.Text == "O")
            {
                if (btn_A3.Text == "")
                {
                    return btn_A3;
                }
                if (btn_C3.Text == "")
                {
                    return btn_C3;
                }
                if (btn_C1.Text == "")
                {
                    return btn_C1;
                }
            }
            if (btn_A3.Text == "O")
            {
                if (btn_A1.Text == "")
                {
                    return btn_A1;
                }
                if (btn_C3.Text == "")
                {
                    return btn_C3;
                }
                if (btn_C1.Text == "")
                {
                    return btn_C1;
                }
            }

            if (btn_C1.Text == "O")
            {
                if (btn_A3.Text == "")
                {
                    return btn_A3;
                }
                if (btn_C3.Text == "")
                {
                    return btn_C3;
                }
                if (btn_A1.Text == "")
                {
                    return btn_A1;
                }
            }

            if (btn_C3.Text == "O")
            {
                if (btn_A3.Text == "")
                {
                    return btn_A3;
                }
                if (btn_A1.Text == "")
                {
                    return btn_A1;
                }
                if (btn_C1.Text == "")
                {
                    return btn_C1;
                }
            }

            if (btn_A1.Text == "")
            {
                return btn_A1;
            }
            if (btn_A3.Text == "")
            {
                return btn_A3;
            }
            if (btn_C1.Text == "")
            {
                return btn_C1;
            }
            if (btn_C3.Text == "")
            {
                return btn_C3;
            }


            return null;
        }

        private Button Pega_Vencedor_ou_Posicao(string letra)
        {

            Console.WriteLine("Pegando Posição Vencedora: " + letra);

            if ((btn_A1.Text == letra) && (btn_A2.Text == letra) &&(btn_A3.Text == ""))
            {
                return btn_A3;
            }
            if ((btn_A1.Text == letra) && (btn_A3.Text == letra) && (btn_A2.Text == ""))
            {
                return btn_A2;
            }
            if ((btn_A2.Text == letra) && (btn_A3.Text == letra) && (btn_A1.Text == ""))
            {
                return btn_A1;
            }
            if ((btn_B1.Text == letra) && (btn_B2.Text == letra) && (btn_B3.Text == ""))
            {
                return btn_B3;
            }
            if ((btn_B1.Text == letra) && (btn_B3.Text == letra) && (btn_B2.Text == ""))
            {
                return btn_B2;
            }
            if ((btn_B2.Text == letra) && (btn_B3.Text == letra) && (btn_B1.Text == ""))
            {
                return btn_B1;
            }
            if ((btn_C1.Text == letra) && (btn_C2.Text == letra) && (btn_C3.Text == ""))
            {
                return btn_C3;
            }
            if ((btn_C1.Text == letra) && (btn_C3.Text == letra) && (btn_C2.Text == ""))
            {
                return btn_C2;
            }
            if ((btn_C2.Text == letra) && (btn_C3.Text == letra) && (btn_C1.Text == ""))
            {
                return btn_C1;
            }

            if ((btn_A1.Text == letra) && (btn_B1.Text == letra) && (btn_C1.Text == ""))
            {
                return btn_C1;
            }
            if ((btn_A1.Text == letra) && (btn_C1.Text == letra) && (btn_B1.Text == ""))
            {
                return btn_B1;
            }
            if ((btn_B1.Text == letra) && (btn_C1.Text == letra) && (btn_A1.Text == ""))
            {
                return btn_A1;
            }
            if ((btn_A2.Text == letra) && (btn_B2.Text == letra) && (btn_C2.Text == ""))
            {
                return btn_C2;
            }
            if ((btn_A2.Text == letra) && (btn_C2.Text == letra) && (btn_B2.Text == ""))
            {
                return btn_B2;
            }
            if ((btn_B2.Text == letra) && (btn_C2.Text == letra) && (btn_A2.Text == ""))
            {
                return btn_A2;
            }
            if ((btn_A3.Text == letra) && (btn_B3.Text == letra) && (btn_C3.Text == ""))
            {
                return btn_C3;
            }
            if ((btn_A3.Text == letra) && (btn_C3.Text == letra) && (btn_B3.Text == ""))
            {
                return btn_B3;
            }
            if ((btn_B3.Text == letra) && (btn_C3.Text == letra) && (btn_A3.Text == ""))
            {
                return btn_A3;
            }

            if ((btn_A1.Text == letra) && (btn_B2.Text == letra) && (btn_C3.Text == ""))
            {
                return btn_C3;
            }
            if ((btn_A1.Text == letra) && (btn_C3.Text == letra) && (btn_B2.Text == ""))
            {
                return btn_B2;
            }
            if ((btn_B2.Text == letra) && (btn_C3.Text == letra) && (btn_A1.Text == ""))
            {
                return btn_A1;
            }

            if ((btn_C1.Text == letra) && (btn_B2.Text == letra) && (btn_A3.Text == ""))
            {
                return btn_A3;
            }
            if ((btn_C1.Text == letra) && (btn_A3.Text == letra) && (btn_B2.Text == ""))
            {
                return btn_B2;
            }
            if ((btn_A3.Text == letra) && (btn_B2.Text == letra) && (btn_C1.Text == ""))
            {
                return btn_C1;
            }

            return null;
        }

        private void Check_Vencedor()
        {
            bool Temos_Vencedor = false;

            if ((btn_A1.Text == btn_A2.Text) && (btn_A2.Text == btn_A3.Text) && (!btn_A1.Enabled))
            {
                Temos_Vencedor = true;
            }
            else if ((btn_B1.Text == btn_B2.Text) && (btn_B2.Text == btn_B3.Text) && (!btn_B1.Enabled))
            {
                Temos_Vencedor = true;
            }
            else if ((btn_C1.Text == btn_C2.Text) && (btn_C2.Text == btn_C3.Text) && (!btn_C1.Enabled))
            {
                Temos_Vencedor = true;
            }
            else if ((btn_A1.Text == btn_B1.Text) && (btn_B1.Text == btn_C1.Text) && (!btn_A1.Enabled))
            {
                Temos_Vencedor = true;
            }
            else if ((btn_A2.Text == btn_B2.Text) && (btn_B2.Text == btn_C2.Text) && (!btn_A2.Enabled))
            {
                Temos_Vencedor = true;
            }
            else if ((btn_A3.Text == btn_B3.Text) && (btn_B3.Text == btn_C3.Text) && (!btn_A3.Enabled))
            {
                Temos_Vencedor = true;
            }
            else if ((btn_A1.Text == btn_B2.Text) && (btn_B2.Text == btn_C3.Text) && (!btn_A1.Enabled))
            {
                Temos_Vencedor = true;
            }
            else if ((btn_A3.Text == btn_B2.Text) && (btn_B2.Text == btn_C1.Text) && (!btn_A3.Enabled))
            {
                Temos_Vencedor = true;
            }


            string Vencedor = "";

            if (Temos_Vencedor)
            {

                desativa_btn();

                if (turno)
                {
                    if (!modo_PC)
                    {
                        Vencedor = lbl_P2.Text;
                    }
                    else
                    {
                         Vencedor = "Computador";
                    }
                    lbl_VitoriaO.Text = (int.Parse(lbl_VitoriaO.Text)+1).ToString();
                }
                else
                {
                    Vencedor = lbl_P1.Text;
                    lbl_VitoriaX.Text = (int.Parse(lbl_VitoriaX.Text) + 1).ToString();
                }

                

                MessageBox.Show("Vencedor: " + Vencedor, "Vitória", MessageBoxButtons.OK);
                Limpa_jogo();
            }
            else if (cont_turno == 9)
            {
                lbl_EmpateCont.Text = (int.Parse(lbl_EmpateCont.Text) + 1).ToString();
                MessageBox.Show("Deu Velha", "Sem Vitória", MessageBoxButtons.OK);
                Limpa_jogo();
            }
        }

        private void desativa_btn()
        {
            try
            {
                foreach (Control C in Controls)
                {
                    Button b = (Button)C;
                    b.Enabled = false;
                }
            }
            catch {}
        }
        

        private void Limpa_jogo()
        {
            turno = true;
            cont_turno = 0;

            foreach (Control C in Controls)
            {
                try
                {
                    Button b = (Button)C;
                    b.Text = "";
                    b.Enabled = true;
                }
                catch { }
            }
        }

        private void button_enter(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (b.Enabled)
            {
                if (turno)
                {
                    b.Text = "X";
                }
                else
                {
                    b.Text = "O";
                }
            }
        }

        private void button_leave(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (b.Enabled)
            {
                b.Text = "";
            }
        }

        private void frm_Principal_Load(object sender, EventArgs e)
        {
            txt_P1.Focus();
            txt_P1.Select();
        }

        private void Zerar_Placar_Click(object sender, EventArgs e)
        {
            Limpa_jogo();
            txt_P1.Text = "Jogador 1";
            if (!modo_PC) { txt_P2.Text = "Jogador 2"; }
            else { txt_P2.Text = "Versus PC"; }
            if (!txt_P1.Visible)
            {
                lbl_P1.Visible = false;
                txt_P1.Visible = true;
                if (!modo_PC) { txt_P2.Visible = true; lbl_P2.Visible = false; }
                lbl_P2.Text = txt_P2.Text;
                lbl_P1.Text = txt_P1.Text;
            }
            lbl_VitoriaX.Text = Convert.ToString(0);
            lbl_VitoriaO.Text = Convert.ToString(0);
            lbl_EmpateCont.Text = Convert.ToString(0);
            txt_P1.Focus();
            txt_P1.Select();
        }

        private void Modo_PxC_Click(object sender, EventArgs e)
        {
            if (!modo_PC)
            {
                modo_PC = true;
                Limpa_jogo();
                txt_P1.Text = "Jogador 1";
                lbl_P2.Text = txt_P2.Text = "Versus PC";
                txt_P2.Visible = false;
                lbl_P2.Visible = true;

                if (!txt_P1.Visible)
                {
                    lbl_P1.Visible = false;
                    txt_P1.Visible = true;
                    lbl_P1.Text = txt_P1.Text;
                }
                
                lbl_VitoriaX.Text = Convert.ToString(0);
                lbl_VitoriaO.Text = Convert.ToString(0);
                lbl_EmpateCont.Text = Convert.ToString(0);
                txt_P1.Focus();
                txt_P1.Select();
            }
            else
            {
                MessageBox.Show("Modo Já Está Ativado!", "Contra Computador", MessageBoxButtons.OK);
                MessageBox.Show("Escolha Zerar Placar!", "Novo Jogador?", MessageBoxButtons.OK);
            }
        }

        private void Modo_PxP_Click(object sender, EventArgs e)
        {
            if (modo_PC)
            {
                modo_PC = false;
                Limpa_jogo();
                txt_P1.Text = "Jogador 1";
                txt_P2.Text = "Jogador 2";

                if (!txt_P1.Visible)
                {
                    lbl_P2.Visible = lbl_P1.Visible = false;
                    txt_P2.Visible = txt_P1.Visible = true;
                    lbl_P2.Text = txt_P2.Text;
                    lbl_P1.Text = txt_P1.Text;
                }

                lbl_VitoriaX.Text = Convert.ToString(0);
                lbl_VitoriaO.Text = Convert.ToString(0);
                lbl_EmpateCont.Text = Convert.ToString(0);
                txt_P1.Focus();
                txt_P1.Select();
            }
            else
            {
                MessageBox.Show("Modo Já Está Ativado!", "Contra Amigos", MessageBoxButtons.OK);
                MessageBox.Show("Escolha Zerar Placar!", "Novos Jogadores?", MessageBoxButtons.OK);
            }
        }
    }
}
