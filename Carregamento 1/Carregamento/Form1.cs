using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carregamento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tm_Carregando_Tick(object sender, EventArgs e)
        {
            lb_Percentual.Text = pb_Carregamento.Value + "%";
            if (pb_Carregamento.Value < 100)
            {
                pb_Carregamento.Value = pb_Carregamento.Value + 1;
            }
            else
            {
                tm_Carregando.Stop();
                tm_Carregando.Enabled = false;
                lb_Titulo.Text = "Carregamento Concluído";
                Form3 form = new Form3();
                Show();
                this.Visible = false;
            }
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
