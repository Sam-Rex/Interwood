using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Drawing;

namespace EOM_stores.dataChannel
{
    class roundedButton:Button
    {

        GraphicsPath getRoundedPath (RectangleF Rect,int radius)
        {
            float r2 = radius / 2f;
            GraphicsPath Gpath = new GraphicsPath();
            Gpath.AddArc(Rect.X, Rect.Y, radius, radius, 180, 90);
            Gpath.AddLine(Rect.X + r2, Rect.Y, Rect.Width - r2, Rect.Y);
            Gpath.AddArc(Rect.X + Rect.Width - radius, Rect.Y, radius, radius, 270, 90);
            Gpath.AddLine(Rect.Width, Rect.Y + r2, Rect.Width, Rect.Height - r2);
            Gpath.AddArc(Rect.X+Rect.Width-radius,Rect.Y+Rect.Height-radius,radius,radius,0,0);
            Gpath.AddLine(Rect.Width-r2,Rect.Height,Rect.X+r2,Rect.Height);
            Gpath.AddArc(Rect.X,Rect.Y+Rect.Height - radius,radius,radius,90,90);
            Gpath.AddLine(Rect.X,Rect.Height-r2,Rect.X,Rect.Y+r2);
            Gpath.CloseFigure();
            return Gpath;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            RectangleF Rect = new RectangleF(0, 0, Width, Height);
            GraphicsPath Gpath = getRoundedPath(Rect, 10);
            this.Region = new Region(Gpath);
            using (Pen pen = new Pen(Color.CadetBlue, 1.75F))
            {
                pen.Alignment = PenAlignment.Inset;
                e.Graphics.DrawPath(pen, Gpath);
            }
        }

    }
}
