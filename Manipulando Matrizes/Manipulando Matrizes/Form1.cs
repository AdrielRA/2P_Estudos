using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manipulando_Matrizes
{
    public partial class Frm_Principal : Form
    {

        public int [,] array = new int[3,4] { { 3, 5, 8, 13 }, { 1, 2, 2, 3 }, { 99, 5, 25, 36 } };
        public int Cx = 20, Cy = 10;
        public bool ok = false;

        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void Lbl_X_MouseEnter(object sender, EventArgs e)
        {
            Lbl_X.Font = new Font(Lbl_X.Font.FontFamily, 16, FontStyle.Bold);
        }

        private void Lbl_X_MouseLeave(object sender, EventArgs e)
        {
            Lbl_X.Font = new Font(Lbl_X.Font.FontFamily, 14, FontStyle.Bold);
        }

        private void Lbl_X_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Pan_Base_Paint(object sender, PaintEventArgs e)
        {
            if (!ok) {
                for (int i = 0; i < 3; i++)
                {
                    Label lbl1 = new Label();
                    lbl1.Name = "Lbl_[" + Convert.ToString(i);
                    lbl1.AutoSize = true;
                    lbl1.Location = new Point(5, Cy);
                    lbl1.Text = "[";
                    lbl1.ForeColor = Color.Black;
                    Pan_Base.Controls.Add(lbl1);

                    for (int j = 0; j < 4; j++)
                    {
                        Label lbl = new Label();
                        lbl.Name = "Lbl_" + Convert.ToString(i) + "x" + Convert.ToString(j);
                        lbl.AutoSize = false;
                        lbl.Location = new Point(Cx, Cy);
                        Cx = Cx + lbl.Width;
                        lbl.TextAlign = ContentAlignment.MiddleCenter;
                        lbl.Text = Convert.ToString(array[i, j]);
                        lbl.ForeColor = Color.Black;
                        Pan_Base.Controls.Add(lbl);
                    }

                    Label lbl2 = new Label();
                    lbl2.Name = "Lbl_]" + Convert.ToString(i);
                    lbl2.AutoSize = true;
                    lbl2.Location = new Point(Cx, Cy);
                    lbl2.Text = "]";
                    lbl2.ForeColor = Color.Black;
                    Pan_Base.Controls.Add(lbl2);

                    Cx = 20;
                    Cy = Cy + 30;
                }
                ok = !ok;
            }
        }
    }
}
