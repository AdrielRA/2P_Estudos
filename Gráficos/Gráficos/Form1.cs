using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gráficos
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();

            chtGrafico.Legends.Clear();
            chtGrafico.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Range;
        }

        private void chb3D_CheckedChanged(object sender, EventArgs e)
        {
            if (chb3D.Checked)
            {
                chtGrafico.ChartAreas[0].Area3DStyle.Enable3D = true;
            }
            else
            {
                chtGrafico.ChartAreas[0].Area3DStyle.Enable3D = false;
            }
        }

        int X = 1999;

        private void timer_Tick(object sender, EventArgs e)
        {
            if (chtGrafico.Series[0].Points.Count > 11)
            {
                chtGrafico.Series[0].Points.RemoveAt(0);
                chtGrafico.Update();
            }

            chtGrafico.Series[0].Points.AddXY(X++, new Random().Next(0,100));
        }
    }
}
