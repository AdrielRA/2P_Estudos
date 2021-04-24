using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int[,] Sudoku = new int[9, 9] {{0,0,0,0,0,0,0,0,0},
                                              {0,0,0,0,0,0,0,0,0},
                                              {0,0,0,0,0,0,0,0,0},
                                              {0,0,0,0,0,0,0,0,0},
                                              {0,0,0,0,0,0,0,0,0},
                                              {0,0,0,0,0,0,0,0,0},
                                              {0,0,0,0,0,0,0,0,0},
                                              {0,0,0,0,0,0,0,0,0},
                                              {0,0,0,0,0,0,0,0,0}};

        public Random random = new Random();

        public bool alterar = true;


        private void zerar_Sudoku()
        {
            int i, j;

            for (i = 0; i < 9; i++)
            {
                for (j = 0; j < 9; j++)
                {
                    Sudoku[i, j] = 0;
                }
            }
        }

        private void mostrar()
        {
            int i, j;

            alterar = false;

            TextBox b = null;

            i = j = 8;

            foreach (Control c in this.tab_Sudoku.Controls)
            {
                b = c as TextBox;
                if (Sudoku[i, j] != 0)
                {
                    b.Text = (Sudoku[i, j]).ToString();
                }
                else
                {
                    b.Text = "";
                }
                if (j == 0)
                {
                    j = 8;
                    i--;
                }
                else
                {
                    j--;
                }
            }
            alterar = true;
        }


        private void escrever()
        {
            int i, j;

            for (i = 0; i < 9; i++)
            {

                Console.Write("[ ");
                for (j = 0; j < 9; j++)
                {
                    Console.Write("{0} ", Sudoku[i, j]);
                }
                Console.WriteLine("] ");
            }

            Console.WriteLine();
        }


        private int verifica_ho(int l, int n)
        {
            int j;
            for (j = 0; j < 9; j++)
            {
                if (Sudoku[l, j] == n)
                {
                    return 1;
                }
            }

            return 0;
        }

        private int verifica_ve(int c, int n)
        {
            int j;
            for (j = 0; j < 9; j++)
            {
                if (Sudoku[j, c] == n)
                {
                    return 1;
                }
            }

            return 0;
        }

        private int verifica_qa(int l, int c, int n)
        {
            int f, g;
            for (f = c - 3; f < c; f++)
                for (g = l - 3; g < l; g++)
                    if (Sudoku[g, f] == n)
                    {
                        return 1;
                    }

            return 0;
        }

        private void gerar_Sudoku(int i)
        {
            int n, j, x, y, qx = 0, qy = 0, f, g;
            bool ok;

            alterar = false;

            for (i = 0; i < 27; i++)
            {
                ok = true;

                x = random.Next(0, 9);
                y = random.Next(0, 9);

                n = random.Next(1, 10);


                if (verifica_ve(x,n) == 1)
                {
                    j = 9;
                    if (ok)
                    {
                        i = i - 1;
                        ok = false;
                    }
                }

                if (verifica_ho(y, n) == 1)
                {
                    j = 9;
                    if (ok)
                    {
                        i = i - 1;
                        ok = false;
                    }
                }

                if (x < 3) qx = 3;
                else if (x < 6) qx = 6;
                else qx = 9;

                if (y < 3) qy = 3;
                else if (y < 6) qy = 6;
                else qy = 9;

                if (verifica_qa(qy, qx, n) == 1)
                {
                    if (ok)
                    {
                        i = i - 1;
                        ok = false;
                    }
                }

                //for (f = qx - 3; f < qx; f++)
                //    for (g = qy - 3; g < qy; g++)
                //        if (Sudoku[g, f] == n) {
                //            f = qx;
                //            g = qy;
                //            if (ok)
                //            {
                //                i = i - 1;
                //                ok = false;
                //            }
                //        }

                if (ok)
                {
                    Sudoku[y, x] = n;
                }
            }
            
            escrever();
            mostrar();

            
        }

        public int verifica(int lin, int col, int n)
        {

            int l, c, lr, cr;

            if (Sudoku[lin, col] == n) return 1;
            if (Sudoku[lin, col] != 0) return 0;
            for (c = 0; c < 9; c++)
                if (Sudoku[lin, c] == n) return 0;
            for (l = 0; l < 9; l++)
                if (Sudoku[l, col] == n) return 0;
            lr = lin / 3;
            cr = col / 3;
            for (l = lr * 3; l < (lr + 1) * 3; l++)
                for (c = cr * 3; c < (cr + 1) * 3; c++)
                    if (Sudoku[l, c] == n) return 0;

            return 1;

        }


        public int resolver(int lin, int col)
        {
            int n, t;

            if (lin > 8)
            {

                mostrar();
            }
            else
            {
                alterar = false;
                for (n = 1; n <= 9; n++)
                {
                    if (verifica(lin, col, n) == 1)
                    {
                        t = Sudoku[lin, col];
                        Sudoku[lin, col] = n;
                        if (col == 8)
                        {
                            resolver(lin + 1, 0);
                        }
                        else
                        {
                            resolver(lin, col + 1);
                        }
                        Sudoku[lin, col] = t;
                    }
                }
                alterar = true;
            }

            return 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            zerar_Sudoku();
            gerar_Sudoku(27);
        }

        private void novoJogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            zerar_Sudoku();
            gerar_Sudoku(27);
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dev. Adriel Ricardo Azevedo\nadrieldesigner@hotmail.com\n\nLançamento: 25/08/18\nAtualização:  27/08/18\nVersão: v1.0.1", "Sobre", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void resolverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resolver(0,0);
            escrever();
        }

        private void Altera_Val(object sender, EventArgs e)
        {
            int a, b, num;


            TextBox txt_b = (TextBox)sender;

            a = (Convert.ToInt32(txt_b.Name[1])) - 48;
            b = (Convert.ToInt32(txt_b.Name[2])) - 48;
            

            if (alterar)
            {
                if (txt_b.Text != "")
                {
                    num = Convert.ToInt32(txt_b.Text);

                    if (verifica_ho(a, num) == 0 && verifica_ve(b, num) == 0 && verifica_qa(a, b, num) == 0 && (Sudoku[a, b] > 1 || Sudoku[a, b] < 9))
                    {
                        Sudoku[a, b] = Convert.ToInt32(txt_b.Text);

                        Console.WriteLine("Valor de {0}x{1} = {2}", a, b, Sudoku[a, b]);
                    }
                    else
                    {
                        Sudoku[a, b] = 0;
                        mostrar();
                    }
                }
                else Sudoku[a, b] = 0;
            }

            
            
        }
    }
}
