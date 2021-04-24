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
    public partial class Form6 : Form
    {
        public int veloz = 2;


        public Form6()
        {
            InitializeComponent();

            if (box_Op.Text == "Selecione")
            {
                btn_Jogar.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(box_Op.Text == "Facil")
            {
                veloz = 1;
            }
            else if (box_Op.Text == "Medio")
            {
                veloz = 5;
            }
            else if (box_Op.Text == "Dificil")
            {
                veloz = 10;
            }
            else if (box_Op.Text == "Extremo")
            {
                veloz = 17;
            }

            if (Application.OpenForms.Count > 1)
            {
                Application.OpenForms[Application.OpenForms.Count - 2].Hide();
            }
            this.Close();

            frm_Jogo f4 = new frm_Jogo(true,veloz);
            f4.Show();
        }

        private void box_opcao_valida(object sender, EventArgs e)
        {
            if (box_Op.Text != "Selecione")
            {
                btn_Jogar.Enabled = true;
            }
        }
    }
}
