using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace miniPaint
{
    class Sandbox: Figure
    {
        public Sandbox()
        {
        }

        public override void Draw(Pen drawingPen, Graphics graph, int startX, int startY, int x, int y)
        {
            //throw new NotImplementedException();
        }

        public override void DrawMove(Pen drawingPen, Graphics graph, int startX, int startY, int x, int y)
        {
            graph.DrawEllipse(drawingPen, startX, startY, x, y);
        }
    }
}
