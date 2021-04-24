using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classes
{
    public partial class frmPrincipal : Form
    {

        Controles pessoa = new Controles();

        public frmPrincipal()
        {
            InitializeComponent();
            pessoa.Nome("Ana");
            lblNometxt.Text = pessoa.nome;
            pessoa.Idade(20);
            lblIdadetxt.Text = (pessoa.idade).ToString();
            pessoa.Qualidade("Brava");
            lblQualidadetxt.Text = pessoa.qualidade;
            pessoa.Vida(100);
            lblVidatxt.Text = (pessoa.vida).ToString();
        }

        private void btnAtacar_Click(object sender, EventArgs e)
        {
            pessoa.Ataque(10);
            lblVidatxt.Text = (pessoa.vida).ToString();
        }

        private void btnRecuperar_Click(object sender, EventArgs e)
        {
            pessoa.Recuperar(10);
            lblVidatxt.Text = (pessoa.vida).ToString();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            pessoa.Nome("Outro");
            lblNometxt.Text = pessoa.nome;
            pessoa.Idade(31);
            lblIdadetxt.Text = (pessoa.idade).ToString();
            pessoa.Qualidade("Não Tem");
            lblQualidadetxt.Text = pessoa.qualidade;
            pessoa.Vida(100);
            lblVidatxt.Text = (pessoa.vida).ToString();
        }
    }
}
