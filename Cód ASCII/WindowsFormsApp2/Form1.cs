using System;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApp2
{
    public partial class Tela : Form
    {
        public Tela()
        {
            InitializeComponent();
        }

        private bool _ShiftPressed = false;

        private void Tela_KeyDown(object sender, KeyEventArgs e)
        {
            Valor.Text = Convert.ToString(e.KeyValue);
            if (e.KeyCode == Keys.Up)
            {
                Func.Text = "Seta para cima";
            }
            else if (e.KeyCode == Keys.Down)
            {
                Func.Text = "Seta para baixo";
            }
            else if (e.KeyCode == Keys.Right)
            {
                Func.Text = "Seta para direita";
            }
            else if (e.KeyCode == Keys.Left)
            {
                Func.Text = "Seta para esquerda";
            }
            else if (e.KeyCode == Keys.Space)
            {
                Func.Text = "Espaço";
            }
            else if (e.KeyCode == Keys.Enter)
            {
                Func.Text = "ENTER";
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Func.Text = "Tecla ESC";
                Thread.Sleep(2000);
                Application.Exit();
            }
            else if (e.KeyCode == Keys.ControlKey)
            {
                Func.Text = "Tecla Ctrl";
            }
            else if (e.KeyCode == Keys.ShiftKey)
            {
                Func.Text = "Tecla Shift";
                _ShiftPressed = true;
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Tab)
            {
                Func.Text = "Tecla TAB";
            }
            else if (e.KeyCode == Keys.Menu)
            {
                Func.Text = "Tecla Alt";
            }
            else if (e.KeyCode == Keys.CapsLock)
            {
                Func.Text = "Tecla CapsLock";
            }
            else if (e.KeyCode == Keys.NumLock)
            {
                Func.Text = "Tecla NumLock";
            }
            else if (e.KeyCode == Keys.Scroll)
            {
                Func.Text = "Tecla ScrollLock";
            }
            else if (e.KeyCode == Keys.PrintScreen)
            {
                Func.Text = "Tecla PrintScreen";
            }
            else if (e.KeyCode == Keys.VolumeDown)
            {
                Func.Text = "Tecla Volume -";
            }
            else if (e.KeyCode == Keys.VolumeUp)
            {
                Func.Text = "Tecla Volume +";
            }
            else if (e.KeyCode == Keys.VolumeMute)
            {
                Func.Text = "Tecla Mudo";
            }
            else if (e.KeyCode == Keys.LWin)
            {
                Func.Text = "Tecla Windows";
            }
            else if (e.KeyCode == Keys.RWin)
            {
                Func.Text = "Tecla Windows";
            }
            else if (e.KeyCode == Keys.Back)
            {
                Func.Text = "Tecla APAGAR";
            }
            else if (e.KeyCode == Keys.F1)
            {
                Func.Text = "Tecla F1";
            }
            else if (e.KeyCode == Keys.F2)
            {
                Func.Text = "Tecla F2";
            }
            else if (e.KeyCode == Keys.F3)
            {
                Func.Text = "Tecla F3";
            }
            else if (e.KeyCode == Keys.F4)
            {
                Func.Text = "Tecla F4";
            }
            else if (e.KeyCode == Keys.F5)
            {
                Func.Text = "Tecla F5";
            }
            else if (e.KeyCode == Keys.F6)
            {
                Func.Text = "Tecla F6";
            }
            else if (e.KeyCode == Keys.F7)
            {
                Func.Text = "Tecla F7";
            }
            else if (e.KeyCode == Keys.F8)
            {
                Func.Text = "Tecla F8";
            }
            else if (e.KeyCode == Keys.F9)
            {
                Func.Text = "Tecla F9";
            }
            else if (e.KeyCode == Keys.F10)
            {
                Func.Text = "Tecla F10";
            }
            else if (e.KeyCode == Keys.F11)
            {
                Func.Text = "Tecla F11";
            }
            else if (e.KeyCode == Keys.F12)
            {
                Func.Text = "Tecla F12";
            }
            else if (e.KeyCode == Keys.F13)
            {
                Func.Text = "Tecla F13";
            }
            else if (e.KeyData == (Keys.Control | Keys.C))
            {
                Func.Text = "Comando COPIAR";
            }
            else if (e.KeyData == (Keys.Control | Keys.V))
            {
                Func.Text = "Comando COLAR";
            }
            else if (e.KeyData == (Keys.Control | Keys.Z))
            {
                Func.Text = "Comando DESFAZER";
            }
            else if (e.KeyData == (Keys.Control | Keys.S))
            {
                Func.Text = "Comando SALVAR";
            }
            else if (e.KeyData == (Keys.Control | Keys.X))
            {
                Func.Text = "Comando RECORTAR";
            }
            else if (e.KeyValue >= 32)
            {
                if (_ShiftPressed)
                {
                    _ShiftPressed = false;
                    Func.Text = "Caracter " + e.KeyData;
                }
                else
                {
                    Valor.Text = Convert.ToString(e.KeyValue+32);
                    Func.Text = "Caracter " + Convert.ToChar(e.KeyValue+32);
                }
            }
            else
            {
                Func.Text = "Outra Tecla";
            }
            e.Handled = true;
        }

        private void Tela_KeyDown()
        {
            throw new NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_OK_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }
    }
}
