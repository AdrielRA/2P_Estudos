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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            lbl_titulo2.Text = this.Text;
        }

        private void lbl_X_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
