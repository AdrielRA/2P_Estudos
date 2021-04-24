using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fundo_Transparente
{
    class CircularButtom : Button
    {
        protected override void OnPaint(PaintEventArgs pevent)
        {
            GraphicsPath grPaph = new GraphicsPath();

            grPaph.AddEllipse(0,0, ClientSize.Width, ClientSize.Height);
            this.Region = new System.Drawing.Region(grPaph);

            base.OnPaint(pevent);
        }
    }
}
