using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lb_porcent.Text = pb_Carregamento.Value + "%";
            if (pb_Carregamento.Value < 100) {
                pb_Carregamento.Value++;
            }
            else
            {
                tm_Tempo.Stop();
                tm_Tempo.Enabled = false;
                frm_Concluido form = new frm_Concluido();
                form.Show();
                this.Hide();
            }
        }
    }
}
