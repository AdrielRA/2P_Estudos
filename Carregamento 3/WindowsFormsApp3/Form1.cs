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

namespace WindowsFormsApp3
{
    public partial class frm_Supermercado : Form
    {
        public frm_Supermercado()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lb_Relogio.Text = DateTime.Now.ToLongTimeString();
        }

        private void btn_Rodar_Click(object sender, EventArgs e)
        {
            int i;
            for (i = 0; i < 100; i++) {
                Thread.Sleep(100);
                lb_Processo.Text = "Processo" + Convert.ToString(i) + "/100";
            }
        }
    }
}
