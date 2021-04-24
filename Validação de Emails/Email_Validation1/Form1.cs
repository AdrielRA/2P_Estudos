using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Email_Validation1
{
    public partial class frm_Principal : Form
    {
        public frm_Principal()
        {
            InitializeComponent();
        }

        private void btn_Val_Click(object sender, EventArgs e)
        {
            string email = txt_Email.Text;

            Regex rg = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

            if (rg.IsMatch(email))
            {
                txt_Val.Text = "Email Válido!";
            }
            else
            {
                if (txt_Email.Text == "")
                {
                    txt_Val.Text = "Digite um E-mail";
                }
                else
                {
                    txt_Val.Text = "Email Inválido!";
                }
            }
        }

        private void btn_Limpa_Click(object sender, EventArgs e)
        {
            txt_Email.Text = "";
            txt_Senha.Text = "";
            txt_Val.Text = "";
        }

        private void lb_Recovery_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A senha é meramente ilustrativa.");
        }

        private void lb_Infos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Contato: adrieldesigner@hotmail.com");
        }

        private void txt_Email_TextChanged(object sender, EventArgs e)
        {
            txt_Val.Text = "";
        }
    }
}
