using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlockBreaker___Jogo
{
    public partial class frm_Principal : Form
    {
        public frm_Principal()
        {
            InitializeComponent();
        }

        private void MENU_mouseHover(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;

            lbl.BackColor = Color.White;
            lbl.ForeColor = Color.Black;
        }

        private void MENU_mouseLeave(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;

            lbl.BackColor = Color.Black;
            lbl.ForeColor = Color.White;
        }

        private void lbl_OP4_Click(object sender, EventArgs e)
        {
            Form f3 = new Form3();
            f3.ShowDialog();
        }

        private void lbl_creditos_Click(object sender, EventArgs e)
        {
            string url = "https://www.facebook.com/adriel.ricardo.a";
            Process.Start(url);
        }

        private void MENU_mouseEnter(object sender, EventArgs e)
        {

        }

        private void Credito_MouseEnter(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;

            lbl.BackColor = Color.FromArgb(255, 0, 100, 150);
            lbl.ForeColor = Color.FromArgb(255, 248, 252, 248);
        }

        private void Credito_MouseLeave(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;

            lbl.BackColor = Color.FromArgb(255, 248, 252, 248);
            lbl.ForeColor = Color.FromArgb(255, 0, 100, 150);
        }

        private void lbl_OP3_Click(object sender, EventArgs e)
        {
            Form f2 = new Form2();
            f2.ShowDialog();
        }

        private void VERSAO_MouseEnter(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;

            lbl.BackColor = Color.FromArgb(255, 0, 100, 150);
            lbl.ForeColor = Color.FromArgb(255, 248, 252, 248);

            img_Atualizacao.Visible = true;
        }

        private void VERSAO_MouseLeave(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;

            lbl.BackColor = Color.FromArgb(255, 248, 252, 248);
            lbl.ForeColor = Color.FromArgb(255, 0, 100, 150);

            img_Atualizacao.Visible = false;
        }

        private void lbl_OP1_Click(object sender, EventArgs e)
        {
            this.Hide();

            frm_Jogo f4 = new frm_Jogo(true, 2);
            f4.Show();
        }

        private void lbl_OP2_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.ShowDialog();
        }
        
    }
}
