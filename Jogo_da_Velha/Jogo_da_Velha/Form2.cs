using System;
using System.Windows.Forms;

namespace Jogo_da_Velha
{
    public partial class frm_Nome : Form
    {
        public frm_Nome()
        {
            InitializeComponent();
        }

        private void btn_Nomes_Click(object sender, EventArgs e)
        {
            frm_Principal.Set_Nomes(txt_Nome1.Text, txt_Nome2.Text);
            this.Close();
        }

        private void frm_Nome_Load(object sender, EventArgs e)
        {
            txt_Nome1.Focus();
        }

        private void frm_Nome_Load_1(object sender, EventArgs e)
        {
            txt_Nome1.Focus();
        }
    }
}
