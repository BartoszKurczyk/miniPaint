using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniPaint
{
    class Line: Figure
    {
        public Line()
        {

        }

        public override void Draw(Pen drawingPen, Graphics graph, int startX, int startY, int x, int y)
        {
            graph.DrawLine(drawingPen, startX, startY, x, y);
        }

        public override void DrawMove(Pen drawingPen, Graphics graph, int startX, int startY, int x, int y)
        {
            //throw new NotImplementedException();
        }
    }
}
