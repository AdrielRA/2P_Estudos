using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matrizes
{
    public partial class frm_Tamanho : Form
    {
        public frm_Tamanho()
        {
            InitializeComponent();
            lbl_titulo.Text = this.Text;
        }

        private void lbl_X_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_OK1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void lbl_X_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
