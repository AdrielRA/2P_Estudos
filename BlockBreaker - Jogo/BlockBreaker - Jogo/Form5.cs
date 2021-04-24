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
    public partial class Form5 : Form
    {
        public int veloz = 2;

        public Form5()
        {
            InitializeComponent();
        }

        public Form5(string titulo, int vel)
        {
            InitializeComponent();
            veloz = vel;
            lbl_Pausado.Text = titulo;
            if (titulo == "Você Perdeu!")
            {
                btn_VoltaJOGO.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            if (Application.OpenForms.Count > 2)
            {
                Application.OpenForms[Application.OpenForms.Count - 2].Close();
            }
            frm_Principal f1 = new frm_Principal();
            f1.Show();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            if (Application.OpenForms.Count > 1) { Application.OpenForms[Application.OpenForms.Count - 2].Show();
            }
        }

        private void btn_NovoJogo_Click(object sender, EventArgs e)
        {
            this.Close();
            if (Application.OpenForms.Count > 2)
            {
                Application.OpenForms[Application.OpenForms.Count - 2].Close();
            }
            frm_Jogo f2 = new frm_Jogo(true, veloz);
            f2.Show();
        }
    }
}
